using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planerve.App.Persistence.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    administrative_district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    administrative_county = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    administrative_ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ced = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ccg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuts = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Application_Id",
                        column: x => x.Id,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorisedUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadApplication = table.Column<bool>(type: "bit", nullable: false),
                    CopyApplication = table.Column<bool>(type: "bit", nullable: false),
                    ReadForm = table.Column<bool>(type: "bit", nullable: false),
                    EditForm = table.Column<bool>(type: "bit", nullable: false),
                    DownloadForm = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorisedUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorisedUser_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checklist",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormSections = table.Column<bool>(type: "bit", nullable: false),
                    PlansAndDocs = table.Column<bool>(type: "bit", nullable: false),
                    CalculatedFee = table.Column<bool>(type: "bit", nullable: false),
                    SubmittedToLocalAuthority = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checklist_Application_Id",
                        column: x => x.Id,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormData_Application_Id",
                        column: x => x.Id,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeOne",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EastingValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NorthingValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeOne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormTypeOne_FormData_Id",
                        column: x => x.Id,
                        principalTable: "FormData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeTwo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EastingValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NorthingValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeTwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormTypeTwo_FormData_Id",
                        column: x => x.Id,
                        principalTable: "FormData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorisedUser_ApplicationId",
                table: "AuthorisedUser",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AuthorisedUser");

            migrationBuilder.DropTable(
                name: "Checklist");

            migrationBuilder.DropTable(
                name: "FormTypeOne");

            migrationBuilder.DropTable(
                name: "FormTypeTwo");

            migrationBuilder.DropTable(
                name: "FormData");

            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
