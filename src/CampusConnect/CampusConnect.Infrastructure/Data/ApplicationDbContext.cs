using CampusConnect.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CampusConnect.Infrastructure.Data;


public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>

{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<ApplicationUser> Users { get; set; }

    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<SavedAnnouncement> SavedAnnouncements { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventParticipant> EventParticipants { get; set; }
    public DbSet<SavedEvent> SavedEvents { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupMember> GroupMembers { get; set; }
    public DbSet<GroupTask> GroupTasks { get; set; }
    public DbSet<SavedTask> SavedTasks { get; set; }
    public DbSet<CategorySubscription> CategorySubscriptions { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Achievement> Achievements { get; set; }
    public DbSet<UserAchievement> UserAchievements { get; set; }
    public DbSet<UserActivity> UserActivities { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>(entity =>
        {
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.StudentId)
                .HasMaxLength(50);

            entity.Property(e => e.ProfilePictureUrl)
                .HasMaxLength(500);

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(256);

            entity.HasIndex(e => e.Email)
                .IsUnique();
        });

        builder.Entity<ApplicationUser>().ToTable("Users");
        builder.Entity<IdentityRole<int>>().ToTable("Roles");
        builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
        builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
        builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
        builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
        builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");

        // 1. Seed Roluri
        var adminRole = new IdentityRole<int> 
        { 
            Id = 1, 
            Name = "Admin", 
            NormalizedName = "ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };
        var userRole = new IdentityRole<int> 
        { 
            Id = 2, 
            Name = "User", 
            NormalizedName = "USER",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };
        var professorRole = new IdentityRole<int> 
        { 
            Id = 3, 
            Name = "Professor", 
            NormalizedName = "PROFESSOR",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };
        builder.Entity<IdentityRole<int>>().HasData(adminRole, userRole, professorRole);

        // 2. Creare utilizatori default
        var hasher = new PasswordHasher<ApplicationUser>();

        var admin1 = CreateUser(10, "admin1@unibuc.ro", "Andrei", "Popescu", hasher);
        var admin2 = CreateUser(11, "admin2@unibuc.ro", "Maria", "Ionescu", hasher);
        var user1 = CreateUser(12, "student1@s.unibuc.ro", "Ion", "Vasilescu", hasher);
        var user2 = CreateUser(13, "student2@s.unibuc.ro", "Elena", "Georgescu", hasher);
        var professor1 = CreateUser(14, "anastasia.ispas@s.unibuc.ro", "Anastasia", "Ispas", hasher);
        var professor2 = CreateUser(15, "irina-maria.istrate@s.unibuc.ro", "Irina-Maria", "Istrate", hasher);

        builder.Entity<ApplicationUser>().HasData(admin1, admin2, user1, user2, professor1, professor2);

        // 3. Atribuire roluri utilizatorilor
        builder.Entity<IdentityUserRole<int>>().HasData(
            new IdentityUserRole<int> { UserId = 10, RoleId = 1 }, // Admin 1
            new IdentityUserRole<int> { UserId = 11, RoleId = 1 }, // Admin 2
            new IdentityUserRole<int> { UserId = 12, RoleId = 2 }, // User 1
            new IdentityUserRole<int> { UserId = 13, RoleId = 2 }, // User 2
            new IdentityUserRole<int> { UserId = 14, RoleId = 3 }, // Professor 1
            new IdentityUserRole<int> { UserId = 15, RoleId = 3 }  // Professor 2
        );

        // 4. Configurare SavedAnnouncement
        builder.Entity<SavedAnnouncement>(entity =>
        {
            entity.HasIndex(sa => new { sa.UserId, sa.AnnouncementId }).IsUnique();
            
            entity.HasOne(sa => sa.User)
                  .WithMany()
                  .HasForeignKey(sa => sa.UserId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(sa => sa.Announcement)
                  .WithMany()
                  .HasForeignKey(sa => sa.AnnouncementId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // 5. Configurare Event
        builder.Entity<Event>()
            .HasOne(e => e.Organizer)
            .WithMany() 
            .HasForeignKey(e => e.OrganizerId)
            .OnDelete(DeleteBehavior.Restrict);

        // 6. Configurare EventParticipant
        builder.Entity<EventParticipant>()
            .HasKey(ep => new { ep.UserId, ep.EventId });

        builder.Entity<EventParticipant>()
            .HasOne(ep => ep.Event)
            .WithMany(e => e.Participants)
            .HasForeignKey(ep => ep.EventId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<EventParticipant>()
            .HasOne(ep => ep.User)
            .WithMany(u => u.EventsJoined)
            .HasForeignKey(ep => ep.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        // 7. Configurare Group
        builder.Entity<Group>(entity =>
        {
            entity.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(g => g.Subject)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(g => g.Description)
                .HasMaxLength(1000);

            entity.HasOne(g => g.Professor)
                .WithMany()
                .HasForeignKey(g => g.ProfessorId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // 8. Configurare GroupMember
        builder.Entity<GroupMember>(entity =>
        {
            entity.HasIndex(gm => new { gm.UserId, gm.GroupId }).IsUnique();

            entity.HasOne(gm => gm.Group)
                .WithMany(g => g.Members)
                .HasForeignKey(gm => gm.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(gm => gm.User)
                .WithMany()
                .HasForeignKey(gm => gm.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // 9. Configurare GroupTask
        builder.Entity<GroupTask>(entity =>
        {
            entity.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(300);

            entity.Property(t => t.Description)
                .HasMaxLength(2000);

            entity.HasOne(t => t.Group)
                .WithMany(g => g.Tasks)
                .HasForeignKey(t => t.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(t => t.CreatedByProfessor)
                .WithMany()
                .HasForeignKey(t => t.CreatedByProfessorId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // 10. Configurare SavedTask
        builder.Entity<SavedTask>(entity =>
        {
            entity.HasIndex(st => new { st.UserId, st.TaskId }).IsUnique();

            entity.HasOne(st => st.User)
                .WithMany()
                .HasForeignKey(st => st.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(st => st.Task)
                .WithMany(t => t.SavedByUsers)
                .HasForeignKey(st => st.TaskId)
                .OnDelete(DeleteBehavior.NoAction);
        });

        // 11. Configurare SavedEvent
        builder.Entity<SavedEvent>(entity =>
        {
            entity.HasIndex(se => new { se.UserId, se.EventId }).IsUnique();

            entity.HasOne(se => se.User)
                .WithMany()
                .HasForeignKey(se => se.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(se => se.Event)
                .WithMany()
                .HasForeignKey(se => se.EventId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // 12. Configurare Achievement
        builder.Entity<Achievement>(entity =>
        {
            entity.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(a => a.Description)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(a => a.Icon)
                .IsRequired()
                .HasMaxLength(100);
        });

        // 13. Configurare UserAchievement
        builder.Entity<UserAchievement>(entity =>
        {
            entity.HasIndex(ua => new { ua.UserId, ua.AchievementId }).IsUnique();

            entity.HasOne(ua => ua.User)
                .WithMany(u => u.UserAchievements)
                .HasForeignKey(ua => ua.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(ua => ua.Achievement)
                .WithMany(a => a.UserAchievements)
                .HasForeignKey(ua => ua.AchievementId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // 14. Configurare UserActivity
        builder.Entity<UserActivity>(entity =>
        {
            entity.Property(a => a.ActivityType)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(a => a.EntityType)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(a => a.EntityName)
                .HasMaxLength(300);

            entity.Property(a => a.Description)
                .HasMaxLength(500);

            entity.HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasIndex(a => new { a.UserId, a.CreatedAt });
        });

        // 15. Seed Achievements
        builder.Entity<Achievement>().HasData(
            new Achievement
            {
                Id = 1,
                Title = "First Steps",
                Description = "Complete your first task",
                Icon = "🎯",
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            },
            new Achievement
            {
                Id = 2,
                Title = "Task Master",
                Description = "Complete 5 tasks",
                Icon = "⭐",
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            },
            new Achievement
            {
                Id = 3,
                Title = "Task Legend",
                Description = "Complete 10 tasks",
                Icon = "🏆",
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            },
            new Achievement
            {
                Id = 4,
                Title = "Team Player",
                Description = "Join your first group",
                Icon = "👥",
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            },
            new Achievement
            {
                Id = 5,
                Title = "Social Butterfly",
                Description = "Attend your first event",
                Icon = "🦋",
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            }
        );
    }

    private static ApplicationUser CreateUser(int id, string email, string firstName, string lastName, PasswordHasher<ApplicationUser> hasher)
    {
        var user = new ApplicationUser
        {
            Id = id,
            UserName = email,
            NormalizedUserName = email.ToUpper(),
            Email = email,
            NormalizedEmail = email.ToUpper(),
            FirstName = firstName,
            LastName = lastName,
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            CreatedAt = DateTime.UtcNow
        };
        user.PasswordHash = hasher.HashPassword(user, "Parola@123");
        return user;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    base.OnConfiguring(optionsBuilder);
    // Ignoră eroarea de model pending pentru a permite actualizarea bazei
    optionsBuilder.ConfigureWarnings(w => w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
}
}
