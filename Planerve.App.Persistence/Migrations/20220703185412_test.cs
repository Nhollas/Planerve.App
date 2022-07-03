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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PassHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PassSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TokenExpires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EligibilitySection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HasInterest = table.Column<bool>(type: "bit", nullable: false),
                    OptionValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EligibilitySection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FloorSpaceSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoesIncludeGainOrLoss = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorSpaceSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeC",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteSection_AutoPopulated = table.Column<bool>(type: "bit", nullable: true),
                    SiteSection_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Easting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Northing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_CopyFromSiteAddress = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_IsAgent = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeProposalSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DischargeProposalSection_ApprovedDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeProposalSection_ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeProposalSection_DecisionDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DischargeProposalSection_ConditionNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeProposalSection_HasStarted = table.Column<bool>(type: "bit", nullable: true),
                    DischargeProposalSection_StartedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DischargeProposalSection_IsCompleted = table.Column<bool>(type: "bit", nullable: true),
                    DischargeProposalSection_CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SiteVisitSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_SiteVisible = table.Column<bool>(type: "bit", nullable: true),
                    SiteVisitSection_AppointmentContactType = table.Column<int>(type: "int", nullable: true),
                    SiteVisitSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSection_AdviceSought = table.Column<bool>(type: "bit", nullable: true),
                    AdviceSection_ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdviceSection_AdviceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargePartOnly = table.Column<bool>(type: "bit", nullable: false),
                    PartsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmittedInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "HazardousSubstanceSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvolvesHazardousSubstances = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardousSubstanceSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndustrialMachinerySection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessesAndProducts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoesInvolveIndustrialCommercial = table.Column<bool>(type: "bit", nullable: false),
                    IsProposalWasteManagementDevelopment = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustrialMachinerySection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialsRequired = table.Column<bool>(type: "bit", nullable: false),
                    AdditionalInformation = table.Column<bool>(type: "bit", nullable: false),
                    DocumentReference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpeningHoursSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsRelevant = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHoursSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnershipCertificationSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SelectedCertificate = table.Column<int>(type: "int", nullable: false),
                    SoleOwner = table.Column<bool>(type: "bit", nullable: false),
                    IsAgriculturalHolding = table.Column<bool>(type: "bit", nullable: false),
                    GiveAppropriateNotice = table.Column<bool>(type: "bit", nullable: false),
                    GiveSomeNotice = table.Column<bool>(type: "bit", nullable: false),
                    CertificateA_Role = table.Column<int>(type: "int", nullable: true),
                    CertificateA_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateA_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateA_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateA_DeclarationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateA_DeclarationMade = table.Column<bool>(type: "bit", nullable: true),
                    CertificateB_Certifies = table.Column<bool>(type: "bit", nullable: true),
                    CertificateB_Role = table.Column<int>(type: "int", nullable: true),
                    CertificateB_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateB_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateB_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateB_DeclarationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateB_DeclarationMade = table.Column<bool>(type: "bit", nullable: true),
                    CertificateB_CertificateBFK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CertificateC_StepsTakenDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateC_PublishedInPaper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateC_PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateC_Role = table.Column<int>(type: "int", nullable: true),
                    CertificateC_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateC_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateC_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateC_DeclarationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateC_DeclarationMade = table.Column<bool>(type: "bit", nullable: true),
                    CertificateC_CertificateCFK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CertificateD_StepsTaken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateD_PublishedInPaper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateD_PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateD_Role = table.Column<int>(type: "int", nullable: true),
                    CertificateD_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateD_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateD_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateD_DeclarationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateD_DeclarationMade = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnershipCertificationSection", x => x.Id);
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
                name: "PermissionUser",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionUser", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_PermissionUser_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeD",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteSection_AutoPopulated = table.Column<bool>(type: "bit", nullable: true),
                    SiteSection_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Easting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Northing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_CopyFromSiteAddress = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_IsAgent = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EligibilitySectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_SiteVisible = table.Column<bool>(type: "bit", nullable: true),
                    SiteVisitSection_AppointmentContactType = table.Column<int>(type: "int", nullable: true),
                    SiteVisitSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSection_AdviceSought = table.Column<bool>(type: "bit", nullable: true),
                    AdviceSection_ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdviceSection_AdviceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorityMemberSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorityMemberSection_IsRelated = table.Column<bool>(type: "bit", nullable: true),
                    AuthorityMemberSection_RelatedInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeD", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_FormTypeD_EligibilitySection_EligibilitySectionId",
                        column: x => x.EligibilitySectionId,
                        principalTable: "EligibilitySection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NotifiedPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EligibilitySectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeServed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifiedPerson", x => new { x.EligibilitySectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_NotifiedPerson_EligibilitySection_EligibilitySectionId",
                        column: x => x.EligibilitySectionId,
                        principalTable: "EligibilitySection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FloorSpace",
                columns: table => new
                {
                    FloorSpaceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingGrossFloorspace = table.Column<int>(type: "int", nullable: false),
                    GrossFloorspaceToBeLost = table.Column<int>(type: "int", nullable: false),
                    TotalGrossFloorspaceProposed = table.Column<int>(type: "int", nullable: false),
                    NetAdditionalGrossFloorspace = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorSpace", x => new { x.FloorSpaceSectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_FloorSpace_FloorSpaceSection_FloorSpaceSectionId",
                        column: x => x.FloorSpaceSectionId,
                        principalTable: "FloorSpaceSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomInformation",
                columns: table => new
                {
                    FloorSpaceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingRoomsToBeLost = table.Column<int>(type: "int", nullable: false),
                    TotalRoomsProposed = table.Column<int>(type: "int", nullable: false),
                    NetAdditionalRooms = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomInformation", x => new { x.FloorSpaceSectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_RoomInformation_FloorSpaceSection_FloorSpaceSectionId",
                        column: x => x.FloorSpaceSectionId,
                        principalTable: "FloorSpaceSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Substance",
                columns: table => new
                {
                    HazardousSubstanceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substance", x => new { x.HazardousSubstanceSectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_Substance_HazardousSubstanceSection_HazardousSubstanceSectionId",
                        column: x => x.HazardousSubstanceSectionId,
                        principalTable: "HazardousSubstanceSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteManagementDetail",
                columns: table => new
                {
                    IndustrialMachinerySectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WasteManagementType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalVoidCapacityVolumeUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxAnnualOperationalThroughputVolumeUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalVoidCapacity = table.Column<int>(type: "int", nullable: false),
                    MaxAnnualOperationalThroughput = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteManagementDetail", x => new { x.IndustrialMachinerySectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_WasteManagementDetail_IndustrialMachinerySection_IndustrialMachinerySectionId",
                        column: x => x.IndustrialMachinerySectionId,
                        principalTable: "IndustrialMachinerySection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteStreamDetail",
                columns: table => new
                {
                    IndustrialMachinerySectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WasteStreamType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxAnnualOperationalThroughputVolumeUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxAnnualOperationalThroughput = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteStreamDetail", x => new { x.IndustrialMachinerySectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_WasteStreamDetail_IndustrialMachinerySection_IndustrialMachinerySectionId",
                        column: x => x.IndustrialMachinerySectionId,
                        principalTable: "IndustrialMachinerySection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialType",
                columns: table => new
                {
                    MaterialSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposedMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialType", x => new { x.MaterialSectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_MaterialType_MaterialSection_MaterialSectionId",
                        column: x => x.MaterialSectionId,
                        principalTable: "MaterialSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UseClass",
                columns: table => new
                {
                    OpeningHoursSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsKnown = table.Column<bool>(type: "bit", nullable: false),
                    MtoFStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    MtoFEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SaturdayStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SaturdayEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SpecialStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SpecialEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseClass", x => new { x.OpeningHoursSectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_UseClass_OpeningHoursSection_OpeningHoursSectionId",
                        column: x => x.OpeningHoursSectionId,
                        principalTable: "OpeningHoursSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormTypeA",
                columns: table => new
                {
                    FormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_CopyFromSiteAddress = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_IsAgent = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProposalSection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_HasStarted = table.Column<bool>(type: "bit", nullable: true),
                    ProposalSection_StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProposalSection_HasCompleted = table.Column<bool>(type: "bit", nullable: true),
                    ProposalSection_CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SiteSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteSection_AutoPopulated = table.Column<bool>(type: "bit", nullable: true),
                    SiteSection_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Easting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Northing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccessSection_NewVehicleAccess = table.Column<bool>(type: "bit", nullable: true),
                    AccessSection_NewAlteredPedestrianAccess = table.Column<bool>(type: "bit", nullable: true),
                    AccessSection_AffectingRightOfWay = table.Column<bool>(type: "bit", nullable: true),
                    AccessSection_DrawingReferenceNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSection_AdviceSought = table.Column<bool>(type: "bit", nullable: true),
                    AdviceSection_ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdviceSection_AdviceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreeAndHedgeSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreeAndHedgeSection_FallingTreesHedge = table.Column<bool>(type: "bit", nullable: true),
                    TreeAndHedgeSection_FallingTreeHedgeReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreeAndHedgeSection_TreeHedgeRemoved = table.Column<bool>(type: "bit", nullable: true),
                    TreeAndHedgeSection_TreeHedgeRemovedReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkingSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParkingSection_AffectingParking = table.Column<bool>(type: "bit", nullable: true),
                    ParkingSection_ParkingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorityMemberSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorityMemberSection_IsRelated = table.Column<bool>(type: "bit", nullable: true),
                    AuthorityMemberSection_RelatedInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnershipCertificationSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_SiteVisible = table.Column<bool>(type: "bit", nullable: true),
                    SiteVisitSection_AppointmentContactType = table.Column<int>(type: "int", nullable: true),
                    SiteVisitSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeA", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_FormTypeA_MaterialSection_MaterialSectionId",
                        column: x => x.MaterialSectionId,
                        principalTable: "MaterialSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_OwnershipCertificationSection_OwnershipCertificationSectionId",
                        column: x => x.OwnershipCertificationSectionId,
                        principalTable: "OwnershipCertificationSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormTypeB",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_CopyFromSiteAddress = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_IsAgent = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProposalSection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_HasStarted = table.Column<bool>(type: "bit", nullable: true),
                    ProposalSection_StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProposalSection_HasCompleted = table.Column<bool>(type: "bit", nullable: true),
                    ProposalSection_CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SiteSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteSection_AutoPopulated = table.Column<bool>(type: "bit", nullable: true),
                    SiteSection_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Easting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Northing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSection_AdviceSought = table.Column<bool>(type: "bit", nullable: true),
                    AdviceSection_ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdviceSection_AdviceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccessSection_NewVehicleAccess = table.Column<bool>(type: "bit", nullable: true),
                    AccessSection_NewAlteredPedestrianAccess = table.Column<bool>(type: "bit", nullable: true),
                    AccessSection_AffectingRightOfWay = table.Column<bool>(type: "bit", nullable: true),
                    AccessSection_DrawingReferenceNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WasteSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WasteSection_StoreCollectWaste = table.Column<bool>(type: "bit", nullable: true),
                    WasteSection_StoreCollectWasteDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WasteSection_StoreCollectRecyclableWaste = table.Column<bool>(type: "bit", nullable: true),
                    WasteSection_StoreCollectRecyclableWasteDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorityMemberSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorityMemberSection_IsRelated = table.Column<bool>(type: "bit", nullable: true),
                    AuthorityMemberSection_RelatedInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParkingSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParkingSection_AffectingParking = table.Column<bool>(type: "bit", nullable: true),
                    ParkingSection_ParkingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoulSewageSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FoulSewageSection_OtherMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoulSewageSection_ConnectingToExistingDrainage = table.Column<bool>(type: "bit", nullable: true),
                    FoulSewageSection_DocumentReferences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoulSewageSection_MainsSewer = table.Column<bool>(type: "bit", nullable: true),
                    FoulSewageSection_SepticTank = table.Column<bool>(type: "bit", nullable: true),
                    FoulSewageSection_PackageTreatmentPlant = table.Column<bool>(type: "bit", nullable: true),
                    FoulSewageSection_CessPit = table.Column<bool>(type: "bit", nullable: true),
                    FoulSewageSection_Other = table.Column<bool>(type: "bit", nullable: true),
                    FoulSewageSection_Unknown = table.Column<bool>(type: "bit", nullable: true),
                    FloodRiskSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FloodRiskSection_IsFloodRisk = table.Column<bool>(type: "bit", nullable: true),
                    FloodRiskSection_ProximityOfWatercourse = table.Column<bool>(type: "bit", nullable: true),
                    FloodRiskSection_IncreaseFloodRisk = table.Column<bool>(type: "bit", nullable: true),
                    FloodRiskSection_SustainableDrainage = table.Column<bool>(type: "bit", nullable: true),
                    FloodRiskSection_ExistingWaterCourse = table.Column<bool>(type: "bit", nullable: true),
                    FloodRiskSection_Soakaway = table.Column<bool>(type: "bit", nullable: true),
                    FloodRiskSection_MainSewer = table.Column<bool>(type: "bit", nullable: true),
                    FloodRiskSection_PondLake = table.Column<bool>(type: "bit", nullable: true),
                    BiodiversitySection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BiodiversitySection_ProtectedSpecies = table.Column<int>(type: "int", nullable: true),
                    BiodiversitySection_DesignatedSite = table.Column<int>(type: "int", nullable: true),
                    BiodiversitySection_FeaturesOfGeological = table.Column<int>(type: "int", nullable: true),
                    ExistingUseSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExistingUseSection_CurrentUseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingUseSection_IsVacant = table.Column<bool>(type: "bit", nullable: true),
                    ExistingUseSection_LastUseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingUseSection_UseEnded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExistingUseSection_LandToBeContaminated = table.Column<bool>(type: "bit", nullable: true),
                    ExistingUseSection_PartLandToBeContaminated = table.Column<bool>(type: "bit", nullable: true),
                    ExistingUseSection_UseSusceptibleToContamination = table.Column<bool>(type: "bit", nullable: true),
                    TreeAndHedgeSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreeAndHedgeSection_FallingTreesHedge = table.Column<bool>(type: "bit", nullable: true),
                    TreeAndHedgeSection_FallingTreeHedgeReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreeAndHedgeSection_TreeHedgeRemoved = table.Column<bool>(type: "bit", nullable: true),
                    TreeAndHedgeSection_TreeHedgeRemovedReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeEffluentSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TradeEffluentSection_DisposeTradeWaste = table.Column<bool>(type: "bit", nullable: true),
                    TradeEffluentSection_TradeWasteDescription = table.Column<bool>(type: "bit", nullable: true),
                    EmploymentSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmploymentSection_IsEmploymentChanged = table.Column<bool>(type: "bit", nullable: true),
                    EmploymentSection_ExistingFullTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentSection_ExistingPartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentSection_ExistingTotalFullTimeEquivalent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentSection_ProposedFullTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentSection_ProposedPartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentSection_ProposedTotalFullTimeEquivalent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHoursSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IndustrialMachinerySectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HazardousSubstanceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnershipCertificationSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_SiteVisible = table.Column<bool>(type: "bit", nullable: true),
                    SiteVisitSection_AppointmentContactType = table.Column<int>(type: "int", nullable: true),
                    SiteVisitSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeB", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_FormTypeB_HazardousSubstanceSection_HazardousSubstanceSectionId",
                        column: x => x.HazardousSubstanceSectionId,
                        principalTable: "HazardousSubstanceSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_IndustrialMachinerySection_IndustrialMachinerySectionId",
                        column: x => x.IndustrialMachinerySectionId,
                        principalTable: "IndustrialMachinerySection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_MaterialSection_MaterialSectionId",
                        column: x => x.MaterialSectionId,
                        principalTable: "MaterialSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_OpeningHoursSection_OpeningHoursSectionId",
                        column: x => x.OpeningHoursSectionId,
                        principalTable: "OpeningHoursSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_OwnershipCertificationSection_OwnershipCertificationSectionId",
                        column: x => x.OwnershipCertificationSectionId,
                        principalTable: "OwnershipCertificationSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormTypeE",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_CopyFromSiteAddress = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_IsAgent = table.Column<bool>(type: "bit", nullable: true),
                    ApplicantSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteSection_AutoPopulated = table.Column<bool>(type: "bit", nullable: true),
                    SiteSection_HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Easting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Northing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteSection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSection_AdviceSought = table.Column<bool>(type: "bit", nullable: true),
                    AdviceSection_ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdviceSection_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdviceSection_AdviceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProposalSection_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalSection_HasStarted = table.Column<bool>(type: "bit", nullable: true),
                    ProposalSection_StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProposalSection_HasCompleted = table.Column<bool>(type: "bit", nullable: true),
                    ProposalSection_CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OwnershipCertificationSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSection_SiteVisible = table.Column<bool>(type: "bit", nullable: true),
                    SiteVisitSection_AppointmentContactType = table.Column<int>(type: "int", nullable: true),
                    SiteVisitSection_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitSection_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeE", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_FormTypeE_OwnershipCertificationSection_OwnershipCertificationSectionId",
                        column: x => x.OwnershipCertificationSectionId,
                        principalTable: "OwnershipCertificationSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    OwnershipCertificationSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeServed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => new { x.OwnershipCertificationSectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_Person_OwnershipCertificationSection_OwnershipCertificationSectionId",
                        column: x => x.OwnershipCertificationSectionId,
                        principalTable: "OwnershipCertificationSection",
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
                    PermissionUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_AuthorisedUser_PermissionUser_PermissionUserId",
                        column: x => x.PermissionUserId,
                        principalTable: "PermissionUser",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorisedUser_PermissionUserId",
                table: "AuthorisedUser",
                column: "PermissionUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_MaterialSectionId",
                table: "FormTypeA",
                column: "MaterialSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_OwnershipCertificationSectionId",
                table: "FormTypeA",
                column: "OwnershipCertificationSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_HazardousSubstanceSectionId",
                table: "FormTypeB",
                column: "HazardousSubstanceSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_IndustrialMachinerySectionId",
                table: "FormTypeB",
                column: "IndustrialMachinerySectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_MaterialSectionId",
                table: "FormTypeB",
                column: "MaterialSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_OpeningHoursSectionId",
                table: "FormTypeB",
                column: "OpeningHoursSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_OwnershipCertificationSectionId",
                table: "FormTypeB",
                column: "OwnershipCertificationSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_EligibilitySectionId",
                table: "FormTypeD",
                column: "EligibilitySectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_OwnershipCertificationSectionId",
                table: "FormTypeE",
                column: "OwnershipCertificationSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationProgress");

            migrationBuilder.DropTable(
                name: "ApplicationType");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuthorisedUser");

            migrationBuilder.DropTable(
                name: "DocumentRequirement");

            migrationBuilder.DropTable(
                name: "FloorSpace");

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
                name: "MaterialType");

            migrationBuilder.DropTable(
                name: "NotifiedPerson");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "RoomInformation");

            migrationBuilder.DropTable(
                name: "Substance");

            migrationBuilder.DropTable(
                name: "UseClass");

            migrationBuilder.DropTable(
                name: "WasteManagementDetail");

            migrationBuilder.DropTable(
                name: "WasteStreamDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PermissionUser");

            migrationBuilder.DropTable(
                name: "ApplicationDocument");

            migrationBuilder.DropTable(
                name: "MaterialSection");

            migrationBuilder.DropTable(
                name: "EligibilitySection");

            migrationBuilder.DropTable(
                name: "OwnershipCertificationSection");

            migrationBuilder.DropTable(
                name: "FloorSpaceSection");

            migrationBuilder.DropTable(
                name: "HazardousSubstanceSection");

            migrationBuilder.DropTable(
                name: "OpeningHoursSection");

            migrationBuilder.DropTable(
                name: "IndustrialMachinerySection");

            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
