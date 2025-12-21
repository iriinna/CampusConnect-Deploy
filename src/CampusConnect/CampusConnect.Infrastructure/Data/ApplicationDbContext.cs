using CampusConnect.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CampusConnect.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

<<<<<<< Updated upstream
    public DbSet<User> Users { get; set; }

    public DbSet<Post> Posts { get; set; } 
=======
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<SavedAnnouncement> SavedAnnouncements { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventParticipant> EventParticipants { get; set; }
>>>>>>> Stashed changes

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

<<<<<<< Updated upstream
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Content).IsRequired().HasMaxLength(500);

            entity.HasOne<User>()
                  .WithMany()
                  .HasForeignKey(p => p.AuthorId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.HasIndex(u => u.Email).IsUnique();
        });

    }
=======
        // Configurare tabele Identity
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
        builder.Entity<IdentityRole<int>>().HasData(adminRole, userRole);

        // 2. Creare utilizatori default
        var hasher = new PasswordHasher<ApplicationUser>();

        var admin1 = CreateUser(10, "admin1@unibuc.ro", "Andrei", "Popescu", hasher);
        var admin2 = CreateUser(11, "admin2@unibuc.ro", "Maria", "Ionescu", hasher);
        var user1 = CreateUser(12, "student1@s.unibuc.ro", "Ion", "Vasilescu", hasher);
        var user2 = CreateUser(13, "student2@s.unibuc.ro", "Elena", "Georgescu", hasher);

        builder.Entity<ApplicationUser>().HasData(admin1, admin2, user1, user2);

        // 3. Atribuire roluri utilizatorilor
        builder.Entity<IdentityUserRole<int>>().HasData(
            new IdentityUserRole<int> { UserId = 10, RoleId = 1 }, // Admin 1
            new IdentityUserRole<int> { UserId = 11, RoleId = 1 }, // Admin 2
            new IdentityUserRole<int> { UserId = 12, RoleId = 2 }, // User 1
            new IdentityUserRole<int> { UserId = 13, RoleId = 2 }  // User 2
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
>>>>>>> Stashed changes
}