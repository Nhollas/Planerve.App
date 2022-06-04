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
                name: "ApplicationData",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationData", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_ApplicationData_Id",
                        column: x => x.Id,
                        principalTable: "ApplicationData",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationAddress",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ApplicationAddress", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationAddress_ApplicationData_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationData",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationDocument",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentCount = table.Column<int>(type: "int", nullable: false),
                    CompletedRequirementsCount = table.Column<int>(type: "int", nullable: false),
                    TotalRequirementCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationDocument", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationDocument_ApplicationData_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationData",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationForm",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormSectionsComplete = table.Column<bool>(type: "bit", nullable: false),
                    TotalSectionCount = table.Column<int>(type: "int", nullable: false),
                    CompletedSectionCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForm", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationForm_ApplicationData_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationData",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationProgress",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgressPercentage = table.Column<int>(type: "int", nullable: false),
                    FormSectionsComplete = table.Column<bool>(type: "bit", nullable: false),
                    PlansAndDocsComplete = table.Column<bool>(type: "bit", nullable: false),
                    CalculatedFee = table.Column<bool>(type: "bit", nullable: false),
                    SubmittedToLocalAuthority = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationProgress", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationProgress_ApplicationData_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationData",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationType",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationType", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationType_ApplicationData_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationData",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ApplicationUser", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_ApplicationData_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationData",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentRequirement",
                columns: table => new
                {
                    ApplicationDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentRequirement", x => new { x.ApplicationDocumentId, x.Id });
                    table.ForeignKey(
                        name: "FK_DocumentRequirement_ApplicationDocument_ApplicationDocumentId",
                        column: x => x.ApplicationDocumentId,
                        principalTable: "ApplicationDocument",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormSection",
                columns: table => new
                {
                    ApplicationFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSection", x => new { x.ApplicationFormId, x.Id });
                    table.ForeignKey(
                        name: "FK_FormSection_ApplicationForm_ApplicationFormId",
                        column: x => x.ApplicationFormId,
                        principalTable: "ApplicationForm",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormField",
                columns: table => new
                {
                    FormSectionApplicationFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormSectionId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormField", x => new { x.FormSectionApplicationFormId, x.FormSectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_FormField_FormSection_FormSectionApplicationFormId_FormSectionId",
                        columns: x => new { x.FormSectionApplicationFormId, x.FormSectionId },
                        principalTable: "FormSection",
                        principalColumns: new[] { "ApplicationFormId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "ApplicationAddress");

            migrationBuilder.DropTable(
                name: "ApplicationProgress");

            migrationBuilder.DropTable(
                name: "ApplicationType");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "DocumentRequirement");

            migrationBuilder.DropTable(
                name: "FormField");

            migrationBuilder.DropTable(
                name: "ApplicationDocument");

            migrationBuilder.DropTable(
                name: "FormSection");

            migrationBuilder.DropTable(
                name: "ApplicationForm");

            migrationBuilder.DropTable(
                name: "ApplicationData");
        }
    }
}
