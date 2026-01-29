using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Grades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    GeoJsonPolygon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategorySubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryFolders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryFolders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelatedEntityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedEntityId = table.Column<int>(type: "int", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LibraryItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FolderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoredFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeBytes = table.Column<long>(type: "bigint", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryItems_LibraryFolders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "LibraryFolders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganizerId = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Users_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SavedAnnouncements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AnnouncementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedAnnouncements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedAnnouncements_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedAnnouncements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Users_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AchievementId = table.Column<int>(type: "int", nullable: false),
                    UnlockedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAchievements_Achievements_AchievementId",
                        column: x => x.AchievementId,
                        principalTable: "Achievements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActivityType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    EntityName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomBookingRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecurrencePattern = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecurrenceEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestedByUserId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ReviewedByAdminId = table.Column<int>(type: "int", nullable: true),
                    ReviewedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBookingRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomBookingRequests_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomBookingRequests_Users_RequestedByUserId",
                        column: x => x.RequestedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomBookingRequests_Users_ReviewedByAdminId",
                        column: x => x.ReviewedByAdminId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecurrencePattern = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecurrenceEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByProfessorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Users_CreatedByProfessorId",
                        column: x => x.CreatedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventParticipants",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    JoinedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventParticipants", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_EventParticipants_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventParticipants_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SavedEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedEvents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    UploadedByProfessorId = table.Column<int>(type: "int", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseMaterials_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseMaterials_Users_UploadedByProfessorId",
                        column: x => x.UploadedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupAnnouncements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    AnnouncementId = table.Column<int>(type: "int", nullable: false),
                    ForwardedByProfessorId = table.Column<int>(type: "int", nullable: false),
                    ForwardedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupAnnouncements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupAnnouncements_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupAnnouncements_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupAnnouncements_Users_ForwardedByProfessorId",
                        column: x => x.ForwardedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    JoinedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupMembers_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByProfessorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupTasks_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupTasks_Users_CreatedByProfessorId",
                        column: x => x.CreatedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByProfessorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Users_CreatedByProfessorId",
                        column: x => x.CreatedByProfessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SavedTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    SavedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedTasks_GroupTasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "GroupTasks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SavedTasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "Description", "Icon", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 27, 14, 13, 36, 472, DateTimeKind.Utc).AddTicks(9111), "Complete your first task", "🎯", true, "First Steps" },
                    { 2, new DateTime(2026, 1, 27, 14, 13, 36, 472, DateTimeKind.Utc).AddTicks(9442), "Complete 5 tasks", "⭐", true, "Task Master" },
                    { 3, new DateTime(2026, 1, 27, 14, 13, 36, 472, DateTimeKind.Utc).AddTicks(9445), "Complete 10 tasks", "🏆", true, "Task Legend" },
                    { 4, new DateTime(2026, 1, 27, 14, 13, 36, 472, DateTimeKind.Utc).AddTicks(9448), "Join your first group", "👥", true, "Team Player" },
                    { 5, new DateTime(2026, 1, 27, 14, 13, 36, 472, DateTimeKind.Utc).AddTicks(9451), "Attend your first event", "🦋", true, "Social Butterfly" }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "GeoJsonPolygon", "IsActive", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { 1, "B-dul Regina Elisabeta nr. 4-12, etaj 1, sector 3, București", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4694), "FAA - Sediu în clădirea Chimiei", null, true, 44.434719999999999, 26.100719999999999, "Facultatea de Administrație și Afaceri" },
                    { 2, "Splaiul Independenței nr. 91-95, sector 5, București, 050095", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4857), "Facultatea de Biologie", null, true, 44.435299999999998, 26.06326, "Facultatea de Biologie" },
                    { 3, "Bd. Regina Elisabeta nr. 4-12, sector 3, București, 030018", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4860), "Facultatea de Chimie", null, true, 44.434719999999999, 26.100719999999999, "Facultatea de Chimie" },
                    { 4, "Bd. Mihail Kogălniceanu nr. 36-46, sector 5, București, 050107", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4862), "Facultatea de Drept", null, true, 44.435240999999998, 26.082077000000002, "Facultatea de Drept" },
                    { 5, "Splaiul Independenței nr. 204, sector 6, București, 060024", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4865), "Facultatea de Filosofie", null, true, 44.434710000000003, 26.04824, "Facultatea de Filosofie" },
                    { 6, "Str. Atomiștilor nr. 405, Măgurele, Ilfov, 077125", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4868), "Facultatea de Fizică - Campus Măgurele", null, true, 44.34834, 26.031279999999999, "Facultatea de Fizică" },
                    { 7, "Bd. Nicolae Bălcescu nr. 1, sector 1, București, 010041", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4871), "Facultatea de Geografie", null, true, 44.436540000000001, 26.101890000000001, "Facultatea de Geografie" },
                    { 8, "Str. Traian Vuia nr. 6, sector 2, București, 020956", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4873), "Facultatea de Geologie și Geofizică", null, true, 44.45167, 26.07901, "Facultatea de Geologie și Geofizică" },
                    { 9, "Str. Academiei nr. 14, București", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4876), "Facultatea de Istorie", null, true, 44.435839999999999, 26.096830000000001, "Facultatea de Istorie" },
                    { 10, "Bd. Iuliu Maniu nr. 1-3, Complex Leu, Corp A, etaj 6, sector 6, București", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4878), "FJSC - Complex Leu", null, true, 44.43891, 26.043209999999998, "Facultatea de Jurnalism și Științele Comunicării" },
                    { 11, "Str. Edgar Quinet nr. 5-7, sector 1, București, 010017", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4883), "FLLS", null, true, 44.435830000000003, 26.100809999999999, "Facultatea de Limbi și Literaturi Străine" },
                    { 12, "Str. Edgar Quinet nr. 5-7, sector 1, București, 010017", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4904), "Facultatea de Litere", null, true, 44.435830000000003, 26.100809999999999, "Facultatea de Litere" },
                    { 13, "Str. Academiei nr. 14, sector 1, București, 010014", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4914), "FMI", null, true, 44.435839999999999, 26.096830000000001, "Facultatea de Matematică și Informatică" },
                    { 14, "Șos. Panduri nr. 90-91, București", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4917), "FPSE", null, true, 44.432209999999998, 26.068919999999999, "Facultatea de Psihologie și Științele Educației" },
                    { 15, "Bd. Schitu Măgureanu nr. 9, București", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4919), "SAS", null, true, 44.433419999999998, 26.09421, "Facultatea de Sociologie și Asistență Socială" },
                    { 16, "Calea Plevnei nr. 59, București, 010223", new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(4922), "FSP", null, true, 44.445210000000003, 26.083919999999999, "Facultatea de Științe Politice" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "f4eeecb4-ea68-45d9-b18e-0fb7ee1215f2", "Admin", "ADMIN" },
                    { 2, "c9c87cb2-4489-463e-95f0-a8ff4d95c135", "User", "USER" },
                    { 3, "cdae180a-97f9-4af8-aeeb-d5d5dd455748", "Professor", "PROFESSOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastLoginAt", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "StudentId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 10, 0, "bab3c10e-49b0-46f7-b849-0e2a258c93af", new DateTime(2026, 1, 27, 14, 13, 35, 994, DateTimeKind.Utc).AddTicks(4498), null, "admin1@unibuc.ro", true, "Andrei", null, "Popescu", false, null, "ADMIN1@UNIBUC.RO", "ADMIN1@UNIBUC.RO", "AQAAAAIAAYagAAAAEHBPhgXdsTt4WwIp+B8n/v3V2E9nwqHoYCTZNMy/i+9Sgsw1WiSrZ2a4PczaTGXZPA==", null, false, null, "b0796a1b-53fe-4fda-a8c3-7e2b08da25a5", null, false, "admin1@unibuc.ro" },
                    { 11, 0, "9601d905-b11b-4d30-ab0d-d90cfbf1d516", new DateTime(2026, 1, 27, 14, 13, 36, 75, DateTimeKind.Utc).AddTicks(9893), null, "admin2@unibuc.ro", true, "Maria", null, "Ionescu", false, null, "ADMIN2@UNIBUC.RO", "ADMIN2@UNIBUC.RO", "AQAAAAIAAYagAAAAEJmDQ/v76cngiLeo7Ioi8qsoJX3lMwSyvMwlQRtnVQf4W+345NLzkIZ4AmKjAsT5lg==", null, false, null, "0ebfd5a3-0d43-4cac-a687-a2badd243ca5", null, false, "admin2@unibuc.ro" },
                    { 12, 0, "f1b20c64-440f-4dcc-92e3-d0c42a6c608c", new DateTime(2026, 1, 27, 14, 13, 36, 146, DateTimeKind.Utc).AddTicks(3214), null, "student1@s.unibuc.ro", true, "Ion", null, "Vasilescu", false, null, "STUDENT1@S.UNIBUC.RO", "STUDENT1@S.UNIBUC.RO", "AQAAAAIAAYagAAAAECJ5sXhVrDG7i7dpd3VtPnA/a/oFKRr0/C/5Gp0R+7QvVRYICfVLM2xQdKEC6bw9kw==", null, false, null, "23fb4226-d1d0-4cb5-9e77-26dcc497559f", null, false, "student1@s.unibuc.ro" },
                    { 13, 0, "3d1e3f97-d773-420b-9b1b-d4582965f3e8", new DateTime(2026, 1, 27, 14, 13, 36, 216, DateTimeKind.Utc).AddTicks(7287), null, "student2@s.unibuc.ro", true, "Elena", null, "Georgescu", false, null, "STUDENT2@S.UNIBUC.RO", "STUDENT2@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEPQigvHGUTR6HvLbiahigOcOl2w/3rSkYiZZMeLtzwp4n/UoOQsn9rdaBv7r8QPTmg==", null, false, null, "4581dbde-b80d-494d-b3df-c58bf92cb7ba", null, false, "student2@s.unibuc.ro" },
                    { 14, 0, "03d9f02c-afef-4a10-b7a8-eff17d2fc15a", new DateTime(2026, 1, 27, 14, 13, 36, 289, DateTimeKind.Utc).AddTicks(1496), null, "anastasia.ispas@s.unibuc.ro", true, "Anastasia", null, "Ispas", false, null, "ANASTASIA.ISPAS@S.UNIBUC.RO", "ANASTASIA.ISPAS@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEP9t88oK6WCf1tp2ni/AAkmWB0Q4krCsBunRnoxFE6Dau/td1MJXu5ZT2WeouRtSOQ==", null, false, null, "c8d8d7ba-3d67-45c7-b484-8d07db4603ab", null, false, "anastasia.ispas@s.unibuc.ro" },
                    { 15, 0, "d389e401-d60b-4ad4-ab19-eaf8673c2449", new DateTime(2026, 1, 27, 14, 13, 36, 362, DateTimeKind.Utc).AddTicks(1116), null, "irina-maria.istrate@s.unibuc.ro", true, "Irina-Maria", null, "Istrate", false, null, "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEJPTpPhzs/C3pefoMZ6P17scKtsVuAITfcmSE8EGZvl/Iy1N1u5MEGVq4BPQd6Y56Q==", null, false, null, "8e4c6604-08e2-4769-917d-3e0357c9c642", null, false, "irina-maria.istrate@s.unibuc.ro" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BuildingId", "Capacity", "CreatedAt", "Equipment", "Floor", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7341), null, "Etaj 1", true, "A101" },
                    { 2, 1, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7463), null, "Etaj 1", true, "A102" },
                    { 3, 1, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7466), null, "Etaj 1", true, "A103" },
                    { 4, 1, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7469), null, "Etaj 1", true, "A104" },
                    { 5, 1, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7472), null, "Etaj 1", true, "A105" },
                    { 6, 1, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7474), null, "Etaj 2", true, "S201" },
                    { 7, 1, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7477), null, "Etaj 2", true, "S202" },
                    { 8, 1, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7480), null, "Etaj 2", true, "S203" },
                    { 9, 1, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7615), "Computere", "Etaj 3", true, "Lab301" },
                    { 10, 1, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7619), "Computere", "Etaj 3", true, "Lab302" },
                    { 11, 2, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7639), null, "Etaj 1", true, "Bio101" },
                    { 12, 2, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7641), null, "Etaj 1", true, "Bio102" },
                    { 13, 2, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7644), null, "Etaj 1", true, "Bio103" },
                    { 14, 2, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7646), null, "Etaj 1", true, "Bio104" },
                    { 15, 2, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7649), null, "Etaj 1", true, "Bio105" },
                    { 16, 2, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7652), "Echipament laborator", "Etaj 2", true, "LabBio201" },
                    { 17, 2, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7655), "Echipament laborator", "Etaj 2", true, "LabBio202" },
                    { 18, 2, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7657), "Echipament laborator", "Etaj 2", true, "LabBio203" },
                    { 19, 2, 200, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7660), "Proiector, Sistem audio", "Parter", true, "AmfBio1" },
                    { 20, 2, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7663), "Proiector", "Parter", true, "AmfBio2" },
                    { 21, 3, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7665), null, "Etaj 1", true, "Ch101" },
                    { 22, 3, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7668), null, "Etaj 1", true, "Ch102" },
                    { 23, 3, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7671), null, "Etaj 1", true, "Ch103" },
                    { 24, 3, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7673), null, "Etaj 1", true, "Ch104" },
                    { 25, 3, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7689), null, "Etaj 1", true, "Ch105" },
                    { 26, 3, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7692), "Echipament chimie", "Etaj 2", true, "LabCh201" },
                    { 27, 3, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7695), "Echipament chimie", "Etaj 2", true, "LabCh202" },
                    { 28, 3, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7697), "Echipament chimie", "Etaj 2", true, "LabCh203" },
                    { 29, 3, 180, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7700), "Proiector, Sistem audio", "Parter", true, "AmfCh1" },
                    { 30, 3, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7703), "Proiector", "Parter", true, "AmfCh2" },
                    { 31, 4, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7705), null, "Etaj 1", true, "D101" },
                    { 32, 4, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7708), null, "Etaj 1", true, "D102" },
                    { 33, 4, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7710), null, "Etaj 1", true, "D103" },
                    { 34, 4, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7713), null, "Etaj 1", true, "D104" },
                    { 35, 4, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7715), null, "Etaj 1", true, "D105" },
                    { 36, 4, 300, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7718), "Sistem audio-video complet", "Parter", true, "AmfD1" },
                    { 37, 4, 250, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7721), "Proiector, Sistem audio", "Parter", true, "AmfD2" },
                    { 38, 4, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7723), null, "Etaj 2", true, "SemD201" },
                    { 39, 4, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7739), null, "Etaj 2", true, "SemD202" },
                    { 40, 4, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7742), null, "Etaj 2", true, "SemD203" },
                    { 41, 5, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7744), null, "Etaj 1", true, "Filo101" },
                    { 42, 5, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7747), null, "Etaj 1", true, "Filo102" },
                    { 43, 5, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7749), null, "Etaj 1", true, "Filo103" },
                    { 44, 5, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7752), null, "Etaj 1", true, "Filo104" },
                    { 45, 5, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7754), null, "Etaj 1", true, "Filo105" },
                    { 46, 5, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7757), "Proiector, Sistem audio", "Parter", true, "AmfFilo1" },
                    { 47, 5, 120, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7760), "Proiector", "Parter", true, "AmfFilo2" },
                    { 48, 5, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7762), null, "Etaj 2", true, "SemFilo201" },
                    { 49, 5, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7765), null, "Etaj 2", true, "SemFilo202" },
                    { 50, 5, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7767), null, "Etaj 2", true, "SemFilo203" },
                    { 51, 6, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7770), null, "Etaj 1", true, "Fiz101" },
                    { 52, 6, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7772), null, "Etaj 1", true, "Fiz102" },
                    { 53, 6, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7775), null, "Etaj 1", true, "Fiz103" },
                    { 54, 6, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7791), null, "Etaj 1", true, "Fiz104" },
                    { 55, 6, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7794), null, "Etaj 1", true, "Fiz105" },
                    { 56, 6, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7796), "Echipament fizică", "Etaj 2", true, "LabFiz201" },
                    { 57, 6, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7799), "Echipament fizică", "Etaj 2", true, "LabFiz202" },
                    { 58, 6, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7802), "Echipament fizică", "Etaj 2", true, "LabFiz203" },
                    { 59, 6, 200, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7814), "Proiector, Sistem audio", "Parter", true, "AmfFiz1" },
                    { 60, 6, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7817), "Proiector", "Parter", true, "AmfFiz2" },
                    { 61, 7, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7819), null, "Etaj 1", true, "Geo101" },
                    { 62, 7, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7822), null, "Etaj 1", true, "Geo102" },
                    { 63, 7, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7824), null, "Etaj 1", true, "Geo103" },
                    { 64, 7, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7827), null, "Etaj 1", true, "Geo104" },
                    { 65, 7, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7829), null, "Etaj 1", true, "Geo105" },
                    { 66, 7, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7832), "Hărți, Computere GIS", "Etaj 2", true, "LabGeo201" },
                    { 67, 7, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7834), "Computere GIS", "Etaj 2", true, "LabGeo202" },
                    { 68, 7, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7852), null, "Etaj 2", true, "SemGeo203" },
                    { 69, 7, 180, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7855), "Proiector, Sistem audio", "Parter", true, "AmfGeo1" },
                    { 70, 7, 120, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7858), "Proiector", "Parter", true, "AmfGeo2" },
                    { 71, 8, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7860), null, "Etaj 1", true, "GG101" },
                    { 72, 8, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7863), null, "Etaj 1", true, "GG102" },
                    { 73, 8, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7865), null, "Etaj 1", true, "GG103" },
                    { 74, 8, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7868), null, "Etaj 1", true, "GG104" },
                    { 75, 8, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7870), null, "Etaj 1", true, "GG105" },
                    { 76, 8, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7873), "Echipament geologic", "Etaj 2", true, "LabGG201" },
                    { 77, 8, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7875), "Echipament geofizic", "Etaj 2", true, "LabGG202" },
                    { 78, 8, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7878), null, "Etaj 2", true, "SemGG203" },
                    { 79, 8, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7881), "Proiector, Sistem audio", "Parter", true, "AmfGG1" },
                    { 80, 8, 120, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7883), "Proiector", "Parter", true, "AmfGG2" },
                    { 81, 9, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7886), null, "Etaj 1", true, "Ist101" },
                    { 82, 9, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7888), null, "Etaj 1", true, "Ist102" },
                    { 83, 9, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7905), null, "Etaj 1", true, "Ist103" },
                    { 84, 9, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7908), null, "Etaj 1", true, "Ist104" },
                    { 85, 9, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7910), null, "Etaj 1", true, "Ist105" },
                    { 86, 9, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7913), null, "Etaj 2", true, "SemIst201" },
                    { 87, 9, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7915), null, "Etaj 2", true, "SemIst202" },
                    { 88, 9, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7918), null, "Etaj 2", true, "SemIst203" },
                    { 89, 9, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7920), "Proiector, Sistem audio", "Parter", true, "AmfIst1" },
                    { 90, 9, 120, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7923), "Proiector", "Parter", true, "AmfIst2" },
                    { 91, 10, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7926), null, "Etaj 6", true, "J101" },
                    { 92, 10, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7928), null, "Etaj 6", true, "J102" },
                    { 93, 10, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7930), null, "Etaj 6", true, "J103" },
                    { 94, 10, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7933), null, "Etaj 6", true, "J104" },
                    { 95, 10, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7936), null, "Etaj 6", true, "J105" },
                    { 96, 10, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7938), "Camere, Echipament video", "Etaj 7", true, "LabMedia201" },
                    { 97, 10, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7955), "Echipament audio", "Etaj 7", true, "LabMedia202" },
                    { 98, 10, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7958), null, "Etaj 7", true, "SemPR203" },
                    { 99, 10, 100, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7961), "Proiector, Sistem audio", "Etaj 6", true, "AmfJ1" },
                    { 100, 10, 20, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7963), "Studio TV/Radio", "Etaj 7", true, "StudioJ2" },
                    { 101, 11, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7966), null, "Etaj 1", true, "LLS101" },
                    { 102, 11, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7968), null, "Etaj 1", true, "LLS102" },
                    { 103, 11, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7971), null, "Etaj 1", true, "LLS103" },
                    { 104, 11, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7973), null, "Etaj 1", true, "LLS104" },
                    { 105, 11, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7976), null, "Etaj 1", true, "LLS105" },
                    { 106, 11, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7978), "Echipament limbi străine", "Etaj 2", true, "LabLingv201" },
                    { 107, 11, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7981), "Computere, Software lingvistic", "Etaj 2", true, "LabLingv202" },
                    { 108, 11, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7984), null, "Etaj 2", true, "SemLLS203" },
                    { 109, 11, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7986), "Proiector, Sistem audio", "Parter", true, "AmfLLS1" },
                    { 110, 11, 120, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(7989), "Proiector", "Parter", true, "AmfLLS2" },
                    { 111, 12, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8004), null, "Etaj 1", true, "Lit101" },
                    { 112, 12, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8007), null, "Etaj 1", true, "Lit102" },
                    { 113, 12, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8009), null, "Etaj 1", true, "Lit103" },
                    { 114, 12, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8012), null, "Etaj 1", true, "Lit104" },
                    { 115, 12, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8014), null, "Etaj 1", true, "Lit105" },
                    { 116, 12, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8017), null, "Etaj 2", true, "SemLit201" },
                    { 117, 12, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8019), null, "Etaj 2", true, "SemLit202" },
                    { 118, 12, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8022), null, "Etaj 2", true, "SemLit203" },
                    { 119, 12, 200, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8024), "Proiector, Sistem audio", "Parter", true, "AmfLit1" },
                    { 120, 12, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8027), "Proiector", "Parter", true, "AmfLit2" },
                    { 121, 13, 300, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8030), "Proiector, Sistem audio premium", "Parter", true, "Amf. Spiru Haret" },
                    { 122, 13, 250, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8032), "Proiector, Sistem audio", "Etaj 3", true, "Amf. Gheorghe Țițeica" },
                    { 123, 13, 200, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8035), "Proiector, Sistem audio", "Etaj 1", true, "Amf. Simion Stoilow" },
                    { 124, 13, 180, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8038), "Proiector, Sistem audio", "Etaj 2", true, "Amf. Dimitrie Pompeiu" },
                    { 125, 13, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8040), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 1" },
                    { 126, 13, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8057), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 2" },
                    { 127, 13, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8065), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 3" },
                    { 128, 13, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8067), null, "Etaj 1", true, "S101" },
                    { 129, 13, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8070), null, "Etaj 1", true, "S102" },
                    { 130, 13, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8073), null, "Etaj 1", true, "S103" },
                    { 131, 14, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8083), null, "Etaj 1", true, "Psi101" },
                    { 132, 14, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8085), null, "Etaj 1", true, "Psi102" },
                    { 133, 14, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8088), null, "Etaj 1", true, "Psi103" },
                    { 134, 14, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8090), null, "Etaj 1", true, "Psi104" },
                    { 135, 14, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8093), null, "Etaj 1", true, "Psi105" },
                    { 136, 14, 20, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8095), "Echipament psihologie", "Etaj 2", true, "LabPsi201" },
                    { 137, 14, 20, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8111), "Computere, Software psiho", "Etaj 2", true, "LabPsi202" },
                    { 138, 14, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8113), null, "Etaj 2", true, "SemEdu203" },
                    { 139, 14, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8116), "Proiector, Sistem audio", "Parter", true, "AmfPsi1" },
                    { 140, 14, 120, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8119), "Proiector", "Parter", true, "AmfPsi2" },
                    { 141, 15, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8121), null, "Etaj 1", true, "SAS101" },
                    { 142, 15, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8124), null, "Etaj 1", true, "SAS102" },
                    { 143, 15, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8126), null, "Etaj 1", true, "SAS103" },
                    { 144, 15, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8128), null, "Etaj 1", true, "SAS104" },
                    { 145, 15, 40, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8131), null, "Etaj 1", true, "SAS105" },
                    { 146, 15, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8133), null, "Etaj 2", true, "SemSAS201" },
                    { 147, 15, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8136), null, "Etaj 2", true, "SemSAS202" },
                    { 148, 15, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8138), null, "Etaj 2", true, "SemSAS203" },
                    { 149, 15, 150, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8141), "Proiector, Sistem audio", "Parter", true, "AmfSAS1" },
                    { 150, 15, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8144), "Computere, Software SPSS", "Etaj 2", true, "LabSAS2" },
                    { 151, 16, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8146), null, "Etaj 1", true, "FSP101" },
                    { 152, 16, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8163), null, "Etaj 1", true, "FSP102" },
                    { 153, 16, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8165), null, "Etaj 1", true, "FSP103" },
                    { 154, 16, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8168), null, "Etaj 1", true, "FSP104" },
                    { 155, 16, 45, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8170), null, "Etaj 1", true, "FSP105" },
                    { 156, 16, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8173), null, "Etaj 2", true, "SemFSP201" },
                    { 157, 16, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8175), null, "Etaj 2", true, "SemFSP202" },
                    { 158, 16, 30, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8178), null, "Etaj 2", true, "SemFSP203" },
                    { 159, 16, 180, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8180), "Proiector, Sistem audio", "Parter", true, "AmfFSP1" },
                    { 160, 16, 25, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8183), "Computere", "Etaj 2", true, "LabFSP2" },
                    { 161, 13, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8075), null, "Parter", true, "S1" },
                    { 162, 13, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8078), null, "Parter", true, "S3" },
                    { 163, 13, 50, new DateTime(2026, 1, 27, 14, 13, 36, 466, DateTimeKind.Utc).AddTicks(8080), null, "Etaj 2", true, "S201" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 3, 14 },
                    { 3, 15 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedAt", "CreatedByProfessorId", "Description", "EndTime", "IsActive", "RecurrenceEndDate", "RecurrencePattern", "RoomId", "StartTime", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 27, 14, 13, 36, 469, DateTimeKind.Utc).AddTicks(5594), 14, "Principii de inginerie software și design patterns", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 121, new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Local), "Curs Inginerie Software" },
                    { 2, new DateTime(2026, 1, 27, 14, 13, 36, 469, DateTimeKind.Utc).AddTicks(5727), 15, "Lucru cu SQL și modelare baze de date", new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 125, new DateTime(2026, 1, 27, 14, 0, 0, 0, DateTimeKind.Local), "Seminar Baze de Date" },
                    { 3, new DateTime(2026, 1, 27, 14, 13, 36, 469, DateTimeKind.Utc).AddTicks(5731), 14, "Algoritmi de sortare și căutare", new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 122, new DateTime(2026, 1, 27, 8, 0, 0, 0, DateTimeKind.Local), "Curs Algoritmi și Structuri de Date" },
                    { 4, new DateTime(2026, 1, 27, 14, 13, 36, 469, DateTimeKind.Utc).AddTicks(5735), 15, "Dreptul persoanelor și al familiei", new DateTime(2026, 1, 27, 14, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 36, new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Local), "Curs Drept Civil" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_Name",
                table: "Buildings",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_CourseMaterials_GroupId",
                table: "CourseMaterials",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseMaterials_UploadedByProfessorId",
                table: "CourseMaterials",
                column: "UploadedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_EventId",
                table: "EventParticipants",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizerId",
                table: "Events",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CreatedByProfessorId",
                table: "Grades",
                column: "CreatedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SubjectId_StudentId_CreatedAt",
                table: "Grades",
                columns: new[] { "SubjectId", "StudentId", "CreatedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupAnnouncements_AnnouncementId",
                table: "GroupAnnouncements",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAnnouncements_ForwardedByProfessorId",
                table: "GroupAnnouncements",
                column: "ForwardedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAnnouncements_GroupId_AnnouncementId",
                table: "GroupAnnouncements",
                columns: new[] { "GroupId", "AnnouncementId" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_GroupId",
                table: "GroupMembers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_UserId_GroupId",
                table: "GroupMembers",
                columns: new[] { "UserId", "GroupId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ProfessorId",
                table: "Groups",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTasks_CreatedByProfessorId",
                table: "GroupTasks",
                column: "CreatedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTasks_GroupId",
                table: "GroupTasks",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryItems_FolderId",
                table: "LibraryItems",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookingRequests_RequestedByUserId",
                table: "RoomBookingRequests",
                column: "RequestedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookingRequests_ReviewedByAdminId",
                table: "RoomBookingRequests",
                column: "ReviewedByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookingRequests_RoomId_StartTime_EndTime",
                table: "RoomBookingRequests",
                columns: new[] { "RoomId", "StartTime", "EndTime" });

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookingRequests_Status",
                table: "RoomBookingRequests",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BuildingId_Name",
                table: "Rooms",
                columns: new[] { "BuildingId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_SavedAnnouncements_AnnouncementId",
                table: "SavedAnnouncements",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedAnnouncements_UserId_AnnouncementId",
                table: "SavedAnnouncements",
                columns: new[] { "UserId", "AnnouncementId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavedEvents_EventId",
                table: "SavedEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedEvents_UserId_EventId",
                table: "SavedEvents",
                columns: new[] { "UserId", "EventId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavedTasks_TaskId",
                table: "SavedTasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedTasks_UserId_TaskId",
                table: "SavedTasks",
                columns: new[] { "UserId", "TaskId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_CreatedByProfessorId",
                table: "Schedules",
                column: "CreatedByProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_RoomId_StartTime_EndTime",
                table: "Schedules",
                columns: new[] { "RoomId", "StartTime", "EndTime" });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Code",
                table: "Subjects",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ProfessorId",
                table: "Subjects",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_UserId_AchievementId",
                table: "UserAchievements",
                columns: new[] { "UserId", "AchievementId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_UserId_CreatedAt",
                table: "UserActivities",
                columns: new[] { "UserId", "CreatedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorySubscriptions");

            migrationBuilder.DropTable(
                name: "CourseMaterials");

            migrationBuilder.DropTable(
                name: "EventParticipants");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "GroupAnnouncements");

            migrationBuilder.DropTable(
                name: "GroupMembers");

            migrationBuilder.DropTable(
                name: "LibraryItems");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "RoomBookingRequests");

            migrationBuilder.DropTable(
                name: "SavedAnnouncements");

            migrationBuilder.DropTable(
                name: "SavedEvents");

            migrationBuilder.DropTable(
                name: "SavedTasks");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "UserAchievements");

            migrationBuilder.DropTable(
                name: "UserActivities");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "LibraryFolders");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "GroupTasks");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
