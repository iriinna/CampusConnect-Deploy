using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260103131900_InitialCreate.cs
                    { 1, new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3628), "Complete your first task", "🎯", true, "First Steps" },
                    { 2, new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3797), "Complete 5 tasks", "⭐", true, "Task Master" },
                    { 3, new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3799), "Complete 10 tasks", "🏆", true, "Task Legend" },
                    { 4, new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3800), "Join your first group", "👥", true, "Team Player" },
                    { 5, new DateTime(2026, 1, 3, 13, 18, 59, 955, DateTimeKind.Utc).AddTicks(3801), "Attend your first event", "🦋", true, "Social Butterfly" }
========
                    { 1, new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9323), "Complete your first task", "🎯", true, "First Steps" },
                    { 2, new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9572), "Complete 5 tasks", "⭐", true, "Task Master" },
                    { 3, new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9575), "Complete 10 tasks", "🏆", true, "Task Legend" },
                    { 4, new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9577), "Join your first group", "👥", true, "Team Player" },
                    { 5, new DateTime(2026, 1, 17, 10, 41, 20, 702, DateTimeKind.Utc).AddTicks(9578), "Attend your first event", "🦋", true, "Social Butterfly" }
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117104121_InitialCreate.cs
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "GeoJsonPolygon", "IsActive", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260103131900_InitialCreate.cs
                    { 1, "B-dul Regina Elisabeta nr. 4-12, etaj 1, sector 3, București", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6271), "FAA - Sediu în clădirea Chimiei", null, true, 44.434719999999999, 26.100719999999999, "Facultatea de Administrație și Afaceri" },
                    { 2, "Splaiul Independenței nr. 91-95, sector 5, București, 050095", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6365), "Facultatea de Biologie", null, true, 44.435299999999998, 26.06326, "Facultatea de Biologie" },
                    { 3, "Bd. Regina Elisabeta nr. 4-12, sector 3, București, 030018", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6367), "Facultatea de Chimie", null, true, 44.434719999999999, 26.100719999999999, "Facultatea de Chimie" },
                    { 4, "Bd. Mihail Kogălniceanu nr. 36-46, sector 5, București, 050107", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6368), "Facultatea de Drept", null, true, 44.435240999999998, 26.082077000000002, "Facultatea de Drept" },
                    { 5, "Splaiul Independenței nr. 204, sector 6, București, 060024", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6370), "Facultatea de Filosofie", null, true, 44.434710000000003, 26.04824, "Facultatea de Filosofie" },
                    { 6, "Str. Atomiștilor nr. 405, Măgurele, Ilfov, 077125", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6380), "Facultatea de Fizică - Campus Măgurele", null, true, 44.34834, 26.031279999999999, "Facultatea de Fizică" },
                    { 7, "Bd. Nicolae Bălcescu nr. 1, sector 1, București, 010041", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6381), "Facultatea de Geografie", null, true, 44.436540000000001, 26.101890000000001, "Facultatea de Geografie" },
                    { 8, "Str. Traian Vuia nr. 6, sector 2, București, 020956", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6383), "Facultatea de Geologie și Geofizică", null, true, 44.45167, 26.07901, "Facultatea de Geologie și Geofizică" },
                    { 9, "Str. Academiei nr. 14, București", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6384), "Facultatea de Istorie", null, true, 44.435839999999999, 26.096830000000001, "Facultatea de Istorie" },
                    { 10, "Bd. Iuliu Maniu nr. 1-3, Complex Leu, Corp A, etaj 6, sector 6, București", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6386), "FJSC - Complex Leu", null, true, 44.43891, 26.043209999999998, "Facultatea de Jurnalism și Științele Comunicării" },
                    { 11, "Str. Edgar Quinet nr. 5-7, sector 1, București, 010017", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6387), "FLLS", null, true, 44.435830000000003, 26.100809999999999, "Facultatea de Limbi și Literaturi Străine" },
                    { 12, "Str. Edgar Quinet nr. 5-7, sector 1, București, 010017", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6389), "Facultatea de Litere", null, true, 44.435830000000003, 26.100809999999999, "Facultatea de Litere" },
                    { 13, "Str. Academiei nr. 14, sector 1, București, 010014", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6400), "FMI", null, true, 44.435839999999999, 26.096830000000001, "Facultatea de Matematică și Informatică" },
                    { 14, "Șos. Panduri nr. 90-91, București", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6402), "FPSE", null, true, 44.432209999999998, 26.068919999999999, "Facultatea de Psihologie și Științele Educației" },
                    { 15, "Bd. Schitu Măgureanu nr. 9, București", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6403), "SAS", null, true, 44.433419999999998, 26.09421, "Facultatea de Sociologie și Asistență Socială" },
                    { 16, "Calea Plevnei nr. 59, București, 010223", new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(6404), "FSP", null, true, 44.445210000000003, 26.083919999999999, "Facultatea de Științe Politice" }
========
                    { 1, "B-dul Regina Elisabeta nr. 4-12, etaj 1, sector 3, București", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3251), "FAA - Sediu în clădirea Chimiei", null, true, 44.434719999999999, 26.100719999999999, "Facultatea de Administrație și Afaceri" },
                    { 2, "Splaiul Independenței nr. 91-95, sector 5, București, 050095", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3565), "Facultatea de Biologie", null, true, 44.435299999999998, 26.06326, "Facultatea de Biologie" },
                    { 3, "Bd. Regina Elisabeta nr. 4-12, sector 3, București, 030018", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3569), "Facultatea de Chimie", null, true, 44.434719999999999, 26.100719999999999, "Facultatea de Chimie" },
                    { 4, "Bd. Mihail Kogălniceanu nr. 36-46, sector 5, București, 050107", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3571), "Facultatea de Drept", null, true, 44.435240999999998, 26.082077000000002, "Facultatea de Drept" },
                    { 5, "Splaiul Independenței nr. 204, sector 6, București, 060024", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3573), "Facultatea de Filosofie", null, true, 44.434710000000003, 26.04824, "Facultatea de Filosofie" },
                    { 6, "Str. Atomiștilor nr. 405, Măgurele, Ilfov, 077125", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3576), "Facultatea de Fizică - Campus Măgurele", null, true, 44.34834, 26.031279999999999, "Facultatea de Fizică" },
                    { 7, "Bd. Nicolae Bălcescu nr. 1, sector 1, București, 010041", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3578), "Facultatea de Geografie", null, true, 44.436540000000001, 26.101890000000001, "Facultatea de Geografie" },
                    { 8, "Str. Traian Vuia nr. 6, sector 2, București, 020956", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3580), "Facultatea de Geologie și Geofizică", null, true, 44.45167, 26.07901, "Facultatea de Geologie și Geofizică" },
                    { 9, "Str. Academiei nr. 14, București", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3582), "Facultatea de Istorie", null, true, 44.435839999999999, 26.096830000000001, "Facultatea de Istorie" },
                    { 10, "Bd. Iuliu Maniu nr. 1-3, Complex Leu, Corp A, etaj 6, sector 6, București", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3584), "FJSC - Complex Leu", null, true, 44.43891, 26.043209999999998, "Facultatea de Jurnalism și Științele Comunicării" },
                    { 11, "Str. Edgar Quinet nr. 5-7, sector 1, București, 010017", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3585), "FLLS", null, true, 44.435830000000003, 26.100809999999999, "Facultatea de Limbi și Literaturi Străine" },
                    { 12, "Str. Edgar Quinet nr. 5-7, sector 1, București, 010017", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3587), "Facultatea de Litere", null, true, 44.435830000000003, 26.100809999999999, "Facultatea de Litere" },
                    { 13, "Str. Academiei nr. 14, sector 1, București, 010014", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3619), "FMI", null, true, 44.435839999999999, 26.096830000000001, "Facultatea de Matematică și Informatică" },
                    { 14, "Șos. Panduri nr. 90-91, București", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3621), "FPSE", null, true, 44.432209999999998, 26.068919999999999, "Facultatea de Psihologie și Științele Educației" },
                    { 15, "Bd. Schitu Măgureanu nr. 9, București", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3638), "SAS", null, true, 44.433419999999998, 26.09421, "Facultatea de Sociologie și Asistență Socială" },
                    { 16, "Calea Plevnei nr. 59, București, 010223", new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(3640), "FSP", null, true, 44.445210000000003, 26.083919999999999, "Facultatea de Științe Politice" }
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117104121_InitialCreate.cs
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260103131900_InitialCreate.cs
                    { 1, "25bd5818-2cb7-45ce-8e71-eb837a903f5a", "Admin", "ADMIN" },
                    { 2, "b6bd17dd-03ca-41eb-8a99-35583e197198", "User", "USER" },
                    { 3, "f19c7f66-0c54-4a29-84e7-cbeaa2227e8b", "Professor", "PROFESSOR" }
========
                    { 1, "d088f62d-365c-451a-a988-2b79bd48fd72", "Admin", "ADMIN" },
                    { 2, "9433128e-0e72-4f8b-923c-403773fe467b", "User", "USER" },
                    { 3, "d05db648-3e33-4df8-85fd-70eb32a84418", "Professor", "PROFESSOR" }
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117104121_InitialCreate.cs
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastLoginAt", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "StudentId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260103131900_InitialCreate.cs
                    { 10, 0, "56a6082c-161a-4253-a115-2c5f6e8e6c1b", new DateTime(2026, 1, 3, 13, 18, 59, 674, DateTimeKind.Utc).AddTicks(1587), null, "admin1@unibuc.ro", true, "Andrei", null, "Popescu", false, null, "ADMIN1@UNIBUC.RO", "ADMIN1@UNIBUC.RO", "AQAAAAIAAYagAAAAEDJuUAOr2N6HZFJmzQk3RxcpL01ZqDtmjHjHL8PCzOZoVGuUkw483yGqz6buZHWrOg==", null, false, null, "3ae22364-042d-41c7-baf8-9cc4ffd47538", null, false, "admin1@unibuc.ro" },
                    { 11, 0, "b453eab2-8079-4fac-9ad1-3e688ec748c0", new DateTime(2026, 1, 3, 13, 18, 59, 718, DateTimeKind.Utc).AddTicks(3022), null, "admin2@unibuc.ro", true, "Maria", null, "Ionescu", false, null, "ADMIN2@UNIBUC.RO", "ADMIN2@UNIBUC.RO", "AQAAAAIAAYagAAAAENQdVw1zrbGyx2qGD83A43POuQy4FJzqd50VP5zeFoMlnGgZPbNY+DYqZfkXKme+Gw==", null, false, null, "935d2c43-f94c-412d-87d3-0c3c112a1169", null, false, "admin2@unibuc.ro" },
                    { 12, 0, "c8d21bee-7188-4e55-a66d-7b8a16027bf5", new DateTime(2026, 1, 3, 13, 18, 59, 761, DateTimeKind.Utc).AddTicks(5524), null, "student1@s.unibuc.ro", true, "Ion", null, "Vasilescu", false, null, "STUDENT1@S.UNIBUC.RO", "STUDENT1@S.UNIBUC.RO", "AQAAAAIAAYagAAAAENf18kE5uj/W7bcU3JdET6M05AgXV1AphFoLqZRMoZWBfifNjfnQvjcNcK0zfowBGQ==", null, false, null, "53019be7-f616-4b9b-8a86-89c6abab2244", null, false, "student1@s.unibuc.ro" },
                    { 13, 0, "d7624276-da66-4177-bc83-04b65ba40ca5", new DateTime(2026, 1, 3, 13, 18, 59, 804, DateTimeKind.Utc).AddTicks(8898), null, "student2@s.unibuc.ro", true, "Elena", null, "Georgescu", false, null, "STUDENT2@S.UNIBUC.RO", "STUDENT2@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEHPbfnGCOkx1pEqTm9Mh0W7/7nCbSM/8R6NWADsgFGOyQA0gH/B995dRoofaqPItuQ==", null, false, null, "4f7edbda-191c-48a3-9066-c492dc8711c9", null, false, "student2@s.unibuc.ro" },
                    { 14, 0, "21d851f2-5007-4e90-9e73-ac64d696033c", new DateTime(2026, 1, 3, 13, 18, 59, 848, DateTimeKind.Utc).AddTicks(2656), null, "anastasia.ispas@s.unibuc.ro", true, "Anastasia", null, "Ispas", false, null, "ANASTASIA.ISPAS@S.UNIBUC.RO", "ANASTASIA.ISPAS@S.UNIBUC.RO", "AQAAAAIAAYagAAAAECj8trFXhOhd76qz+U2GcH1Ypmj5GI4cMJdD4gtCfDT6cSiUk77gtKtQf6Jp3M0naQ==", null, false, null, "73313559-5394-4007-8c43-510c291b1d21", null, false, "anastasia.ispas@s.unibuc.ro" },
                    { 15, 0, "781af145-a43b-46bf-b495-289f9ccabe20", new DateTime(2026, 1, 3, 13, 18, 59, 891, DateTimeKind.Utc).AddTicks(3237), null, "irina-maria.istrate@s.unibuc.ro", true, "Irina-Maria", null, "Istrate", false, null, "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEP4Boloy+9ZhOOW/5OYQRmnucrpkjxL8arVRtLYovvqMueJXwvIBos5h7Y0sah7Inw==", null, false, null, "408376ad-33d6-49aa-8ee0-266171599659", null, false, "irina-maria.istrate@s.unibuc.ro" }
========
                    { 10, 0, "ae275cb8-1251-4b20-8071-8df20f9b0c47", new DateTime(2026, 1, 17, 10, 41, 20, 384, DateTimeKind.Utc).AddTicks(8578), null, "admin1@unibuc.ro", true, "Andrei", null, "Popescu", false, null, "ADMIN1@UNIBUC.RO", "ADMIN1@UNIBUC.RO", "AQAAAAIAAYagAAAAEO3iK7oax/2VOioJuLWKRnDboHsUYT/nmug2UG45yfcT3fVj9C0aTP+JaHN5YoO0oA==", null, false, null, "9a3562e1-6cdd-4d0a-af87-c6162613c228", null, false, "admin1@unibuc.ro" },
                    { 11, 0, "1a685c9d-5ed8-4728-bdc3-874df61e0bac", new DateTime(2026, 1, 17, 10, 41, 20, 430, DateTimeKind.Utc).AddTicks(9052), null, "admin2@unibuc.ro", true, "Maria", null, "Ionescu", false, null, "ADMIN2@UNIBUC.RO", "ADMIN2@UNIBUC.RO", "AQAAAAIAAYagAAAAENx0++n5a25/eJZhmOsKtUQ97m1IbP7MxXUqyi0VbUo0e1S1Crtupa2y4b0c5D+ouA==", null, false, null, "42dcfd94-a0bc-4282-9ee6-c04dde7e9532", null, false, "admin2@unibuc.ro" },
                    { 12, 0, "0cd7fbb4-9d3c-4849-bb5a-75aaf638eba8", new DateTime(2026, 1, 17, 10, 41, 20, 473, DateTimeKind.Utc).AddTicks(3510), null, "student1@s.unibuc.ro", true, "Ion", null, "Vasilescu", false, null, "STUDENT1@S.UNIBUC.RO", "STUDENT1@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEKVKt7O4ZCLn3HCclPAKDeqhr6QzIKgwUwiXkxOO52/LZQfSPkoTEpP6GW7i+pPFdw==", null, false, null, "78daef8f-8031-4ec6-93c1-de312f64d4a8", null, false, "student1@s.unibuc.ro" },
                    { 13, 0, "088fd7a6-44b5-4c45-b823-78bbf26e9eb1", new DateTime(2026, 1, 17, 10, 41, 20, 517, DateTimeKind.Utc).AddTicks(4158), null, "student2@s.unibuc.ro", true, "Elena", null, "Georgescu", false, null, "STUDENT2@S.UNIBUC.RO", "STUDENT2@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEAyA0tsgnVGLBn01SyTl1IgVBdgOAgWeKtC4+zEkG+5Mb24gR7sfUKDdzgatmTp7aQ==", null, false, null, "fb951b74-ed80-4557-83d9-7d5829c69e4d", null, false, "student2@s.unibuc.ro" },
                    { 14, 0, "9e95a3ad-fdb0-4ea6-988a-0e45facf9849", new DateTime(2026, 1, 17, 10, 41, 20, 559, DateTimeKind.Utc).AddTicks(9241), null, "anastasia.ispas@s.unibuc.ro", true, "Anastasia", null, "Ispas", false, null, "ANASTASIA.ISPAS@S.UNIBUC.RO", "ANASTASIA.ISPAS@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEK+6sp/YfbdzpWUxMgpJVju5KWpn8dAQpncrqtH7iUonTmVMvmqrW5NSBBT6mMMAXA==", null, false, null, "b8630321-21f7-497a-bbf9-2830c06972bc", null, false, "anastasia.ispas@s.unibuc.ro" },
                    { 15, 0, "a5897460-9779-4f46-a4a3-53f7355d72c9", new DateTime(2026, 1, 17, 10, 41, 20, 604, DateTimeKind.Utc).AddTicks(1310), null, "irina-maria.istrate@s.unibuc.ro", true, "Irina-Maria", null, "Istrate", false, null, "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEJS9d2QNPkPGDAAdUod+eRyCax2a0h4S5PXHrZ/RZuXEeHuMqut8ktTxQAGuRKqgCQ==", null, false, null, "d4de69f7-5418-42b1-8cb7-3e5b56ecb445", null, false, "irina-maria.istrate@s.unibuc.ro" }
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117104121_InitialCreate.cs
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BuildingId", "Capacity", "CreatedAt", "Equipment", "Floor", "IsActive", "Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260103131900_InitialCreate.cs
                    { 1, 1, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7595), null, "Etaj 1", true, "A101" },
                    { 2, 1, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7668), null, "Etaj 1", true, "A102" },
                    { 3, 1, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7670), null, "Etaj 1", true, "A103" },
                    { 4, 1, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7671), null, "Etaj 1", true, "A104" },
                    { 5, 1, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7682), null, "Etaj 1", true, "A105" },
                    { 6, 1, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7683), null, "Etaj 2", true, "S201" },
                    { 7, 1, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7685), null, "Etaj 2", true, "S202" },
                    { 8, 1, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7686), null, "Etaj 2", true, "S203" },
                    { 9, 1, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7762), "Computere", "Etaj 3", true, "Lab301" },
                    { 10, 1, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7764), "Computere", "Etaj 3", true, "Lab302" },
                    { 11, 2, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7766), null, "Etaj 1", true, "Bio101" },
                    { 12, 2, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7767), null, "Etaj 1", true, "Bio102" },
                    { 13, 2, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7769), null, "Etaj 1", true, "Bio103" },
                    { 14, 2, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7770), null, "Etaj 1", true, "Bio104" },
                    { 15, 2, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7772), null, "Etaj 1", true, "Bio105" },
                    { 16, 2, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7773), "Echipament laborator", "Etaj 2", true, "LabBio201" },
                    { 17, 2, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7775), "Echipament laborator", "Etaj 2", true, "LabBio202" },
                    { 18, 2, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7777), "Echipament laborator", "Etaj 2", true, "LabBio203" },
                    { 19, 2, 200, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7787), "Proiector, Sistem audio", "Parter", true, "AmfBio1" },
                    { 20, 2, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7788), "Proiector", "Parter", true, "AmfBio2" },
                    { 21, 3, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7790), null, "Etaj 1", true, "Ch101" },
                    { 22, 3, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7791), null, "Etaj 1", true, "Ch102" },
                    { 23, 3, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7793), null, "Etaj 1", true, "Ch103" },
                    { 24, 3, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7794), null, "Etaj 1", true, "Ch104" },
                    { 25, 3, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7796), null, "Etaj 1", true, "Ch105" },
                    { 26, 3, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7797), "Echipament chimie", "Etaj 2", true, "LabCh201" },
                    { 27, 3, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7799), "Echipament chimie", "Etaj 2", true, "LabCh202" },
                    { 28, 3, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7801), "Echipament chimie", "Etaj 2", true, "LabCh203" },
                    { 29, 3, 180, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7802), "Proiector, Sistem audio", "Parter", true, "AmfCh1" },
                    { 30, 3, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7804), "Proiector", "Parter", true, "AmfCh2" },
                    { 31, 4, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7805), null, "Etaj 1", true, "D101" },
                    { 32, 4, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7807), null, "Etaj 1", true, "D102" },
                    { 33, 4, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7808), null, "Etaj 1", true, "D103" },
                    { 34, 4, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7817), null, "Etaj 1", true, "D104" },
                    { 35, 4, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7819), null, "Etaj 1", true, "D105" },
                    { 36, 4, 300, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7829), "Sistem audio-video complet", "Parter", true, "AmfD1" },
                    { 37, 4, 250, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7831), "Proiector, Sistem audio", "Parter", true, "AmfD2" },
                    { 38, 4, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7832), null, "Etaj 2", true, "SemD201" },
                    { 39, 4, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7834), null, "Etaj 2", true, "SemD202" },
                    { 40, 4, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7835), null, "Etaj 2", true, "SemD203" },
                    { 41, 5, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7836), null, "Etaj 1", true, "Filo101" },
                    { 42, 5, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7838), null, "Etaj 1", true, "Filo102" },
                    { 43, 5, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7839), null, "Etaj 1", true, "Filo103" },
                    { 44, 5, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7841), null, "Etaj 1", true, "Filo104" },
                    { 45, 5, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7842), null, "Etaj 1", true, "Filo105" },
                    { 46, 5, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7844), "Proiector, Sistem audio", "Parter", true, "AmfFilo1" },
                    { 47, 5, 120, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7845), "Proiector", "Parter", true, "AmfFilo2" },
                    { 48, 5, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7854), null, "Etaj 2", true, "SemFilo201" },
                    { 49, 5, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7856), null, "Etaj 2", true, "SemFilo202" },
                    { 50, 5, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7857), null, "Etaj 2", true, "SemFilo203" },
                    { 51, 6, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7859), null, "Etaj 1", true, "Fiz101" },
                    { 52, 6, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7860), null, "Etaj 1", true, "Fiz102" },
                    { 53, 6, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7861), null, "Etaj 1", true, "Fiz103" },
                    { 54, 6, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7863), null, "Etaj 1", true, "Fiz104" },
                    { 55, 6, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7864), null, "Etaj 1", true, "Fiz105" },
                    { 56, 6, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7866), "Echipament fizică", "Etaj 2", true, "LabFiz201" },
                    { 57, 6, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7867), "Echipament fizică", "Etaj 2", true, "LabFiz202" },
                    { 58, 6, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7869), "Echipament fizică", "Etaj 2", true, "LabFiz203" },
                    { 59, 6, 200, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7871), "Proiector, Sistem audio", "Parter", true, "AmfFiz1" },
                    { 60, 6, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7872), "Proiector", "Parter", true, "AmfFiz2" },
                    { 61, 7, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7874), null, "Etaj 1", true, "Geo101" },
                    { 62, 7, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7875), null, "Etaj 1", true, "Geo102" },
                    { 63, 7, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7884), null, "Etaj 1", true, "Geo103" },
                    { 64, 7, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7885), null, "Etaj 1", true, "Geo104" },
                    { 65, 7, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7887), null, "Etaj 1", true, "Geo105" },
                    { 66, 7, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7888), "Hărți, Computere GIS", "Etaj 2", true, "LabGeo201" },
                    { 67, 7, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7890), "Computere GIS", "Etaj 2", true, "LabGeo202" },
                    { 68, 7, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7891), null, "Etaj 2", true, "SemGeo203" },
                    { 69, 7, 180, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7893), "Proiector, Sistem audio", "Parter", true, "AmfGeo1" },
                    { 70, 7, 120, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7894), "Proiector", "Parter", true, "AmfGeo2" },
                    { 71, 8, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7896), null, "Etaj 1", true, "GG101" },
                    { 72, 8, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7898), null, "Etaj 1", true, "GG102" },
                    { 73, 8, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7899), null, "Etaj 1", true, "GG103" },
                    { 74, 8, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7900), null, "Etaj 1", true, "GG104" },
                    { 75, 8, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7902), null, "Etaj 1", true, "GG105" },
                    { 76, 8, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7903), "Echipament geologic", "Etaj 2", true, "LabGG201" },
                    { 77, 8, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7912), "Echipament geofizic", "Etaj 2", true, "LabGG202" },
                    { 78, 8, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7914), null, "Etaj 2", true, "SemGG203" },
                    { 79, 8, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7915), "Proiector, Sistem audio", "Parter", true, "AmfGG1" },
                    { 80, 8, 120, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7917), "Proiector", "Parter", true, "AmfGG2" },
                    { 81, 9, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7918), null, "Etaj 1", true, "Ist101" },
                    { 82, 9, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7920), null, "Etaj 1", true, "Ist102" },
                    { 83, 9, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7921), null, "Etaj 1", true, "Ist103" },
                    { 84, 9, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7923), null, "Etaj 1", true, "Ist104" },
                    { 85, 9, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7924), null, "Etaj 1", true, "Ist105" },
                    { 86, 9, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7926), null, "Etaj 2", true, "SemIst201" },
                    { 87, 9, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7927), null, "Etaj 2", true, "SemIst202" },
                    { 88, 9, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7929), null, "Etaj 2", true, "SemIst203" },
                    { 89, 9, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7930), "Proiector, Sistem audio", "Parter", true, "AmfIst1" },
                    { 90, 9, 120, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7932), "Proiector", "Parter", true, "AmfIst2" },
                    { 91, 10, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7942), null, "Etaj 6", true, "J101" },
                    { 92, 10, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7944), null, "Etaj 6", true, "J102" },
                    { 93, 10, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7945), null, "Etaj 6", true, "J103" },
                    { 94, 10, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7947), null, "Etaj 6", true, "J104" },
                    { 95, 10, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7948), null, "Etaj 6", true, "J105" },
                    { 96, 10, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7950), "Camere, Echipament video", "Etaj 7", true, "LabMedia201" },
                    { 97, 10, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7951), "Echipament audio", "Etaj 7", true, "LabMedia202" },
                    { 98, 10, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7953), null, "Etaj 7", true, "SemPR203" },
                    { 99, 10, 100, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7954), "Proiector, Sistem audio", "Etaj 6", true, "AmfJ1" },
                    { 100, 10, 20, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7956), "Studio TV/Radio", "Etaj 7", true, "StudioJ2" },
                    { 101, 11, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7957), null, "Etaj 1", true, "LLS101" },
                    { 102, 11, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7959), null, "Etaj 1", true, "LLS102" },
                    { 103, 11, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7960), null, "Etaj 1", true, "LLS103" },
                    { 104, 11, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7966), null, "Etaj 1", true, "LLS104" },
                    { 105, 11, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7968), null, "Etaj 1", true, "LLS105" },
                    { 106, 11, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7977), "Echipament limbi străine", "Etaj 2", true, "LabLingv201" },
                    { 107, 11, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7979), "Computere, Software lingvistic", "Etaj 2", true, "LabLingv202" },
                    { 108, 11, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7980), null, "Etaj 2", true, "SemLLS203" },
                    { 109, 11, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7982), "Proiector, Sistem audio", "Parter", true, "AmfLLS1" },
                    { 110, 11, 120, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7983), "Proiector", "Parter", true, "AmfLLS2" },
                    { 111, 12, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7985), null, "Etaj 1", true, "Lit101" },
                    { 112, 12, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7986), null, "Etaj 1", true, "Lit102" },
                    { 113, 12, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7988), null, "Etaj 1", true, "Lit103" },
                    { 114, 12, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7989), null, "Etaj 1", true, "Lit104" },
                    { 115, 12, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7991), null, "Etaj 1", true, "Lit105" },
                    { 116, 12, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7992), null, "Etaj 2", true, "SemLit201" },
                    { 117, 12, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7993), null, "Etaj 2", true, "SemLit202" },
                    { 118, 12, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7995), null, "Etaj 2", true, "SemLit203" },
                    { 119, 12, 200, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(7996), "Proiector, Sistem audio", "Parter", true, "AmfLit1" },
                    { 120, 12, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8006), "Proiector", "Parter", true, "AmfLit2" },
                    { 121, 13, 300, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8007), "Proiector, Sistem audio premium", "Parter", true, "Amf. Spiru Haret" },
                    { 122, 13, 250, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8009), "Proiector, Sistem audio", "Parter", true, "Amf. Gheorghe Țițeica" },
                    { 123, 13, 200, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8011), "Proiector, Sistem audio", "Parter", true, "Amf. Simion Stoilow" },
                    { 124, 13, 180, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8012), "Proiector, Sistem audio", "Parter", true, "Amf. Dimitrie Pompeiu" },
                    { 125, 13, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8014), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 1" },
                    { 126, 13, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8015), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 2" },
                    { 127, 13, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8017), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 3" },
                    { 128, 13, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8018), null, "Etaj 1", true, "S101" },
                    { 129, 13, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8020), null, "Etaj 1", true, "S102" },
                    { 130, 13, 50, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8021), null, "Etaj 1", true, "S103" },
                    { 131, 14, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8022), null, "Etaj 1", true, "Psi101" },
                    { 132, 14, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8024), null, "Etaj 1", true, "Psi102" },
                    { 133, 14, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8025), null, "Etaj 1", true, "Psi103" },
                    { 134, 14, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8034), null, "Etaj 1", true, "Psi104" },
                    { 135, 14, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8037), null, "Etaj 1", true, "Psi105" },
                    { 136, 14, 20, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8038), "Echipament psihologie", "Etaj 2", true, "LabPsi201" },
                    { 137, 14, 20, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8040), "Computere, Software psiho", "Etaj 2", true, "LabPsi202" },
                    { 138, 14, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8041), null, "Etaj 2", true, "SemEdu203" },
                    { 139, 14, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8043), "Proiector, Sistem audio", "Parter", true, "AmfPsi1" },
                    { 140, 14, 120, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8044), "Proiector", "Parter", true, "AmfPsi2" },
                    { 141, 15, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8046), null, "Etaj 1", true, "SAS101" },
                    { 142, 15, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8047), null, "Etaj 1", true, "SAS102" },
                    { 143, 15, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8049), null, "Etaj 1", true, "SAS103" },
                    { 144, 15, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8050), null, "Etaj 1", true, "SAS104" },
                    { 145, 15, 40, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8052), null, "Etaj 1", true, "SAS105" },
                    { 146, 15, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8053), null, "Etaj 2", true, "SemSAS201" },
                    { 147, 15, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8055), null, "Etaj 2", true, "SemSAS202" },
                    { 148, 15, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8056), null, "Etaj 2", true, "SemSAS203" },
                    { 149, 15, 150, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8065), "Proiector, Sistem audio", "Parter", true, "AmfSAS1" },
                    { 150, 15, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8067), "Computere, Software SPSS", "Etaj 2", true, "LabSAS2" },
                    { 151, 16, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8068), null, "Etaj 1", true, "FSP101" },
                    { 152, 16, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8069), null, "Etaj 1", true, "FSP102" },
                    { 153, 16, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8071), null, "Etaj 1", true, "FSP103" },
                    { 154, 16, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8072), null, "Etaj 1", true, "FSP104" },
                    { 155, 16, 45, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8074), null, "Etaj 1", true, "FSP105" },
                    { 156, 16, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8075), null, "Etaj 2", true, "SemFSP201" },
                    { 157, 16, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8077), null, "Etaj 2", true, "SemFSP202" },
                    { 158, 16, 30, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8078), null, "Etaj 2", true, "SemFSP203" },
                    { 159, 16, 180, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8080), "Proiector, Sistem audio", "Parter", true, "AmfFSP1" },
                    { 160, 16, 25, new DateTime(2026, 1, 3, 13, 18, 59, 951, DateTimeKind.Utc).AddTicks(8081), "Computere", "Etaj 2", true, "LabFSP2" }
========
                    { 1, 1, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(7895), null, "Etaj 1", true, "A101" },
                    { 2, 1, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8115), null, "Etaj 1", true, "A102" },
                    { 3, 1, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8119), null, "Etaj 1", true, "A103" },
                    { 4, 1, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8121), null, "Etaj 1", true, "A104" },
                    { 5, 1, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8123), null, "Etaj 1", true, "A105" },
                    { 6, 1, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8125), null, "Etaj 2", true, "S201" },
                    { 7, 1, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8127), null, "Etaj 2", true, "S202" },
                    { 8, 1, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8129), null, "Etaj 2", true, "S203" },
                    { 9, 1, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8328), "Computere", "Etaj 3", true, "Lab301" },
                    { 10, 1, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8331), "Computere", "Etaj 3", true, "Lab302" },
                    { 11, 2, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8357), null, "Etaj 1", true, "Bio101" },
                    { 12, 2, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8360), null, "Etaj 1", true, "Bio102" },
                    { 13, 2, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8362), null, "Etaj 1", true, "Bio103" },
                    { 14, 2, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8364), null, "Etaj 1", true, "Bio104" },
                    { 15, 2, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8366), null, "Etaj 1", true, "Bio105" },
                    { 16, 2, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8368), "Echipament laborator", "Etaj 2", true, "LabBio201" },
                    { 17, 2, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8371), "Echipament laborator", "Etaj 2", true, "LabBio202" },
                    { 18, 2, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8373), "Echipament laborator", "Etaj 2", true, "LabBio203" },
                    { 19, 2, 200, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8375), "Proiector, Sistem audio", "Parter", true, "AmfBio1" },
                    { 20, 2, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8378), "Proiector", "Parter", true, "AmfBio2" },
                    { 21, 3, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8380), null, "Etaj 1", true, "Ch101" },
                    { 22, 3, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8410), null, "Etaj 1", true, "Ch102" },
                    { 23, 3, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8412), null, "Etaj 1", true, "Ch103" },
                    { 24, 3, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8414), null, "Etaj 1", true, "Ch104" },
                    { 25, 3, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8417), null, "Etaj 1", true, "Ch105" },
                    { 26, 3, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8433), "Echipament chimie", "Etaj 2", true, "LabCh201" },
                    { 27, 3, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8435), "Echipament chimie", "Etaj 2", true, "LabCh202" },
                    { 28, 3, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8438), "Echipament chimie", "Etaj 2", true, "LabCh203" },
                    { 29, 3, 180, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8440), "Proiector, Sistem audio", "Parter", true, "AmfCh1" },
                    { 30, 3, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8442), "Proiector", "Parter", true, "AmfCh2" },
                    { 31, 4, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8444), null, "Etaj 1", true, "D101" },
                    { 32, 4, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8446), null, "Etaj 1", true, "D102" },
                    { 33, 4, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8448), null, "Etaj 1", true, "D103" },
                    { 34, 4, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8450), null, "Etaj 1", true, "D104" },
                    { 35, 4, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8453), null, "Etaj 1", true, "D105" },
                    { 36, 4, 300, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8455), "Sistem audio-video complet", "Parter", true, "AmfD1" },
                    { 37, 4, 250, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8457), "Proiector, Sistem audio", "Parter", true, "AmfD2" },
                    { 38, 4, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8459), null, "Etaj 2", true, "SemD201" },
                    { 39, 4, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8461), null, "Etaj 2", true, "SemD202" },
                    { 40, 4, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8476), null, "Etaj 2", true, "SemD203" },
                    { 41, 5, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8479), null, "Etaj 1", true, "Filo101" },
                    { 42, 5, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8481), null, "Etaj 1", true, "Filo102" },
                    { 43, 5, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8483), null, "Etaj 1", true, "Filo103" },
                    { 44, 5, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8485), null, "Etaj 1", true, "Filo104" },
                    { 45, 5, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8487), null, "Etaj 1", true, "Filo105" },
                    { 46, 5, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8490), "Proiector, Sistem audio", "Parter", true, "AmfFilo1" },
                    { 47, 5, 120, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8492), "Proiector", "Parter", true, "AmfFilo2" },
                    { 48, 5, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8494), null, "Etaj 2", true, "SemFilo201" },
                    { 49, 5, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8496), null, "Etaj 2", true, "SemFilo202" },
                    { 50, 5, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8498), null, "Etaj 2", true, "SemFilo203" },
                    { 51, 6, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8500), null, "Etaj 1", true, "Fiz101" },
                    { 52, 6, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8502), null, "Etaj 1", true, "Fiz102" },
                    { 53, 6, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8504), null, "Etaj 1", true, "Fiz103" },
                    { 54, 6, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8507), null, "Etaj 1", true, "Fiz104" },
                    { 55, 6, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8521), null, "Etaj 1", true, "Fiz105" },
                    { 56, 6, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8524), "Echipament fizică", "Etaj 2", true, "LabFiz201" },
                    { 57, 6, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8526), "Echipament fizică", "Etaj 2", true, "LabFiz202" },
                    { 58, 6, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8528), "Echipament fizică", "Etaj 2", true, "LabFiz203" },
                    { 59, 6, 200, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8530), "Proiector, Sistem audio", "Parter", true, "AmfFiz1" },
                    { 60, 6, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8533), "Proiector", "Parter", true, "AmfFiz2" },
                    { 61, 7, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8535), null, "Etaj 1", true, "Geo101" },
                    { 62, 7, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8537), null, "Etaj 1", true, "Geo102" },
                    { 63, 7, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8539), null, "Etaj 1", true, "Geo103" },
                    { 64, 7, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8541), null, "Etaj 1", true, "Geo104" },
                    { 65, 7, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8543), null, "Etaj 1", true, "Geo105" },
                    { 66, 7, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8545), "Hărți, Computere GIS", "Etaj 2", true, "LabGeo201" },
                    { 67, 7, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8548), "Computere GIS", "Etaj 2", true, "LabGeo202" },
                    { 68, 7, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8550), null, "Etaj 2", true, "SemGeo203" },
                    { 69, 7, 180, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8563), "Proiector, Sistem audio", "Parter", true, "AmfGeo1" },
                    { 70, 7, 120, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8566), "Proiector", "Parter", true, "AmfGeo2" },
                    { 71, 8, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8568), null, "Etaj 1", true, "GG101" },
                    { 72, 8, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8570), null, "Etaj 1", true, "GG102" },
                    { 73, 8, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8572), null, "Etaj 1", true, "GG103" },
                    { 74, 8, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8574), null, "Etaj 1", true, "GG104" },
                    { 75, 8, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8576), null, "Etaj 1", true, "GG105" },
                    { 76, 8, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8578), "Echipament geologic", "Etaj 2", true, "LabGG201" },
                    { 77, 8, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8580), "Echipament geofizic", "Etaj 2", true, "LabGG202" },
                    { 78, 8, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8582), null, "Etaj 2", true, "SemGG203" },
                    { 79, 8, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8585), "Proiector, Sistem audio", "Parter", true, "AmfGG1" },
                    { 80, 8, 120, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8586), "Proiector", "Parter", true, "AmfGG2" },
                    { 81, 9, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8588), null, "Etaj 1", true, "Ist101" },
                    { 82, 9, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8591), null, "Etaj 1", true, "Ist102" },
                    { 83, 9, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8605), null, "Etaj 1", true, "Ist103" },
                    { 84, 9, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8607), null, "Etaj 1", true, "Ist104" },
                    { 85, 9, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8609), null, "Etaj 1", true, "Ist105" },
                    { 86, 9, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8611), null, "Etaj 2", true, "SemIst201" },
                    { 87, 9, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8614), null, "Etaj 2", true, "SemIst202" },
                    { 88, 9, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8616), null, "Etaj 2", true, "SemIst203" },
                    { 89, 9, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8618), "Proiector, Sistem audio", "Parter", true, "AmfIst1" },
                    { 90, 9, 120, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8634), "Proiector", "Parter", true, "AmfIst2" },
                    { 91, 10, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8637), null, "Etaj 6", true, "J101" },
                    { 92, 10, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8639), null, "Etaj 6", true, "J102" },
                    { 93, 10, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8641), null, "Etaj 6", true, "J103" },
                    { 94, 10, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8644), null, "Etaj 6", true, "J104" },
                    { 95, 10, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8646), null, "Etaj 6", true, "J105" },
                    { 96, 10, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8648), "Camere, Echipament video", "Etaj 7", true, "LabMedia201" },
                    { 97, 10, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8650), "Echipament audio", "Etaj 7", true, "LabMedia202" },
                    { 98, 10, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8665), null, "Etaj 7", true, "SemPR203" },
                    { 99, 10, 100, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8667), "Proiector, Sistem audio", "Etaj 6", true, "AmfJ1" },
                    { 100, 10, 20, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8669), "Studio TV/Radio", "Etaj 7", true, "StudioJ2" },
                    { 101, 11, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8671), null, "Etaj 1", true, "LLS101" },
                    { 102, 11, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8673), null, "Etaj 1", true, "LLS102" },
                    { 103, 11, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8675), null, "Etaj 1", true, "LLS103" },
                    { 104, 11, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8677), null, "Etaj 1", true, "LLS104" },
                    { 105, 11, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8679), null, "Etaj 1", true, "LLS105" },
                    { 106, 11, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8682), "Echipament limbi străine", "Etaj 2", true, "LabLingv201" },
                    { 107, 11, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8684), "Computere, Software lingvistic", "Etaj 2", true, "LabLingv202" },
                    { 108, 11, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8686), null, "Etaj 2", true, "SemLLS203" },
                    { 109, 11, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8688), "Proiector, Sistem audio", "Parter", true, "AmfLLS1" },
                    { 110, 11, 120, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8691), "Proiector", "Parter", true, "AmfLLS2" },
                    { 111, 12, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8693), null, "Etaj 1", true, "Lit101" },
                    { 112, 12, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8706), null, "Etaj 1", true, "Lit102" },
                    { 113, 12, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8708), null, "Etaj 1", true, "Lit103" },
                    { 114, 12, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8711), null, "Etaj 1", true, "Lit104" },
                    { 115, 12, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8713), null, "Etaj 1", true, "Lit105" },
                    { 116, 12, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8715), null, "Etaj 2", true, "SemLit201" },
                    { 117, 12, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8717), null, "Etaj 2", true, "SemLit202" },
                    { 118, 12, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8719), null, "Etaj 2", true, "SemLit203" },
                    { 119, 12, 200, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8721), "Proiector, Sistem audio", "Parter", true, "AmfLit1" },
                    { 120, 12, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8723), "Proiector", "Parter", true, "AmfLit2" },
                    { 121, 13, 300, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8725), "Proiector, Sistem audio premium", "Parter", true, "Amf. Spiru Haret" },
                    { 122, 13, 250, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8728), "Proiector, Sistem audio", "Parter", true, "Amf. Gheorghe Țițeica" },
                    { 123, 13, 200, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8730), "Proiector, Sistem audio", "Parter", true, "Amf. Simion Stoilow" },
                    { 124, 13, 180, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8732), "Proiector, Sistem audio", "Parter", true, "Amf. Dimitrie Pompeiu" },
                    { 125, 13, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8734), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 1" },
                    { 126, 13, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8748), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 2" },
                    { 127, 13, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8750), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 3" },
                    { 128, 13, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8752), null, "Etaj 1", true, "S101" },
                    { 129, 13, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8755), null, "Etaj 1", true, "S102" },
                    { 130, 13, 50, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8757), null, "Etaj 1", true, "S103" },
                    { 131, 14, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8759), null, "Etaj 1", true, "Psi101" },
                    { 132, 14, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8761), null, "Etaj 1", true, "Psi102" },
                    { 133, 14, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8763), null, "Etaj 1", true, "Psi103" },
                    { 134, 14, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8764), null, "Etaj 1", true, "Psi104" },
                    { 135, 14, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8766), null, "Etaj 1", true, "Psi105" },
                    { 136, 14, 20, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8769), "Echipament psihologie", "Etaj 2", true, "LabPsi201" },
                    { 137, 14, 20, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8770), "Computere, Software psiho", "Etaj 2", true, "LabPsi202" },
                    { 138, 14, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8773), null, "Etaj 2", true, "SemEdu203" },
                    { 139, 14, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8775), "Proiector, Sistem audio", "Parter", true, "AmfPsi1" },
                    { 140, 14, 120, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8777), "Proiector", "Parter", true, "AmfPsi2" },
                    { 141, 15, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8791), null, "Etaj 1", true, "SAS101" },
                    { 142, 15, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8793), null, "Etaj 1", true, "SAS102" },
                    { 143, 15, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8795), null, "Etaj 1", true, "SAS103" },
                    { 144, 15, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8797), null, "Etaj 1", true, "SAS104" },
                    { 145, 15, 40, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8799), null, "Etaj 1", true, "SAS105" },
                    { 146, 15, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8801), null, "Etaj 2", true, "SemSAS201" },
                    { 147, 15, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8803), null, "Etaj 2", true, "SemSAS202" },
                    { 148, 15, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8805), null, "Etaj 2", true, "SemSAS203" },
                    { 149, 15, 150, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8808), "Proiector, Sistem audio", "Parter", true, "AmfSAS1" },
                    { 150, 15, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8810), "Computere, Software SPSS", "Etaj 2", true, "LabSAS2" },
                    { 151, 16, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8812), null, "Etaj 1", true, "FSP101" },
                    { 152, 16, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8814), null, "Etaj 1", true, "FSP102" },
                    { 153, 16, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8816), null, "Etaj 1", true, "FSP103" },
                    { 154, 16, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8817), null, "Etaj 1", true, "FSP104" },
                    { 155, 16, 45, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8831), null, "Etaj 1", true, "FSP105" },
                    { 156, 16, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8833), null, "Etaj 2", true, "SemFSP201" },
                    { 157, 16, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8835), null, "Etaj 2", true, "SemFSP202" },
                    { 158, 16, 30, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8838), null, "Etaj 2", true, "SemFSP203" },
                    { 159, 16, 180, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8849), "Proiector, Sistem audio", "Parter", true, "AmfFSP1" },
                    { 160, 16, 25, new DateTime(2026, 1, 17, 10, 41, 20, 695, DateTimeKind.Utc).AddTicks(8851), "Computere", "Etaj 2", true, "LabFSP2" }
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117104121_InitialCreate.cs
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
<<<<<<<< HEAD:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260103131900_InitialCreate.cs
                    { 1, new DateTime(2026, 1, 3, 13, 18, 59, 953, DateTimeKind.Utc).AddTicks(3405), 14, "Principii de inginerie software și design patterns", new DateTime(2026, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 121, new DateTime(2026, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), "Curs Inginerie Software" },
                    { 2, new DateTime(2026, 1, 3, 13, 18, 59, 953, DateTimeKind.Utc).AddTicks(3480), 15, "Lucru cu SQL și modelare baze de date", new DateTime(2026, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 125, new DateTime(2026, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), "Seminar Baze de Date" },
                    { 3, new DateTime(2026, 1, 3, 13, 18, 59, 953, DateTimeKind.Utc).AddTicks(3483), 14, "Algoritmi de sortare și căutare", new DateTime(2026, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 122, new DateTime(2026, 1, 3, 8, 0, 0, 0, DateTimeKind.Local), "Curs Algoritmi și Structuri de Date" },
                    { 4, new DateTime(2026, 1, 3, 13, 18, 59, 953, DateTimeKind.Utc).AddTicks(3485), 15, "Dreptul persoanelor și al familiei", new DateTime(2026, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 36, new DateTime(2026, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), "Curs Drept Civil" }
========
                    { 1, new DateTime(2026, 1, 17, 10, 41, 20, 698, DateTimeKind.Utc).AddTicks(9103), 14, "Principii de inginerie software și design patterns", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 121, new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Local), "Curs Inginerie Software" },
                    { 2, new DateTime(2026, 1, 17, 10, 41, 20, 698, DateTimeKind.Utc).AddTicks(9234), 15, "Lucru cu SQL și modelare baze de date", new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 125, new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Local), "Seminar Baze de Date" },
                    { 3, new DateTime(2026, 1, 17, 10, 41, 20, 698, DateTimeKind.Utc).AddTicks(9237), 14, "Algoritmi de sortare și căutare", new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 122, new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Local), "Curs Algoritmi și Structuri de Date" },
                    { 4, new DateTime(2026, 1, 17, 10, 41, 20, 698, DateTimeKind.Utc).AddTicks(9273), 15, "Dreptul persoanelor și al familiei", new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 36, new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Local), "Curs Drept Civil" }
>>>>>>>> 189e48852bf492e3103a5421faf884034644cedc:src/CampusConnect/CampusConnect.Infrastructure/Migrations/20260117104121_InitialCreate.cs
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
