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
                name: "AccessSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewVehicleAccess = table.Column<bool>(type: "bit", nullable: false),
                    NewAlteredPedestrianAccess = table.Column<bool>(type: "bit", nullable: false),
                    AffectingRightOfWay = table.Column<bool>(type: "bit", nullable: false),
                    DrawingReferenceNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdviceSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdviceSought = table.Column<bool>(type: "bit", nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdviceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdviceSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgentSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicantSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CopyFromSiteAddress = table.Column<bool>(type: "bit", nullable: false),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAgent = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicantSection", x => x.Id);
                });

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
                name: "AuthorityMemberSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsRelated = table.Column<bool>(type: "bit", nullable: false),
                    RelatedInformation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorityMemberSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BiodiversitySection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProtectedSpecies = table.Column<int>(type: "int", nullable: false),
                    DesignatedSite = table.Column<int>(type: "int", nullable: false),
                    FeaturesOfGeological = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiodiversitySection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConditionProposalSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecisionDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ConditionNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasStarted = table.Column<bool>(type: "bit", nullable: false),
                    StartedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionProposalSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DischargeConditionSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DischargePartOnly = table.Column<bool>(type: "bit", nullable: false),
                    PartsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmittedInformation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DischargeConditionSection", x => x.Id);
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
                name: "EmploymentSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsEmploymentChanged = table.Column<bool>(type: "bit", nullable: false),
                    ExistingFullTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingPartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingTotalFullTimeEquivalent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposedFullTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposedPartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposedTotalFullTimeEquivalent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExistingUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OneBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    TwoBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    ThreeBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    FourBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    UnknownBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    ProposedBedroomTotalMarket = table.Column<int>(type: "int", nullable: false),
                    Market = table.Column<bool>(type: "bit", nullable: false),
                    SocialAffordableIntermediateRent = table.Column<bool>(type: "bit", nullable: false),
                    AffordableHomeOwnership = table.Column<bool>(type: "bit", nullable: false),
                    StarterHomes = table.Column<bool>(type: "bit", nullable: false),
                    SelfBuildCustomBuild = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExistingUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExistingUseSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentUseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVacant = table.Column<bool>(type: "bit", nullable: false),
                    LastUseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseEnded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LandToBeContaminated = table.Column<bool>(type: "bit", nullable: false),
                    PartLandToBeContaminated = table.Column<bool>(type: "bit", nullable: false),
                    UseSusceptibleToContamination = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExistingUseSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FloodRiskSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsFloodRisk = table.Column<bool>(type: "bit", nullable: false),
                    ProximityOfWatercourse = table.Column<bool>(type: "bit", nullable: false),
                    IncreaseFloodRisk = table.Column<bool>(type: "bit", nullable: false),
                    SustainableDrainage = table.Column<bool>(type: "bit", nullable: false),
                    ExistingWaterCourse = table.Column<bool>(type: "bit", nullable: false),
                    Soakaway = table.Column<bool>(type: "bit", nullable: false),
                    MainSewer = table.Column<bool>(type: "bit", nullable: false),
                    PondLake = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloodRiskSection", x => x.Id);
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
                name: "FoulSewageSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OtherMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectingToExistingDrainage = table.Column<bool>(type: "bit", nullable: false),
                    DocumentReferences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainsSewer = table.Column<bool>(type: "bit", nullable: false),
                    SepticTank = table.Column<bool>(type: "bit", nullable: false),
                    PackageTreatmentPlant = table.Column<bool>(type: "bit", nullable: false),
                    CessPit = table.Column<bool>(type: "bit", nullable: false),
                    Other = table.Column<bool>(type: "bit", nullable: false),
                    Unknown = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoulSewageSection", x => x.Id);
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
                name: "NonMaterialProposalSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecisionDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    OriginalApplicationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalDevelopmentType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonMaterialProposalSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonMaterialSoughtSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubstitutePlans = table.Column<bool>(type: "bit", nullable: false),
                    OldDrawingNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewDrawingNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonMaterialSoughtSection", x => x.Id);
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
                name: "ParkingSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AffectingParking = table.Column<bool>(type: "bit", nullable: false),
                    ParkingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProposalSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasStarted = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProposedUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OneBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    TwoBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    ThreeBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    FourBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    UnknownBedroomProposedTotalMarket = table.Column<int>(type: "int", nullable: false),
                    ProposedBedroomTotalMarket = table.Column<int>(type: "int", nullable: false),
                    Market = table.Column<bool>(type: "bit", nullable: false),
                    SocialAffordableIntermediateRent = table.Column<bool>(type: "bit", nullable: false),
                    AffordableHomeOwnership = table.Column<bool>(type: "bit", nullable: false),
                    StarterHomes = table.Column<bool>(type: "bit", nullable: false),
                    SelfBuildCustomBuild = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposedUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutoPopulated = table.Column<bool>(type: "bit", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Easting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Northing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteArea = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteVisitSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteVisible = table.Column<bool>(type: "bit", nullable: false),
                    AppointmentContactType = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteVisitSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradeEffluentSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisposeTradeWaste = table.Column<bool>(type: "bit", nullable: false),
                    TradeWasteDescription = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeEffluentSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreeAndHedgeSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FallingTreesHedge = table.Column<bool>(type: "bit", nullable: false),
                    FallingTreeHedgeReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreeHedgeRemoved = table.Column<bool>(type: "bit", nullable: false),
                    TreeHedgeRemovedReference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeAndHedgeSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VariationConditionSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChangeOrRemovalReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariationConditionSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WasteSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreCollectWaste = table.Column<bool>(type: "bit", nullable: false),
                    StoreCollectWasteDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreCollectRecyclableWaste = table.Column<bool>(type: "bit", nullable: false),
                    StoreCollectRecyclableWasteDetails = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteSection", x => x.Id);
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
                name: "ApplicationPermission",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPermission", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ApplicationPermission_Application_ApplicationId",
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
                name: "ResidentialUnitsSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoesIncludeGainOrLoss = table.Column<bool>(type: "bit", nullable: false),
                    ProposedUnitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExistingUnitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProposedTotal = table.Column<int>(type: "int", nullable: false),
                    ExistingTotal = table.Column<int>(type: "int", nullable: false),
                    TotalNetGainOrLoss = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentialUnitsSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResidentialUnitsSection_ExistingUnits_ExistingUnitsId",
                        column: x => x.ExistingUnitsId,
                        principalTable: "ExistingUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResidentialUnitsSection_ProposedUnits_ProposedUnitsId",
                        column: x => x.ProposedUnitsId,
                        principalTable: "ProposedUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HousingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    OneBedroom = table.Column<int>(type: "int", nullable: false),
                    TwoBedroom = table.Column<int>(type: "int", nullable: false),
                    ThreeBedroom = table.Column<int>(type: "int", nullable: false),
                    FourPlusBedroom = table.Column<int>(type: "int", nullable: false),
                    Unknown = table.Column<int>(type: "int", nullable: false),
                    ExistingUnitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProposedUnitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Type_ExistingUnits_ExistingUnitsId",
                        column: x => x.ExistingUnitsId,
                        principalTable: "ExistingUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Type_ProposedUnits_ProposedUnitsId",
                        column: x => x.ProposedUnitsId,
                        principalTable: "ProposedUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormTypeC",
                columns: table => new
                {
                    FormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConditionProposalSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DischargeConditionSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeC", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_FormTypeC_AdviceSection_AdviceSectionId",
                        column: x => x.AdviceSectionId,
                        principalTable: "AdviceSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeC_AgentSection_AgentSectionId",
                        column: x => x.AgentSectionId,
                        principalTable: "AgentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeC_ApplicantSection_ApplicantSectionId",
                        column: x => x.ApplicantSectionId,
                        principalTable: "ApplicantSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeC_ConditionProposalSection_ConditionProposalSectionId",
                        column: x => x.ConditionProposalSectionId,
                        principalTable: "ConditionProposalSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeC_DischargeConditionSection_DischargeConditionSectionId",
                        column: x => x.DischargeConditionSectionId,
                        principalTable: "DischargeConditionSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeC_SiteSection_SiteSectionId",
                        column: x => x.SiteSectionId,
                        principalTable: "SiteSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeC_SiteVisitSection_SiteVisitSectionId",
                        column: x => x.SiteVisitSectionId,
                        principalTable: "SiteVisitSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormTypeD",
                columns: table => new
                {
                    FormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EligibilitySectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NonMaterialProposalSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NonMaterialSoughtSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorityMemberSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeD", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_FormTypeD_AdviceSection_AdviceSectionId",
                        column: x => x.AdviceSectionId,
                        principalTable: "AdviceSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeD_AgentSection_AgentSectionId",
                        column: x => x.AgentSectionId,
                        principalTable: "AgentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeD_ApplicantSection_ApplicantSectionId",
                        column: x => x.ApplicantSectionId,
                        principalTable: "ApplicantSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeD_AuthorityMemberSection_AuthorityMemberSectionId",
                        column: x => x.AuthorityMemberSectionId,
                        principalTable: "AuthorityMemberSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeD_EligibilitySection_EligibilitySectionId",
                        column: x => x.EligibilitySectionId,
                        principalTable: "EligibilitySection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeD_NonMaterialProposalSection_NonMaterialProposalSectionId",
                        column: x => x.NonMaterialProposalSectionId,
                        principalTable: "NonMaterialProposalSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeD_NonMaterialSoughtSection_NonMaterialSoughtSectionId",
                        column: x => x.NonMaterialSoughtSectionId,
                        principalTable: "NonMaterialSoughtSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeD_SiteSection_SiteSectionId",
                        column: x => x.SiteSectionId,
                        principalTable: "SiteSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeD_SiteVisitSection_SiteVisitSectionId",
                        column: x => x.SiteVisitSectionId,
                        principalTable: "SiteVisitSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormTypeA",
                columns: table => new
                {
                    FormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProposalSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaterialSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreeAndHedgeSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccessSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParkingSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorityMemberSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnershipCertificationSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeA", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_FormTypeA_AccessSection_AccessSectionId",
                        column: x => x.AccessSectionId,
                        principalTable: "AccessSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_AdviceSection_AdviceSectionId",
                        column: x => x.AdviceSectionId,
                        principalTable: "AdviceSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_AgentSection_AgentSectionId",
                        column: x => x.AgentSectionId,
                        principalTable: "AgentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_ApplicantSection_ApplicantSectionId",
                        column: x => x.ApplicantSectionId,
                        principalTable: "ApplicantSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_AuthorityMemberSection_AuthorityMemberSectionId",
                        column: x => x.AuthorityMemberSectionId,
                        principalTable: "AuthorityMemberSection",
                        principalColumn: "Id");
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
                    table.ForeignKey(
                        name: "FK_FormTypeA_ParkingSection_ParkingSectionId",
                        column: x => x.ParkingSectionId,
                        principalTable: "ParkingSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_ProposalSection_ProposalSectionId",
                        column: x => x.ProposalSectionId,
                        principalTable: "ProposalSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_SiteSection_SiteSectionId",
                        column: x => x.SiteSectionId,
                        principalTable: "SiteSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_SiteVisitSection_SiteVisitSectionId",
                        column: x => x.SiteVisitSectionId,
                        principalTable: "SiteVisitSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeA_TreeAndHedgeSection_TreeAndHedgeSectionId",
                        column: x => x.TreeAndHedgeSectionId,
                        principalTable: "TreeAndHedgeSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormTypeE",
                columns: table => new
                {
                    FormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConditionProposalSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VariationConditionSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnershipCertificationSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeE", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_FormTypeE_AdviceSection_AdviceSectionId",
                        column: x => x.AdviceSectionId,
                        principalTable: "AdviceSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeE_AgentSection_AgentSectionId",
                        column: x => x.AgentSectionId,
                        principalTable: "AgentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeE_ApplicantSection_ApplicantSectionId",
                        column: x => x.ApplicantSectionId,
                        principalTable: "ApplicantSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeE_ConditionProposalSection_ConditionProposalSectionId",
                        column: x => x.ConditionProposalSectionId,
                        principalTable: "ConditionProposalSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeE_OwnershipCertificationSection_OwnershipCertificationSectionId",
                        column: x => x.OwnershipCertificationSectionId,
                        principalTable: "OwnershipCertificationSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeE_SiteSection_SiteSectionId",
                        column: x => x.SiteSectionId,
                        principalTable: "SiteSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeE_SiteVisitSection_SiteVisitSectionId",
                        column: x => x.SiteVisitSectionId,
                        principalTable: "SiteVisitSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeE_VariationConditionSection_VariationConditionSectionId",
                        column: x => x.VariationConditionSectionId,
                        principalTable: "VariationConditionSection",
                        principalColumn: "Id");
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
                    ApplicationPermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_AuthorisedUser_ApplicationPermission_ApplicationPermissionId",
                        column: x => x.ApplicationPermissionId,
                        principalTable: "ApplicationPermission",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateTable(
                name: "FormTypeB",
                columns: table => new
                {
                    FormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicantSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgentSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProposalSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExistingUseSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaterialSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccessSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParkingSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreeAndHedgeSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FloodRiskSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BiodiversitySectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FoulSewageSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WasteSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TradeEffluentSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResidentialUnitsSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FloorSpaceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmploymentSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpeningHoursSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IndustrialMachinerySectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HazardousSubstanceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteVisitSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdviceSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorityMemberSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnershipCertificationSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTypeB", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_FormTypeB_AccessSection_AccessSectionId",
                        column: x => x.AccessSectionId,
                        principalTable: "AccessSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_AdviceSection_AdviceSectionId",
                        column: x => x.AdviceSectionId,
                        principalTable: "AdviceSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_AgentSection_AgentSectionId",
                        column: x => x.AgentSectionId,
                        principalTable: "AgentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_ApplicantSection_ApplicantSectionId",
                        column: x => x.ApplicantSectionId,
                        principalTable: "ApplicantSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_AuthorityMemberSection_AuthorityMemberSectionId",
                        column: x => x.AuthorityMemberSectionId,
                        principalTable: "AuthorityMemberSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_BiodiversitySection_BiodiversitySectionId",
                        column: x => x.BiodiversitySectionId,
                        principalTable: "BiodiversitySection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_EmploymentSection_EmploymentSectionId",
                        column: x => x.EmploymentSectionId,
                        principalTable: "EmploymentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_ExistingUseSection_ExistingUseSectionId",
                        column: x => x.ExistingUseSectionId,
                        principalTable: "ExistingUseSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_FloodRiskSection_FloodRiskSectionId",
                        column: x => x.FloodRiskSectionId,
                        principalTable: "FloodRiskSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_FloorSpaceSection_FloorSpaceSectionId",
                        column: x => x.FloorSpaceSectionId,
                        principalTable: "FloorSpaceSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_FoulSewageSection_FoulSewageSectionId",
                        column: x => x.FoulSewageSectionId,
                        principalTable: "FoulSewageSection",
                        principalColumn: "Id");
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
                    table.ForeignKey(
                        name: "FK_FormTypeB_ParkingSection_ParkingSectionId",
                        column: x => x.ParkingSectionId,
                        principalTable: "ParkingSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_ProposalSection_ProposalSectionId",
                        column: x => x.ProposalSectionId,
                        principalTable: "ProposalSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_ResidentialUnitsSection_ResidentialUnitsSectionId",
                        column: x => x.ResidentialUnitsSectionId,
                        principalTable: "ResidentialUnitsSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_SiteSection_SiteSectionId",
                        column: x => x.SiteSectionId,
                        principalTable: "SiteSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_SiteVisitSection_SiteVisitSectionId",
                        column: x => x.SiteVisitSectionId,
                        principalTable: "SiteVisitSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_TradeEffluentSection_TradeEffluentSectionId",
                        column: x => x.TradeEffluentSectionId,
                        principalTable: "TradeEffluentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_TreeAndHedgeSection_TreeAndHedgeSectionId",
                        column: x => x.TreeAndHedgeSectionId,
                        principalTable: "TreeAndHedgeSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormTypeB_WasteSection_WasteSectionId",
                        column: x => x.WasteSectionId,
                        principalTable: "WasteSection",
                        principalColumn: "Id");
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
                name: "IX_AuthorisedUser_ApplicationPermissionId",
                table: "AuthorisedUser",
                column: "ApplicationPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_AccessSectionId",
                table: "FormTypeA",
                column: "AccessSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_AdviceSectionId",
                table: "FormTypeA",
                column: "AdviceSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_AgentSectionId",
                table: "FormTypeA",
                column: "AgentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_ApplicantSectionId",
                table: "FormTypeA",
                column: "ApplicantSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_AuthorityMemberSectionId",
                table: "FormTypeA",
                column: "AuthorityMemberSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_MaterialSectionId",
                table: "FormTypeA",
                column: "MaterialSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_OwnershipCertificationSectionId",
                table: "FormTypeA",
                column: "OwnershipCertificationSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_ParkingSectionId",
                table: "FormTypeA",
                column: "ParkingSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_ProposalSectionId",
                table: "FormTypeA",
                column: "ProposalSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_SiteSectionId",
                table: "FormTypeA",
                column: "SiteSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_SiteVisitSectionId",
                table: "FormTypeA",
                column: "SiteVisitSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeA_TreeAndHedgeSectionId",
                table: "FormTypeA",
                column: "TreeAndHedgeSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_AccessSectionId",
                table: "FormTypeB",
                column: "AccessSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_AdviceSectionId",
                table: "FormTypeB",
                column: "AdviceSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_AgentSectionId",
                table: "FormTypeB",
                column: "AgentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_ApplicantSectionId",
                table: "FormTypeB",
                column: "ApplicantSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_AuthorityMemberSectionId",
                table: "FormTypeB",
                column: "AuthorityMemberSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_BiodiversitySectionId",
                table: "FormTypeB",
                column: "BiodiversitySectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_EmploymentSectionId",
                table: "FormTypeB",
                column: "EmploymentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_ExistingUseSectionId",
                table: "FormTypeB",
                column: "ExistingUseSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_FloodRiskSectionId",
                table: "FormTypeB",
                column: "FloodRiskSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_FloorSpaceSectionId",
                table: "FormTypeB",
                column: "FloorSpaceSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_FoulSewageSectionId",
                table: "FormTypeB",
                column: "FoulSewageSectionId");

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
                name: "IX_FormTypeB_ParkingSectionId",
                table: "FormTypeB",
                column: "ParkingSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_ProposalSectionId",
                table: "FormTypeB",
                column: "ProposalSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_ResidentialUnitsSectionId",
                table: "FormTypeB",
                column: "ResidentialUnitsSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_SiteSectionId",
                table: "FormTypeB",
                column: "SiteSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_SiteVisitSectionId",
                table: "FormTypeB",
                column: "SiteVisitSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_TradeEffluentSectionId",
                table: "FormTypeB",
                column: "TradeEffluentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_TreeAndHedgeSectionId",
                table: "FormTypeB",
                column: "TreeAndHedgeSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeB_WasteSectionId",
                table: "FormTypeB",
                column: "WasteSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeC_AdviceSectionId",
                table: "FormTypeC",
                column: "AdviceSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeC_AgentSectionId",
                table: "FormTypeC",
                column: "AgentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeC_ApplicantSectionId",
                table: "FormTypeC",
                column: "ApplicantSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeC_ConditionProposalSectionId",
                table: "FormTypeC",
                column: "ConditionProposalSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeC_DischargeConditionSectionId",
                table: "FormTypeC",
                column: "DischargeConditionSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeC_SiteSectionId",
                table: "FormTypeC",
                column: "SiteSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeC_SiteVisitSectionId",
                table: "FormTypeC",
                column: "SiteVisitSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_AdviceSectionId",
                table: "FormTypeD",
                column: "AdviceSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_AgentSectionId",
                table: "FormTypeD",
                column: "AgentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_ApplicantSectionId",
                table: "FormTypeD",
                column: "ApplicantSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_AuthorityMemberSectionId",
                table: "FormTypeD",
                column: "AuthorityMemberSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_EligibilitySectionId",
                table: "FormTypeD",
                column: "EligibilitySectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_NonMaterialProposalSectionId",
                table: "FormTypeD",
                column: "NonMaterialProposalSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_NonMaterialSoughtSectionId",
                table: "FormTypeD",
                column: "NonMaterialSoughtSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_SiteSectionId",
                table: "FormTypeD",
                column: "SiteSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeD_SiteVisitSectionId",
                table: "FormTypeD",
                column: "SiteVisitSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_AdviceSectionId",
                table: "FormTypeE",
                column: "AdviceSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_AgentSectionId",
                table: "FormTypeE",
                column: "AgentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_ApplicantSectionId",
                table: "FormTypeE",
                column: "ApplicantSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_ConditionProposalSectionId",
                table: "FormTypeE",
                column: "ConditionProposalSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_OwnershipCertificationSectionId",
                table: "FormTypeE",
                column: "OwnershipCertificationSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_SiteSectionId",
                table: "FormTypeE",
                column: "SiteSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_SiteVisitSectionId",
                table: "FormTypeE",
                column: "SiteVisitSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTypeE_VariationConditionSectionId",
                table: "FormTypeE",
                column: "VariationConditionSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidentialUnitsSection_ExistingUnitsId",
                table: "ResidentialUnitsSection",
                column: "ExistingUnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidentialUnitsSection_ProposedUnitsId",
                table: "ResidentialUnitsSection",
                column: "ProposedUnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_ExistingUnitsId",
                table: "Type",
                column: "ExistingUnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_ProposedUnitsId",
                table: "Type",
                column: "ProposedUnitsId");
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
                name: "Type");

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
                name: "ApplicationPermission");

            migrationBuilder.DropTable(
                name: "ApplicationDocument");

            migrationBuilder.DropTable(
                name: "AccessSection");

            migrationBuilder.DropTable(
                name: "BiodiversitySection");

            migrationBuilder.DropTable(
                name: "EmploymentSection");

            migrationBuilder.DropTable(
                name: "ExistingUseSection");

            migrationBuilder.DropTable(
                name: "FloodRiskSection");

            migrationBuilder.DropTable(
                name: "FoulSewageSection");

            migrationBuilder.DropTable(
                name: "ParkingSection");

            migrationBuilder.DropTable(
                name: "ProposalSection");

            migrationBuilder.DropTable(
                name: "ResidentialUnitsSection");

            migrationBuilder.DropTable(
                name: "TradeEffluentSection");

            migrationBuilder.DropTable(
                name: "TreeAndHedgeSection");

            migrationBuilder.DropTable(
                name: "WasteSection");

            migrationBuilder.DropTable(
                name: "DischargeConditionSection");

            migrationBuilder.DropTable(
                name: "AuthorityMemberSection");

            migrationBuilder.DropTable(
                name: "NonMaterialProposalSection");

            migrationBuilder.DropTable(
                name: "NonMaterialSoughtSection");

            migrationBuilder.DropTable(
                name: "AdviceSection");

            migrationBuilder.DropTable(
                name: "AgentSection");

            migrationBuilder.DropTable(
                name: "ApplicantSection");

            migrationBuilder.DropTable(
                name: "ConditionProposalSection");

            migrationBuilder.DropTable(
                name: "SiteSection");

            migrationBuilder.DropTable(
                name: "SiteVisitSection");

            migrationBuilder.DropTable(
                name: "VariationConditionSection");

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

            migrationBuilder.DropTable(
                name: "ExistingUnits");

            migrationBuilder.DropTable(
                name: "ProposedUnits");
        }
    }
}
