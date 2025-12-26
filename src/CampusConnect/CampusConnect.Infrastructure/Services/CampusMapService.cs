using CampusConnect.Application.DTOs.CampusMap;
using CampusConnect.Application.Interfaces;
using CampusConnect.Domain.Entities;
using CampusConnect.Domain.Services;
using CampusConnect.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CampusConnect.Infrastructure.Services;

public class CampusMapService : ICampusMapService
{
    private readonly ApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    private readonly UserManager<ApplicationUser> _userManager;

    public CampusMapService(
        ApplicationDbContext context,
        ICurrentUserService currentUserService,
        UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _currentUserService = currentUserService;
        _userManager = userManager;
    }

    // Building operations
    public async Task<IEnumerable<BuildingDto>> GetAllBuildingsAsync()
    {
        var buildings = await _context.Buildings
            .Where(b => b.IsActive)
            .Include(b => b.Rooms.Where(r => r.IsActive))
            .ToListAsync();

        return buildings.Select(b => new BuildingDto
        {
            Id = b.Id,
            Name = b.Name,
            Description = b.Description,
            Address = b.Address,
            Latitude = b.Latitude,
            Longitude = b.Longitude,
            GeoJsonPolygon = b.GeoJsonPolygon,
            RoomsCount = b.Rooms.Count
        });
    }

    public async Task<BuildingDto?> GetBuildingByIdAsync(int id)
    {
        var building = await _context.Buildings
            .Include(b => b.Rooms.Where(r => r.IsActive))
            .FirstOrDefaultAsync(b => b.Id == id && b.IsActive);

        if (building == null) return null;

        return new BuildingDto
        {
            Id = building.Id,
            Name = building.Name,
            Description = building.Description,
            Address = building.Address,
            Latitude = building.Latitude,
            Longitude = building.Longitude,
            GeoJsonPolygon = building.GeoJsonPolygon,
            RoomsCount = building.Rooms.Count
        };
    }

    public async Task<BuildingDto> CreateBuildingAsync(CreateBuildingRequest request)
    {
        var building = new Building
        {
            Name = request.Name,
            Description = request.Description,
            Address = request.Address,
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            GeoJsonPolygon = request.GeoJsonPolygon,
            IsActive = true,
            CreatedAt = DateTime.UtcNow
        };

        _context.Buildings.Add(building);
        await _context.SaveChangesAsync();

        return new BuildingDto
        {
            Id = building.Id,
            Name = building.Name,
            Description = building.Description,
            Address = building.Address,
            Latitude = building.Latitude,
            Longitude = building.Longitude,
            GeoJsonPolygon = building.GeoJsonPolygon,
            RoomsCount = 0
        };
    }

    public async Task<BuildingDto> UpdateBuildingAsync(int id, UpdateBuildingRequest request)
    {
        var building = await _context.Buildings.FindAsync(id);
        if (building == null) throw new Exception("Building not found");

        if (request.Name != null) building.Name = request.Name;
        if (request.Description != null) building.Description = request.Description;
        if (request.Address != null) building.Address = request.Address;
        if (request.Latitude.HasValue) building.Latitude = request.Latitude.Value;
        if (request.Longitude.HasValue) building.Longitude = request.Longitude.Value;
        if (request.GeoJsonPolygon != null) building.GeoJsonPolygon = request.GeoJsonPolygon;

        await _context.SaveChangesAsync();

        var roomsCount = await _context.Rooms.CountAsync(r => r.BuildingId == id && r.IsActive);

        return new BuildingDto
        {
            Id = building.Id,
            Name = building.Name,
            Description = building.Description,
            Address = building.Address,
            Latitude = building.Latitude,
            Longitude = building.Longitude,
            GeoJsonPolygon = building.GeoJsonPolygon,
            RoomsCount = roomsCount
        };
    }

    public async Task<bool> DeleteBuildingAsync(int id)
    {
        var building = await _context.Buildings.FindAsync(id);
        if (building == null) return false;

        building.IsActive = false;
        await _context.SaveChangesAsync();
        return true;
    }

    // Room operations
    public async Task<IEnumerable<RoomDto>> GetRoomsByBuildingAsync(int buildingId)
    {
        var rooms = await _context.Rooms
            .Include(r => r.Building)
            .Where(r => r.BuildingId == buildingId && r.IsActive)
            .ToListAsync();

        var roomDtos = new List<RoomDto>();
        foreach (var room in rooms)
        {
            var status = await GetRoomCurrentStatusAsync(room.Id);
            var (occupiedUntil, nextOccupiedAt) = await GetRoomOccupancyTimesAsync(room.Id);

            roomDtos.Add(new RoomDto
            {
                Id = room.Id,
                Name = room.Name,
                Capacity = room.Capacity,
                Floor = room.Floor,
                Equipment = room.Equipment,
                BuildingId = room.BuildingId,
                BuildingName = room.Building.Name,
                CurrentStatus = status,
                OccupiedUntil = occupiedUntil,
                NextOccupiedAt = nextOccupiedAt
            });
        }

        return roomDtos;
    }

    public async Task<RoomDetailsDto?> GetRoomDetailsAsync(int roomId)
    {
        var room = await _context.Rooms
            .Include(r => r.Building)
            .FirstOrDefaultAsync(r => r.Id == roomId && r.IsActive);

        if (room == null) return null;

        var status = await GetRoomCurrentStatusAsync(roomId);
        var (occupiedUntil, nextOccupiedAt) = await GetRoomOccupancyTimesAsync(roomId);
        var todaySchedules = await GetRoomSchedulesTodayAsync(roomId);

        return new RoomDetailsDto
        {
            Id = room.Id,
            Name = room.Name,
            Capacity = room.Capacity,
            Floor = room.Floor,
            Equipment = room.Equipment,
            BuildingId = room.BuildingId,
            BuildingName = room.Building.Name,
            CurrentStatus = status,
            OccupiedUntil = occupiedUntil,
            NextOccupiedAt = nextOccupiedAt,
            TodaySchedules = todaySchedules.ToList()
        };
    }

    public async Task<RoomDto> CreateRoomAsync(CreateRoomRequest request)
    {
        var building = await _context.Buildings.FindAsync(request.BuildingId);
        if (building == null) throw new Exception("Building not found");

        var room = new Room
        {
            Name = request.Name,
            Capacity = request.Capacity,
            Floor = request.Floor,
            Equipment = request.Equipment,
            BuildingId = request.BuildingId,
            IsActive = true,
            CreatedAt = DateTime.UtcNow
        };

        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();

        return new RoomDto
        {
            Id = room.Id,
            Name = room.Name,
            Capacity = room.Capacity,
            Floor = room.Floor,
            Equipment = room.Equipment,
            BuildingId = room.BuildingId,
            BuildingName = building.Name,
            CurrentStatus = RoomStatus.Free,
            OccupiedUntil = null,
            NextOccupiedAt = null
        };
    }

    public async Task<RoomDto> UpdateRoomAsync(int id, UpdateRoomRequest request)
    {
        var room = await _context.Rooms.Include(r => r.Building).FirstOrDefaultAsync(r => r.Id == id);
        if (room == null) throw new Exception("Room not found");

        if (request.Name != null) room.Name = request.Name;
        if (request.Capacity.HasValue) room.Capacity = request.Capacity;
        if (request.Floor != null) room.Floor = request.Floor;
        if (request.Equipment != null) room.Equipment = request.Equipment;

        await _context.SaveChangesAsync();

        var status = await GetRoomCurrentStatusAsync(id);
        var (occupiedUntil, nextOccupiedAt) = await GetRoomOccupancyTimesAsync(id);

        return new RoomDto
        {
            Id = room.Id,
            Name = room.Name,
            Capacity = room.Capacity,
            Floor = room.Floor,
            Equipment = room.Equipment,
            BuildingId = room.BuildingId,
            BuildingName = room.Building.Name,
            CurrentStatus = status,
            OccupiedUntil = occupiedUntil,
            NextOccupiedAt = nextOccupiedAt
        };
    }

    public async Task<bool> DeleteRoomAsync(int id)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room == null) return false;

        room.IsActive = false;
        await _context.SaveChangesAsync();
        return true;
    }

    // Room availability (real-time calculation)
    public async Task<RoomStatus> GetRoomCurrentStatusAsync(int roomId)
    {
        var now = DateTime.Now;
        var today = now.Date;

        var schedules = await _context.Schedules
            .Where(s => s.RoomId == roomId && s.IsActive)
            .ToListAsync();

        // Get today's effective schedules (including weekly recurrence and approved reservations)
        var todaySchedules = GetEffectiveSchedulesForDate(schedules, today);

        // Check if currently occupied
        var currentSchedule = todaySchedules.FirstOrDefault(s =>
            s.StartTime <= now && s.EndTime > now);
        if (currentSchedule != null)
            return RoomStatus.Occupied;

        // Check if occupied in next 30 minutes
        var soonSchedule = todaySchedules.FirstOrDefault(s =>
            s.StartTime > now && s.StartTime <= now.AddMinutes(30));
        if (soonSchedule != null)
            return RoomStatus.OccupiedSoon;

        return RoomStatus.Free;
    }

    public async Task<IEnumerable<RoomDto>> GetAvailableRoomsNowAsync()
    {
        var allRooms = await _context.Rooms
            .Include(r => r.Building)
            .Where(r => r.IsActive)
            .ToListAsync();

        var availableRooms = new List<RoomDto>();
        foreach (var room in allRooms)
        {
            var status = await GetRoomCurrentStatusAsync(room.Id);
            if (status == RoomStatus.Free)
            {
                var (occupiedUntil, nextOccupiedAt) = await GetRoomOccupancyTimesAsync(room.Id);
                availableRooms.Add(new RoomDto
                {
                    Id = room.Id,
                    Name = room.Name,
                    Capacity = room.Capacity,
                    Floor = room.Floor,
                    Equipment = room.Equipment,
                    BuildingId = room.BuildingId,
                    BuildingName = room.Building.Name,
                    CurrentStatus = status,
                    OccupiedUntil = occupiedUntil,
                    NextOccupiedAt = nextOccupiedAt
                });
            }
        }

        return availableRooms;
    }

    // Schedule operations
    public async Task<IEnumerable<ScheduleDto>> GetRoomSchedulesAsync(int roomId, DateTime? date)
    {
        var targetDate = date?.Date ?? DateTime.Today;

        // Get all schedules (including approved reservations which are now in the Schedules table)
        var schedules = await _context.Schedules
            .Include(s => s.Room)
                .ThenInclude(r => r.Building)
            .Include(s => s.CreatedByProfessor)
            .Where(s => s.RoomId == roomId && s.IsActive)
            .ToListAsync();

        var effectiveSchedules = GetEffectiveSchedulesForDate(schedules, targetDate);
        var now = DateTime.Now;

        var scheduleDtos = effectiveSchedules.Select(s => new ScheduleDto
        {
            Id = s.Id,
            Title = s.Title,
            Description = s.Description,
            RoomId = s.RoomId,
            RoomName = s.Room.Name,
            BuildingId = s.Room.BuildingId,
            BuildingName = s.Room.Building.Name,
            StartTime = s.StartTime,
            EndTime = s.EndTime,
            RecurrencePattern = s.RecurrencePattern,
            RecurrenceEndDate = s.RecurrenceEndDate,
            ProfessorName = $"{s.CreatedByProfessor.FirstName} {s.CreatedByProfessor.LastName}",
            IsCurrentlyActive = s.StartTime <= now && s.EndTime > now
        }).OrderBy(s => s.StartTime);

        return scheduleDtos;
    }

    public async Task<IEnumerable<ScheduleDto>> GetRoomSchedulesTodayAsync(int roomId)
    {
        return await GetRoomSchedulesAsync(roomId, DateTime.Today);
    }

    public async Task<ScheduleDto> CreateScheduleAsync(CreateScheduleRequest request)
    {
        var userId = _currentUserService.GetCurrentUserId();
        if (userId == null) throw new UnauthorizedAccessException("User not authenticated");

        var schedule = new Schedule
        {
            Title = request.Title,
            Description = request.Description,
            RoomId = request.RoomId,
            StartTime = request.StartTime,
            EndTime = request.EndTime,
            RecurrencePattern = request.RecurrencePattern,
            RecurrenceEndDate = request.RecurrenceEndDate,
            CreatedByProfessorId = userId.Value,
            IsActive = true,
            CreatedAt = DateTime.UtcNow
        };

        _context.Schedules.Add(schedule);
        await _context.SaveChangesAsync();

        var room = await _context.Rooms.Include(r => r.Building).FirstAsync(r => r.Id == request.RoomId);
        var professor = await _context.Users.FindAsync(userId.Value);

        return new ScheduleDto
        {
            Id = schedule.Id,
            Title = schedule.Title,
            Description = schedule.Description,
            RoomId = schedule.RoomId,
            RoomName = room.Name,
            BuildingId = room.BuildingId,
            BuildingName = room.Building.Name,
            StartTime = schedule.StartTime,
            EndTime = schedule.EndTime,
            RecurrencePattern = schedule.RecurrencePattern,
            RecurrenceEndDate = schedule.RecurrenceEndDate,
            ProfessorName = $"{professor!.FirstName} {professor.LastName}",
            IsCurrentlyActive = false
        };
    }

    public async Task<ScheduleDto> UpdateScheduleAsync(int id, UpdateScheduleRequest request)
    {
        var schedule = await _context.Schedules
            .Include(s => s.Room)
                .ThenInclude(r => r.Building)
            .Include(s => s.CreatedByProfessor)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (schedule == null) throw new Exception("Schedule not found");

        if (request.Title != null) schedule.Title = request.Title;
        if (request.Description != null) schedule.Description = request.Description;
        if (request.StartTime.HasValue) schedule.StartTime = request.StartTime.Value;
        if (request.EndTime.HasValue) schedule.EndTime = request.EndTime.Value;
        if (request.RecurrencePattern != null) schedule.RecurrencePattern = request.RecurrencePattern;
        if (request.RecurrenceEndDate.HasValue) schedule.RecurrenceEndDate = request.RecurrenceEndDate;

        await _context.SaveChangesAsync();

        var now = DateTime.Now;
        return new ScheduleDto
        {
            Id = schedule.Id,
            Title = schedule.Title,
            Description = schedule.Description,
            RoomId = schedule.RoomId,
            RoomName = schedule.Room.Name,
            BuildingId = schedule.Room.BuildingId,
            BuildingName = schedule.Room.Building.Name,
            StartTime = schedule.StartTime,
            EndTime = schedule.EndTime,
            RecurrencePattern = schedule.RecurrencePattern,
            RecurrenceEndDate = schedule.RecurrenceEndDate,
            ProfessorName = $"{schedule.CreatedByProfessor.FirstName} {schedule.CreatedByProfessor.LastName}",
            IsCurrentlyActive = schedule.StartTime <= now && schedule.EndTime > now
        };
    }

    public async Task<bool> DeleteScheduleAsync(int id)
    {
        var schedule = await _context.Schedules.FindAsync(id);
        if (schedule == null) return false;

        schedule.IsActive = false;
        await _context.SaveChangesAsync();
        return true;
    }

    // Helper methods
    private List<Schedule> GetEffectiveSchedulesForDate(List<Schedule> schedules, DateTime date)
    {
        var effectiveSchedules = new List<Schedule>();

        foreach (var schedule in schedules)
        {
            // Check if date is before the schedule starts or after recurrence ends
            if (date < schedule.StartTime.Date)
                continue;

            if (schedule.RecurrenceEndDate.HasValue && date > schedule.RecurrenceEndDate.Value.Date)
                continue;

            bool shouldInclude = false;

            if (string.IsNullOrEmpty(schedule.RecurrencePattern))
            {
                // One-time schedule
                shouldInclude = schedule.StartTime.Date == date;
            }
            else if (schedule.RecurrencePattern == "Daily")
            {
                // Daily recurrence - every day from start to end
                shouldInclude = true;
            }
            else if (schedule.RecurrencePattern == "Weekly")
            {
                // Weekly recurrence - same day of week
                shouldInclude = schedule.StartTime.DayOfWeek == date.DayOfWeek;
            }
            else if (schedule.RecurrencePattern == "BiWeekly")
            {
                // BiWeekly recurrence - every 2 weeks on the same day
                if (schedule.StartTime.DayOfWeek == date.DayOfWeek)
                {
                    var daysDiff = (date - schedule.StartTime.Date).Days;
                    shouldInclude = daysDiff >= 0 && daysDiff % 14 == 0;
                }
            }
            else if (schedule.RecurrencePattern == "Monthly")
            {
                // Monthly recurrence - same day of month
                shouldInclude = schedule.StartTime.Day == date.Day;
            }

            if (shouldInclude)
            {
                var effectiveSchedule = new Schedule
                {
                    Id = schedule.Id,
                    Title = schedule.Title,
                    Description = schedule.Description,
                    RoomId = schedule.RoomId,
                    Room = schedule.Room,
                    StartTime = date.Add(schedule.StartTime.TimeOfDay),
                    EndTime = date.Add(schedule.EndTime.TimeOfDay),
                    RecurrencePattern = schedule.RecurrencePattern,
                    RecurrenceEndDate = schedule.RecurrenceEndDate,
                    CreatedByProfessorId = schedule.CreatedByProfessorId,
                    CreatedByProfessor = schedule.CreatedByProfessor,
                    IsActive = schedule.IsActive,
                    CreatedAt = schedule.CreatedAt
                };
                effectiveSchedules.Add(effectiveSchedule);
            }
        }

        return effectiveSchedules;
    }

    private async Task<(DateTime? occupiedUntil, DateTime? nextOccupiedAt)> GetRoomOccupancyTimesAsync(int roomId)
    {
        var now = DateTime.Now;
        var today = now.Date;

        var schedules = await _context.Schedules
            .Where(s => s.RoomId == roomId && s.IsActive)
            .ToListAsync();

        var todaySchedules = GetEffectiveSchedulesForDate(schedules, today)
            .OrderBy(s => s.StartTime)
            .ToList();

        // Find current schedule
        var currentSchedule = todaySchedules.FirstOrDefault(s =>
            s.StartTime <= now && s.EndTime > now);

        DateTime? occupiedUntil = currentSchedule?.EndTime;

        // Find next schedule
        var nextSchedule = todaySchedules.FirstOrDefault(s => s.StartTime > now);
        DateTime? nextOccupiedAt = nextSchedule?.StartTime;

        return (occupiedUntil, nextOccupiedAt);
    }
}
