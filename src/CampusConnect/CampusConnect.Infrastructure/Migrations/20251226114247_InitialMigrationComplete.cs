using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationComplete : Migration
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
                    { 1, new DateTime(2025, 12, 26, 11, 42, 46, 275, DateTimeKind.Utc).AddTicks(2340), "Complete your first task", "🎯", true, "First Steps" },
                    { 2, new DateTime(2025, 12, 26, 11, 42, 46, 275, DateTimeKind.Utc).AddTicks(3347), "Complete 5 tasks", "⭐", true, "Task Master" },
                    { 3, new DateTime(2025, 12, 26, 11, 42, 46, 275, DateTimeKind.Utc).AddTicks(3351), "Complete 10 tasks", "🏆", true, "Task Legend" },
                    { 4, new DateTime(2025, 12, 26, 11, 42, 46, 275, DateTimeKind.Utc).AddTicks(3353), "Join your first group", "👥", true, "Team Player" },
                    { 5, new DateTime(2025, 12, 26, 11, 42, 46, 275, DateTimeKind.Utc).AddTicks(3356), "Attend your first event", "🦋", true, "Social Butterfly" }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "GeoJsonPolygon", "IsActive", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { 1, "B-dul Regina Elisabeta nr. 4-12, etaj 1, sector 3, București", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7260), "FAA - Sediu în clădirea Chimiei", null, true, 44.434719999999999, 26.100719999999999, "Facultatea de Administrație și Afaceri" },
                    { 2, "Splaiul Independenței nr. 91-95, sector 5, București, 050095", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7734), "Facultatea de Biologie", null, true, 44.435299999999998, 26.06326, "Facultatea de Biologie" },
                    { 3, "Bd. Regina Elisabeta nr. 4-12, sector 3, București, 030018", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7738), "Facultatea de Chimie", null, true, 44.434719999999999, 26.100719999999999, "Facultatea de Chimie" },
                    { 4, "Bd. Mihail Kogălniceanu nr. 36-46, sector 5, București, 050107", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7741), "Facultatea de Drept", null, true, 44.435240999999998, 26.082077000000002, "Facultatea de Drept" },
                    { 5, "Splaiul Independenței nr. 204, sector 6, București, 060024", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7744), "Facultatea de Filosofie", null, true, 44.434710000000003, 26.04824, "Facultatea de Filosofie" },
                    { 6, "Str. Atomiștilor nr. 405, Măgurele, Ilfov, 077125", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7746), "Facultatea de Fizică - Campus Măgurele", null, true, 44.34834, 26.031279999999999, "Facultatea de Fizică" },
                    { 7, "Bd. Nicolae Bălcescu nr. 1, sector 1, București, 010041", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7749), "Facultatea de Geografie", null, true, 44.436540000000001, 26.101890000000001, "Facultatea de Geografie" },
                    { 8, "Str. Traian Vuia nr. 6, sector 2, București, 020956", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7751), "Facultatea de Geologie și Geofizică", null, true, 44.45167, 26.07901, "Facultatea de Geologie și Geofizică" },
                    { 9, "Str. Academiei nr. 14, București", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7754), "Facultatea de Istorie", null, true, 44.435839999999999, 26.096830000000001, "Facultatea de Istorie" },
                    { 10, "Bd. Iuliu Maniu nr. 1-3, Complex Leu, Corp A, etaj 6, sector 6, București", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7758), "FJSC - Complex Leu", null, true, 44.43891, 26.043209999999998, "Facultatea de Jurnalism și Științele Comunicării" },
                    { 11, "Str. Edgar Quinet nr. 5-7, sector 1, București, 010017", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7761), "FLLS", null, true, 44.435830000000003, 26.100809999999999, "Facultatea de Limbi și Literaturi Străine" },
                    { 12, "Str. Edgar Quinet nr. 5-7, sector 1, București, 010017", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7777), "Facultatea de Litere", null, true, 44.435830000000003, 26.100809999999999, "Facultatea de Litere" },
                    { 13, "Str. Academiei nr. 14, sector 1, București, 010014", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7779), "FMI", null, true, 44.435839999999999, 26.096830000000001, "Facultatea de Matematică și Informatică" },
                    { 14, "Șos. Panduri nr. 90-91, București", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7851), "FPSE", null, true, 44.432209999999998, 26.068919999999999, "Facultatea de Psihologie și Științele Educației" },
                    { 15, "Bd. Schitu Măgureanu nr. 9, București", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7856), "SAS", null, true, 44.433419999999998, 26.09421, "Facultatea de Sociologie și Asistență Socială" },
                    { 16, "Calea Plevnei nr. 59, București, 010223", new DateTime(2025, 12, 26, 11, 42, 46, 257, DateTimeKind.Utc).AddTicks(7858), "FSP", null, true, 44.445210000000003, 26.083919999999999, "Facultatea de Științe Politice" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "b891f806-034a-406d-b6e2-6378892d6ef0", "Admin", "ADMIN" },
                    { 2, "f14ad3bf-c7c5-4ac9-8acf-e2188b787b30", "User", "USER" },
                    { 3, "13b14d11-aec1-4f94-8e16-aa38dee9570a", "Professor", "PROFESSOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastLoginAt", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "StudentId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 10, 0, "2ebda6f2-cb17-44c2-b3b6-7c170e66b2a1", new DateTime(2025, 12, 26, 11, 42, 45, 521, DateTimeKind.Utc).AddTicks(3208), null, "admin1@unibuc.ro", true, "Andrei", null, "Popescu", false, null, "ADMIN1@UNIBUC.RO", "ADMIN1@UNIBUC.RO", "AQAAAAIAAYagAAAAELRGVcdyMYzzE7Vy+sawUTDCRcZzYPL4UxrU1LPRoYn0O/5j5nQ2UelOQtNU59yhwg==", null, false, null, "3c3b2990-6f80-42d0-8050-0cb490260585", null, false, "admin1@unibuc.ro" },
                    { 11, 0, "869a3aed-3ca0-4a13-aeab-068299293049", new DateTime(2025, 12, 26, 11, 42, 45, 634, DateTimeKind.Utc).AddTicks(60), null, "admin2@unibuc.ro", true, "Maria", null, "Ionescu", false, null, "ADMIN2@UNIBUC.RO", "ADMIN2@UNIBUC.RO", "AQAAAAIAAYagAAAAEBuyr3Ls2h9iiwi8LHUfAtTFYAWvBWdT7Zw+Qh35m5LMMQFp392iDS8jW2YXSHEvpw==", null, false, null, "67e3d467-715b-4a36-b59c-6f3805dc6f90", null, false, "admin2@unibuc.ro" },
                    { 12, 0, "3427a7e4-93a8-451e-8d35-bfdc51349cbf", new DateTime(2025, 12, 26, 11, 42, 45, 753, DateTimeKind.Utc).AddTicks(1938), null, "student1@s.unibuc.ro", true, "Ion", null, "Vasilescu", false, null, "STUDENT1@S.UNIBUC.RO", "STUDENT1@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEGbz9Mez3Mfkm0Th/CZiR+t1lFFFgVPyzE1iC5G35fHEtKkCrmGVfNASZK5Ep+ypsw==", null, false, null, "ec42f9d1-d707-4e9e-a1c0-391663e81661", null, false, "student1@s.unibuc.ro" },
                    { 13, 0, "8c314594-26a2-4c94-be2d-778120f35b7f", new DateTime(2025, 12, 26, 11, 42, 45, 870, DateTimeKind.Utc).AddTicks(868), null, "student2@s.unibuc.ro", true, "Elena", null, "Georgescu", false, null, "STUDENT2@S.UNIBUC.RO", "STUDENT2@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEBAQ+Qn1JYKx9BtrLLDSRrEo2teilUPs0xWv4kFS/isHtRi0uvnkuDyEgyZUgz8H9g==", null, false, null, "da2e24ed-5da8-418e-a906-b22f897d8cad", null, false, "student2@s.unibuc.ro" },
                    { 14, 0, "b56685db-cd02-4edf-b77a-66e91f484877", new DateTime(2025, 12, 26, 11, 42, 45, 979, DateTimeKind.Utc).AddTicks(7826), null, "anastasia.ispas@s.unibuc.ro", true, "Anastasia", null, "Ispas", false, null, "ANASTASIA.ISPAS@S.UNIBUC.RO", "ANASTASIA.ISPAS@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEGBDLr934Np/UDRj/Axnjb7ZDBQcaucgHuXr7HzIaL+/457Q4GVhhIHX5TaGo1ZDoQ==", null, false, null, "afe917f3-1d0e-4581-ad3f-b834efad95a7", null, false, "anastasia.ispas@s.unibuc.ro" },
                    { 15, 0, "f1d42db5-d067-4941-a9da-cc1569c1bd19", new DateTime(2025, 12, 26, 11, 42, 46, 91, DateTimeKind.Utc).AddTicks(7126), null, "irina-maria.istrate@s.unibuc.ro", true, "Irina-Maria", null, "Istrate", false, null, "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "IRINA-MARIA.ISTRATE@S.UNIBUC.RO", "AQAAAAIAAYagAAAAEJk7ruoupOHxROkpy4jVniJ8uWS93aqqylZ+Chw6TY5xSxfPWlgXyADK5wsY1Elijw==", null, false, null, "dfe2da06-2483-4d08-afd4-4d8d6c4af291", null, false, "irina-maria.istrate@s.unibuc.ro" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BuildingId", "Capacity", "CreatedAt", "Equipment", "Floor", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, 40, new DateTime(2025, 12, 26, 11, 42, 46, 258, DateTimeKind.Utc).AddTicks(9798), null, "Etaj 1", true, "A101" },
                    { 2, 1, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(1081), null, "Etaj 1", true, "A102" },
                    { 3, 1, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(1092), null, "Etaj 1", true, "A103" },
                    { 4, 1, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(1101), null, "Etaj 1", true, "A104" },
                    { 5, 1, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(1108), null, "Etaj 1", true, "A105" },
                    { 6, 1, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(1116), null, "Etaj 2", true, "S201" },
                    { 7, 1, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(1124), null, "Etaj 2", true, "S202" },
                    { 8, 1, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(1131), null, "Etaj 2", true, "S203" },
                    { 9, 1, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2373), "Computere", "Etaj 3", true, "Lab301" },
                    { 10, 1, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2403), "Computere", "Etaj 3", true, "Lab302" },
                    { 11, 2, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2413), null, "Etaj 1", true, "Bio101" },
                    { 12, 2, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2421), null, "Etaj 1", true, "Bio102" },
                    { 13, 2, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2626), null, "Etaj 1", true, "Bio103" },
                    { 14, 2, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2634), null, "Etaj 1", true, "Bio104" },
                    { 15, 2, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2642), null, "Etaj 1", true, "Bio105" },
                    { 16, 2, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2650), "Echipament laborator", "Etaj 2", true, "LabBio201" },
                    { 17, 2, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2658), "Echipament laborator", "Etaj 2", true, "LabBio202" },
                    { 18, 2, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2666), "Echipament laborator", "Etaj 2", true, "LabBio203" },
                    { 19, 2, 200, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2675), "Proiector, Sistem audio", "Parter", true, "AmfBio1" },
                    { 20, 2, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2683), "Proiector", "Parter", true, "AmfBio2" },
                    { 21, 3, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2690), null, "Etaj 1", true, "Ch101" },
                    { 22, 3, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2698), null, "Etaj 1", true, "Ch102" },
                    { 23, 3, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2705), null, "Etaj 1", true, "Ch103" },
                    { 24, 3, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2713), null, "Etaj 1", true, "Ch104" },
                    { 25, 3, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2720), null, "Etaj 1", true, "Ch105" },
                    { 26, 3, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2728), "Echipament chimie", "Etaj 2", true, "LabCh201" },
                    { 27, 3, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2802), "Echipament chimie", "Etaj 2", true, "LabCh202" },
                    { 28, 3, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2811), "Echipament chimie", "Etaj 2", true, "LabCh203" },
                    { 29, 3, 180, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2819), "Proiector, Sistem audio", "Parter", true, "AmfCh1" },
                    { 30, 3, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2827), "Proiector", "Parter", true, "AmfCh2" },
                    { 31, 4, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2834), null, "Etaj 1", true, "D101" },
                    { 32, 4, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2842), null, "Etaj 1", true, "D102" },
                    { 33, 4, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2850), null, "Etaj 1", true, "D103" },
                    { 34, 4, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2858), null, "Etaj 1", true, "D104" },
                    { 35, 4, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2865), null, "Etaj 1", true, "D105" },
                    { 36, 4, 300, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2873), "Sistem audio-video complet", "Parter", true, "AmfD1" },
                    { 37, 4, 250, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2882), "Proiector, Sistem audio", "Parter", true, "AmfD2" },
                    { 38, 4, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2890), null, "Etaj 2", true, "SemD201" },
                    { 39, 4, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2897), null, "Etaj 2", true, "SemD202" },
                    { 40, 4, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2905), null, "Etaj 2", true, "SemD203" },
                    { 41, 5, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2967), null, "Etaj 1", true, "Filo101" },
                    { 42, 5, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2975), null, "Etaj 1", true, "Filo102" },
                    { 43, 5, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2982), null, "Etaj 1", true, "Filo103" },
                    { 44, 5, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2990), null, "Etaj 1", true, "Filo104" },
                    { 45, 5, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(2998), null, "Etaj 1", true, "Filo105" },
                    { 46, 5, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3006), "Proiector, Sistem audio", "Parter", true, "AmfFilo1" },
                    { 47, 5, 120, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3014), "Proiector", "Parter", true, "AmfFilo2" },
                    { 48, 5, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3022), null, "Etaj 2", true, "SemFilo201" },
                    { 49, 5, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3029), null, "Etaj 2", true, "SemFilo202" },
                    { 50, 5, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3037), null, "Etaj 2", true, "SemFilo203" },
                    { 51, 6, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3045), null, "Etaj 1", true, "Fiz101" },
                    { 52, 6, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3053), null, "Etaj 1", true, "Fiz102" },
                    { 53, 6, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3061), null, "Etaj 1", true, "Fiz103" },
                    { 54, 6, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3069), null, "Etaj 1", true, "Fiz104" },
                    { 55, 6, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3076), null, "Etaj 1", true, "Fiz105" },
                    { 56, 6, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3135), "Echipament fizică", "Etaj 2", true, "LabFiz201" },
                    { 57, 6, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3144), "Echipament fizică", "Etaj 2", true, "LabFiz202" },
                    { 58, 6, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3152), "Echipament fizică", "Etaj 2", true, "LabFiz203" },
                    { 59, 6, 200, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3160), "Proiector, Sistem audio", "Parter", true, "AmfFiz1" },
                    { 60, 6, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3169), "Proiector", "Parter", true, "AmfFiz2" },
                    { 61, 7, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3177), null, "Etaj 1", true, "Geo101" },
                    { 62, 7, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3185), null, "Etaj 1", true, "Geo102" },
                    { 63, 7, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3193), null, "Etaj 1", true, "Geo103" },
                    { 64, 7, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3201), null, "Etaj 1", true, "Geo104" },
                    { 65, 7, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3208), null, "Etaj 1", true, "Geo105" },
                    { 66, 7, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3216), "Hărți, Computere GIS", "Etaj 2", true, "LabGeo201" },
                    { 67, 7, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3224), "Computere GIS", "Etaj 2", true, "LabGeo202" },
                    { 68, 7, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3308), null, "Etaj 2", true, "SemGeo203" },
                    { 69, 7, 180, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3317), "Proiector, Sistem audio", "Parter", true, "AmfGeo1" },
                    { 70, 7, 120, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3382), "Proiector", "Parter", true, "AmfGeo2" },
                    { 71, 8, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3391), null, "Etaj 1", true, "GG101" },
                    { 72, 8, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3399), null, "Etaj 1", true, "GG102" },
                    { 73, 8, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3407), null, "Etaj 1", true, "GG103" },
                    { 74, 8, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3414), null, "Etaj 1", true, "GG104" },
                    { 75, 8, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3422), null, "Etaj 1", true, "GG105" },
                    { 76, 8, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3430), "Echipament geologic", "Etaj 2", true, "LabGG201" },
                    { 77, 8, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3438), "Echipament geofizic", "Etaj 2", true, "LabGG202" },
                    { 78, 8, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3447), null, "Etaj 2", true, "SemGG203" },
                    { 79, 8, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3455), "Proiector, Sistem audio", "Parter", true, "AmfGG1" },
                    { 80, 8, 120, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3463), "Proiector", "Parter", true, "AmfGG2" },
                    { 81, 9, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3471), null, "Etaj 1", true, "Ist101" },
                    { 82, 9, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3479), null, "Etaj 1", true, "Ist102" },
                    { 83, 9, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3487), null, "Etaj 1", true, "Ist103" },
                    { 84, 9, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3494), null, "Etaj 1", true, "Ist104" },
                    { 85, 9, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3552), null, "Etaj 1", true, "Ist105" },
                    { 86, 9, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3560), null, "Etaj 2", true, "SemIst201" },
                    { 87, 9, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3568), null, "Etaj 2", true, "SemIst202" },
                    { 88, 9, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3576), null, "Etaj 2", true, "SemIst203" },
                    { 89, 9, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3584), "Proiector, Sistem audio", "Parter", true, "AmfIst1" },
                    { 90, 9, 120, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3592), "Proiector", "Parter", true, "AmfIst2" },
                    { 91, 10, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3600), null, "Etaj 6", true, "J101" },
                    { 92, 10, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3607), null, "Etaj 6", true, "J102" },
                    { 93, 10, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3615), null, "Etaj 6", true, "J103" },
                    { 94, 10, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3623), null, "Etaj 6", true, "J104" },
                    { 95, 10, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3630), null, "Etaj 6", true, "J105" },
                    { 96, 10, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3638), "Camere, Echipament video", "Etaj 7", true, "LabMedia201" },
                    { 97, 10, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3647), "Echipament audio", "Etaj 7", true, "LabMedia202" },
                    { 98, 10, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3655), null, "Etaj 7", true, "SemPR203" },
                    { 99, 10, 100, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3712), "Proiector, Sistem audio", "Etaj 6", true, "AmfJ1" },
                    { 100, 10, 20, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3720), "Studio TV/Radio", "Etaj 7", true, "StudioJ2" },
                    { 101, 11, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3728), null, "Etaj 1", true, "LLS101" },
                    { 102, 11, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3736), null, "Etaj 1", true, "LLS102" },
                    { 103, 11, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3743), null, "Etaj 1", true, "LLS103" },
                    { 104, 11, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3751), null, "Etaj 1", true, "LLS104" },
                    { 105, 11, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3759), null, "Etaj 1", true, "LLS105" },
                    { 106, 11, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3767), "Echipament limbi străine", "Etaj 2", true, "LabLingv201" },
                    { 107, 11, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3776), "Computere, Software lingvistic", "Etaj 2", true, "LabLingv202" },
                    { 108, 11, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3783), null, "Etaj 2", true, "SemLLS203" },
                    { 109, 11, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3792), "Proiector, Sistem audio", "Parter", true, "AmfLLS1" },
                    { 110, 11, 120, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3800), "Proiector", "Parter", true, "AmfLLS2" },
                    { 111, 12, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3807), null, "Etaj 1", true, "Lit101" },
                    { 112, 12, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3815), null, "Etaj 1", true, "Lit102" },
                    { 113, 12, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3876), null, "Etaj 1", true, "Lit103" },
                    { 114, 12, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3884), null, "Etaj 1", true, "Lit104" },
                    { 115, 12, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3892), null, "Etaj 1", true, "Lit105" },
                    { 116, 12, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3901), null, "Etaj 2", true, "SemLit201" },
                    { 117, 12, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3909), null, "Etaj 2", true, "SemLit202" },
                    { 118, 12, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3916), null, "Etaj 2", true, "SemLit203" },
                    { 119, 12, 200, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3925), "Proiector, Sistem audio", "Parter", true, "AmfLit1" },
                    { 120, 12, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3932), "Proiector", "Parter", true, "AmfLit2" },
                    { 121, 13, 300, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3940), "Proiector, Sistem audio premium", "Parter", true, "Amf. Spiru Haret" },
                    { 122, 13, 250, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3949), "Proiector, Sistem audio", "Parter", true, "Amf. Gheorghe Țițeica" },
                    { 123, 13, 200, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3957), "Proiector, Sistem audio", "Parter", true, "Amf. Simion Stoilow" },
                    { 124, 13, 180, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3966), "Proiector, Sistem audio", "Parter", true, "Amf. Dimitrie Pompeiu" },
                    { 125, 13, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3975), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 1" },
                    { 126, 13, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(3984), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 2" },
                    { 127, 13, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4595), "30 Computere, Proiector", "Etaj 1", true, "Lab FMI 3" },
                    { 128, 13, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4622), null, "Etaj 1", true, "S101" },
                    { 129, 13, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4630), null, "Etaj 1", true, "S102" },
                    { 130, 13, 50, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4638), null, "Etaj 1", true, "S103" },
                    { 131, 14, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4646), null, "Etaj 1", true, "Psi101" },
                    { 132, 14, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4654), null, "Etaj 1", true, "Psi102" },
                    { 133, 14, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4661), null, "Etaj 1", true, "Psi103" },
                    { 134, 14, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4669), null, "Etaj 1", true, "Psi104" },
                    { 135, 14, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4677), null, "Etaj 1", true, "Psi105" },
                    { 136, 14, 20, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4739), "Echipament psihologie", "Etaj 2", true, "LabPsi201" },
                    { 137, 14, 20, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4746), "Computere, Software psiho", "Etaj 2", true, "LabPsi202" },
                    { 138, 14, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4754), null, "Etaj 2", true, "SemEdu203" },
                    { 139, 14, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4762), "Proiector, Sistem audio", "Parter", true, "AmfPsi1" },
                    { 140, 14, 120, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4770), "Proiector", "Parter", true, "AmfPsi2" },
                    { 141, 15, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4777), null, "Etaj 1", true, "SAS101" },
                    { 142, 15, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4849), null, "Etaj 1", true, "SAS102" },
                    { 143, 15, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4858), null, "Etaj 1", true, "SAS103" },
                    { 144, 15, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4864), null, "Etaj 1", true, "SAS104" },
                    { 145, 15, 40, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4872), null, "Etaj 1", true, "SAS105" },
                    { 146, 15, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4880), null, "Etaj 2", true, "SemSAS201" },
                    { 147, 15, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4887), null, "Etaj 2", true, "SemSAS202" },
                    { 148, 15, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4895), null, "Etaj 2", true, "SemSAS203" },
                    { 149, 15, 150, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4903), "Proiector, Sistem audio", "Parter", true, "AmfSAS1" },
                    { 150, 15, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4911), "Computere, Software SPSS", "Etaj 2", true, "LabSAS2" },
                    { 151, 16, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4918), null, "Etaj 1", true, "FSP101" },
                    { 152, 16, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4926), null, "Etaj 1", true, "FSP102" },
                    { 153, 16, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4933), null, "Etaj 1", true, "FSP103" },
                    { 154, 16, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4941), null, "Etaj 1", true, "FSP104" },
                    { 155, 16, 45, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4948), null, "Etaj 1", true, "FSP105" },
                    { 156, 16, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(4956), null, "Etaj 2", true, "SemFSP201" },
                    { 157, 16, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(5014), null, "Etaj 2", true, "SemFSP202" },
                    { 158, 16, 30, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(5021), null, "Etaj 2", true, "SemFSP203" },
                    { 159, 16, 180, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(5029), "Proiector, Sistem audio", "Parter", true, "AmfFSP1" },
                    { 160, 16, 25, new DateTime(2025, 12, 26, 11, 42, 46, 259, DateTimeKind.Utc).AddTicks(5038), "Computere", "Etaj 2", true, "LabFSP2" }
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
                    { 1, new DateTime(2025, 12, 26, 11, 42, 46, 268, DateTimeKind.Utc).AddTicks(2661), 14, "Principii de inginerie software și design patterns", new DateTime(2025, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 121, new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), "Curs Inginerie Software" },
                    { 2, new DateTime(2025, 12, 26, 11, 42, 46, 268, DateTimeKind.Utc).AddTicks(3177), 15, "Lucru cu SQL și modelare baze de date", new DateTime(2025, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 125, new DateTime(2025, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), "Seminar Baze de Date" },
                    { 3, new DateTime(2025, 12, 26, 11, 42, 46, 268, DateTimeKind.Utc).AddTicks(3182), 14, "Algoritmi de sortare și căutare", new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 122, new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Local), "Curs Algoritmi și Structuri de Date" },
                    { 4, new DateTime(2025, 12, 26, 11, 42, 46, 268, DateTimeKind.Utc).AddTicks(3185), 15, "Dreptul persoanelor și al familiei", new DateTime(2025, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), true, null, "Weekly", 36, new DateTime(2025, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), "Curs Drept Civil" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_Name",
                table: "Buildings",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_EventId",
                table: "EventParticipants",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizerId",
                table: "Events",
                column: "OrganizerId");

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
                name: "EventParticipants");

            migrationBuilder.DropTable(
                name: "GroupMembers");

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
