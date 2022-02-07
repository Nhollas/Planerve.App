using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planerve.App.Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationTypeOne",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OneTextOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextFour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextFive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextSix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextSeven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextEight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextNine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextEleven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextTwelve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextThirteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextFourteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextFithteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextFour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextFive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextSix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextSeven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextEight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextNine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextEleven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextTwelve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextThirteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextFourteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextFithteen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTypeOne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationTypeOne_Application_Id",
                        column: x => x.Id,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationTypeTwo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OneTextOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextFour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextFive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextSix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextSeven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextEight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextNine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextEleven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextTwelve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextThirteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextFourteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTextFithteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextFour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextFive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextSix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextSeven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextEight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextNine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextEleven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextTwelve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextThirteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextFourteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoTextFithteen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTypeTwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationTypeTwo_Application_Id",
                        column: x => x.Id,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteApiData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteApiData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteApiData_Application_Id",
                        column: x => x.Id,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quality = table.Column<int>(type: "int", nullable: false),
                    eastings = table.Column<int>(type: "int", nullable: false),
                    northings = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nhs_ha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longitude = table.Column<float>(type: "real", nullable: false),
                    latitude = table.Column<float>(type: "real", nullable: false),
                    european_electoral_region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    primary_care_trust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lsoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    incode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    outcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parliamentary_constituency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_county = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ced = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ccg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuts = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Result_SiteApiData_Id",
                        column: x => x.Id,
                        principalTable: "SiteApiData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Codes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    admin_district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_county = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parliamentary_constituency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ccg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ccg_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ced = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lsoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lau2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Codes_Result_Id",
                        column: x => x.Id,
                        principalTable: "Result",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationTypeOne");

            migrationBuilder.DropTable(
                name: "ApplicationTypeTwo");

            migrationBuilder.DropTable(
                name: "Codes");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "SiteApiData");

            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
