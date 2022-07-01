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
                    VersionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "FormTypeA",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreeAndHedgeSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkingSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorityMemberSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnershipCertificationSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeA", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeB",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WasteSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorityMemberSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkingSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoulSewageSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloodRiskSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiodiversitySection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingUseSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreeAndHedgeSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeEffluentSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHoursSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteAreaSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustrialMachinerySection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HazardousSubstancesSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnershipCertificationSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeB", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeC",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeC", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeD",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorityMemberSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeD", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeE",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnershipCertificationSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeE", x => x.ApplicationId);
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
                        name: "FK_ApplicationDocument_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
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
                        name: "FK_ApplicationProgress_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
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
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationType", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationType_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
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
                name: "AuthorisedUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EditPermission = table.Column<bool>(type: "bit", nullable: false),
                    ReadApplication = table.Column<bool>(type: "bit", nullable: false),
                    DeleteApplication = table.Column<bool>(type: "bit", nullable: false),
                    CopyApplication = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveApplication = table.Column<bool>(type: "bit", nullable: false),
                    ShareApplication = table.Column<bool>(type: "bit", nullable: false),
                    ReadForm = table.Column<bool>(type: "bit", nullable: false),
                    UpdateForm = table.Column<bool>(type: "bit", nullable: false),
                    DownloadForm = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorisedUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorisedUser_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorisedUser_ApplicationUserId",
                table: "AuthorisedUser",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationProgress");

            migrationBuilder.DropTable(
                name: "ApplicationType");

            migrationBuilder.DropTable(
                name: "AuthorisedUser");

            migrationBuilder.DropTable(
                name: "DocumentRequirement");

            migrationBuilder.DropTable(
                name: "FormTypeA");

            migrationBuilder.DropTable(
                name: "FormTypeB");

            migrationBuilder.DropTable(
                name: "FormTypeC");

            migrationBuilder.DropTable(
                name: "FormTypeD");

            migrationBuilder.DropTable(
                name: "FormTypeE");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "ApplicationDocument");

            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
