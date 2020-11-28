using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FotballSchoolMS.DAL.Migrations
{
    public partial class DomainModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CompetitionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembershipFees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipFees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opponents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateTo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telephone = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeePositionID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeePositions_EmployeePositionID",
                        column: x => x.EmployeePositionID,
                        principalTable: "EmployeePositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CompetitionTypeID = table.Column<int>(type: "int", nullable: true),
                    SeasonID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competitions_CompetitionTypes_CompetitionTypeID",
                        column: x => x.CompetitionTypeID,
                        principalTable: "CompetitionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Competitions_Seasons_SeasonID",
                        column: x => x.SeasonID,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    NumberOfPlayers = table.Column<int>(type: "int", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoachID = table.Column<int>(type: "int", nullable: true),
                    AssistantCoach1ID = table.Column<int>(type: "int", nullable: true),
                    AssistantCoach2ID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Employees_AssistantCoach1ID",
                        column: x => x.AssistantCoach1ID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Groups_Employees_AssistantCoach2ID",
                        column: x => x.AssistantCoach2ID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Groups_Employees_CoachID",
                        column: x => x.CoachID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UniqueId = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateTo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    AspNetUserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_AspNetUsers_AspNetUserID",
                        column: x => x.AspNetUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Players_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: true),
                    TrainingTypeID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainings_TrainingTypes_TrainingTypeID",
                        column: x => x.TrainingTypeID,
                        principalTable: "TrainingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerMembershipFees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    MembershipFeeID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerMembershipFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerMembershipFees_MembershipFees_MembershipFeeID",
                        column: x => x.MembershipFeeID,
                        principalTable: "MembershipFees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerMembershipFees_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingsPresences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PlayerID = table.Column<int>(type: "int", nullable: true),
                    CoachID = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    TrainingID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingsPresences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingsPresences_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingsPresences_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingsPresences_Trainings_TrainingID",
                        column: x => x.TrainingID,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CompetitionTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 27, 14, 50, 29, 801, DateTimeKind.Utc).AddTicks(3830), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CompetitionType1" },
                    { 2, new DateTime(2020, 11, 27, 14, 50, 29, 801, DateTimeKind.Utc).AddTicks(4338), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CompetitionType2" },
                    { 3, new DateTime(2020, 11, 27, 14, 50, 29, 801, DateTimeKind.Utc).AddTicks(4347), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CompetitionType3" }
                });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 27, 14, 50, 29, 822, DateTimeKind.Utc).AddTicks(7545), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach" },
                    { 2, new DateTime(2020, 11, 27, 14, 50, 29, 822, DateTimeKind.Utc).AddTicks(7600), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assistant-Coach" },
                    { 3, new DateTime(2020, 11, 27, 14, 50, 29, 822, DateTimeKind.Utc).AddTicks(7603), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Goalkeeper-Coach" },
                    { 4, new DateTime(2020, 11, 27, 14, 50, 29, 822, DateTimeKind.Utc).AddTicks(7605), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Economist" }
                });

            migrationBuilder.InsertData(
                table: "MembershipFees",
                columns: new[] { "Id", "Amount", "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 2, 60m, new DateTime(2020, 11, 27, 14, 50, 29, 827, DateTimeKind.Utc).AddTicks(6752), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MembershipFee2" },
                    { 3, 40m, new DateTime(2020, 11, 27, 14, 50, 29, 827, DateTimeKind.Utc).AddTicks(6756), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MembershipFee2" },
                    { 1, 50m, new DateTime(2020, 11, 27, 14, 50, 29, 827, DateTimeKind.Utc).AddTicks(6695), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MembershipFee1" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateTo", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 27, 14, 50, 29, 836, DateTimeKind.Utc).AddTicks(9825), "hmuftic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Season1" },
                    { 2, new DateTime(2020, 11, 27, 14, 50, 29, 836, DateTimeKind.Utc).AddTicks(9882), "hmuftic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Season2" },
                    { 3, new DateTime(2020, 11, 27, 14, 50, 29, 836, DateTimeKind.Utc).AddTicks(9885), "hmuftic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Season2" }
                });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Address", "Capacity", "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "Telephone" },
                values: new object[,]
                {
                    { 1, "Address1", 20000, new DateTime(2020, 11, 27, 14, 50, 29, 838, DateTimeKind.Utc).AddTicks(6184), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stadium1", 11231232 },
                    { 2, "Address2", 20000, new DateTime(2020, 11, 27, 14, 50, 29, 838, DateTimeKind.Utc).AddTicks(6288), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stadium2", 11231232 },
                    { 3, "Address3", 20000, new DateTime(2020, 11, 27, 14, 50, 29, 838, DateTimeKind.Utc).AddTicks(6292), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stadium2", 11231232 }
                });

            migrationBuilder.InsertData(
                table: "TrainingTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 11, 27, 14, 50, 29, 844, DateTimeKind.Utc).AddTicks(8818), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TrainingType2" },
                    { 1, new DateTime(2020, 11, 27, 14, 50, 29, 844, DateTimeKind.Utc).AddTicks(8765), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TrainingType1" },
                    { 3, new DateTime(2020, 11, 27, 14, 50, 29, 844, DateTimeKind.Utc).AddTicks(8821), "hmuftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TrainingType3" }
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "CompetitionTypeID", "CreatedAt", "CreatedBy", "IsActive", "ModifiedAt", "Name", "SeasonID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 11, 27, 14, 50, 29, 806, DateTimeKind.Utc).AddTicks(751), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Competition1", 1 },
                    { 2, 2, new DateTime(2020, 11, 27, 14, 50, 29, 806, DateTimeKind.Utc).AddTicks(2922), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Competition2", 2 },
                    { 3, 3, new DateTime(2020, 11, 27, 14, 50, 29, 806, DateTimeKind.Utc).AddTicks(2964), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Competition3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EmployeePositionID", "LastName", "ModifiedAt", "Name", "Telephone" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 27, 14, 50, 29, 821, DateTimeKind.Utc).AddTicks(6797), "hmuftic", "hmuftic@hotmail.com", 1, "muftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Husein", 387435655 },
                    { 2, new DateTime(2020, 11, 27, 14, 50, 29, 821, DateTimeKind.Utc).AddTicks(6904), "hmuftic", "asaric@hotmail.com", 2, "Saric", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adin", 387435655 },
                    { 3, new DateTime(2020, 11, 27, 14, 50, 29, 821, DateTimeKind.Utc).AddTicks(6907), "hmuftic", "ehalilovic@hotmail.com", 3, "Halilovic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edin", 387435655 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Age", "AssistantCoach1ID", "AssistantCoach2ID", "CoachID", "CreatedAt", "CreatedBy", "DateTo", "ModifiedAt", "Name", "NumberOfPlayers" },
                values: new object[] { 1, 18, 2, 3, 1, new DateTime(2020, 11, 27, 14, 50, 29, 826, DateTimeKind.Utc).AddTicks(2143), "hmuftic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group1", 25 });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Age", "AssistantCoach1ID", "AssistantCoach2ID", "CoachID", "CreatedAt", "CreatedBy", "DateTo", "ModifiedAt", "Name", "NumberOfPlayers" },
                values: new object[] { 2, 15, 1, 3, 2, new DateTime(2020, 11, 27, 14, 50, 29, 826, DateTimeKind.Utc).AddTicks(2246), "hmuftic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group2", 22 });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Age", "AssistantCoach1ID", "AssistantCoach2ID", "CoachID", "CreatedAt", "CreatedBy", "DateTo", "ModifiedAt", "Name", "NumberOfPlayers" },
                values: new object[] { 3, 25, 3, 1, 2, new DateTime(2020, 11, 27, 14, 50, 29, 826, DateTimeKind.Utc).AddTicks(2249), "hmuftic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group3", 26 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "AspNetUserID", "BirthDate", "CreatedAt", "CreatedBy", "DateTo", "Email", "GroupID", "LastName", "ModifiedAt", "Name", "Telephone", "UniqueId" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(1998, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTime(2020, 11, 27, 14, 50, 29, 833, DateTimeKind.Utc).AddTicks(5257), "hmuftic", null, "hmuftic@hotmail.com", 1, "Muftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Husein", 123123123, 0 },
                    { 2, null, new DateTimeOffset(new DateTime(1978, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2020, 11, 27, 14, 50, 29, 833, DateTimeKind.Utc).AddTicks(5432), "hmuftic", null, "hmuftic@hotmail.com", 2, "Muftic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edin", 123123123, 0 },
                    { 4, null, new DateTimeOffset(new DateTime(1978, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2020, 11, 27, 14, 50, 29, 833, DateTimeKind.Utc).AddTicks(5448), "hmuftic", null, "hmuftic@hotmail.com", 2, "Halilovic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adi", 123123123, 0 },
                    { 3, null, new DateTimeOffset(new DateTime(1978, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2020, 11, 27, 14, 50, 29, 833, DateTimeKind.Utc).AddTicks(5442), "hmuftic", null, "hmuftic@hotmail.com", 3, "Halilovic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adin", 123123123, 0 }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "GroupID", "ModifiedAt", "Name", "TrainingTypeID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 27, 14, 50, 29, 841, DateTimeKind.Utc).AddTicks(4708), "hmuftic", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training1", 1 },
                    { 2, new DateTime(2020, 11, 27, 14, 50, 29, 841, DateTimeKind.Utc).AddTicks(4776), "hmuftic", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training2", 2 },
                    { 3, new DateTime(2020, 11, 27, 14, 50, 29, 841, DateTimeKind.Utc).AddTicks(4780), "hmuftic", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training3", 2 },
                    { 4, new DateTime(2020, 11, 27, 14, 50, 29, 841, DateTimeKind.Utc).AddTicks(4782), "hmuftic", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training4", 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerMembershipFees",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "MembershipFeeID", "ModifiedAt", "PlayerID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 27, 14, 50, 29, 835, DateTimeKind.Utc).AddTicks(6894), "hmuftic", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2020, 11, 27, 14, 50, 29, 835, DateTimeKind.Utc).AddTicks(8073), "hmuftic", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(2020, 11, 27, 14, 50, 29, 835, DateTimeKind.Utc).AddTicks(8070), "hmuftic", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 2, new DateTime(2020, 11, 27, 14, 50, 29, 835, DateTimeKind.Utc).AddTicks(8049), "hmuftic", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "TrainingsPresences",
                columns: new[] { "Id", "CoachID", "CreatedAt", "CreatedBy", "EmployeeId", "IsActive", "ModifiedAt", "PlayerID", "TrainingID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 11, 27, 14, 50, 29, 843, DateTimeKind.Utc).AddTicks(6774), "hmuftic", null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 2, null, new DateTime(2020, 11, 27, 14, 50, 29, 843, DateTimeKind.Utc).AddTicks(6918), "hmuftic", null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, null, new DateTime(2020, 11, 27, 14, 50, 29, 843, DateTimeKind.Utc).AddTicks(6922), "hmuftic", null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_CompetitionTypeID",
                table: "Competitions",
                column: "CompetitionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_SeasonID",
                table: "Competitions",
                column: "SeasonID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeePositionID",
                table: "Employees",
                column: "EmployeePositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_AssistantCoach1ID",
                table: "Groups",
                column: "AssistantCoach1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_AssistantCoach2ID",
                table: "Groups",
                column: "AssistantCoach2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CoachID",
                table: "Groups",
                column: "CoachID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMembershipFees_MembershipFeeID",
                table: "PlayerMembershipFees",
                column: "MembershipFeeID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMembershipFees_PlayerID",
                table: "PlayerMembershipFees",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_AspNetUserID",
                table: "Players",
                column: "AspNetUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_GroupID",
                table: "Players",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_GroupID",
                table: "Trainings",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_TrainingTypeID",
                table: "Trainings",
                column: "TrainingTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingsPresences_EmployeeId",
                table: "TrainingsPresences",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingsPresences_PlayerID",
                table: "TrainingsPresences",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingsPresences_TrainingID",
                table: "TrainingsPresences",
                column: "TrainingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Opponents");

            migrationBuilder.DropTable(
                name: "PlayerMembershipFees");

            migrationBuilder.DropTable(
                name: "Stadiums");

            migrationBuilder.DropTable(
                name: "TrainingsPresences");

            migrationBuilder.DropTable(
                name: "CompetitionTypes");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "MembershipFees");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "TrainingTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeePositions");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
