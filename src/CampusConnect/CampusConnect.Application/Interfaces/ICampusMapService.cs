using CampusConnect.Application.DTOs.CampusMap;

namespace CampusConnect.Application.Interfaces;

public interface ICampusMapService
{
    // Building operations
    Task<IEnumerable<BuildingDto>> GetAllBuildingsAsync();
    Task<BuildingDto?> GetBuildingByIdAsync(int id);
    Task<BuildingDto> CreateBuildingAsync(CreateBuildingRequest request);
    Task<BuildingDto> UpdateBuildingAsync(int id, UpdateBuildingRequest request);
    Task<bool> DeleteBuildingAsync(int id);

    // Room operations
    Task<IEnumerable<RoomDto>> GetRoomsByBuildingAsync(int buildingId);
    Task<RoomDetailsDto?> GetRoomDetailsAsync(int roomId);
    Task<RoomDto> CreateRoomAsync(CreateRoomRequest request);
    Task<RoomDto> UpdateRoomAsync(int id, UpdateRoomRequest request);
    Task<bool> DeleteRoomAsync(int id);

    // Room availability (real-time calculation)
    Task<RoomStatus> GetRoomCurrentStatusAsync(int roomId);
    Task<IEnumerable<RoomDto>> GetAvailableRoomsNowAsync();

    // Schedule operations
    Task<IEnumerable<ScheduleDto>> GetRoomSchedulesAsync(int roomId, DateTime? date);
    Task<IEnumerable<ScheduleDto>> GetRoomSchedulesTodayAsync(int roomId);
    Task<ScheduleDto> CreateScheduleAsync(CreateScheduleRequest request);
    Task<ScheduleDto> UpdateScheduleAsync(int id, UpdateScheduleRequest request);
    Task<bool> DeleteScheduleAsync(int id);
}
