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
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "AccessToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    TokenAccessLevel = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastAccessedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    TokenUses = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessToken_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineThree = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    TokenUsed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
                    ImportedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
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
                    table.PrimaryKey("PK_FormTypeTwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormTypeTwo_FormData_Id",
                        column: x => x.Id,
                        principalTable: "FormData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessToken_ApplicationId",
                table: "AccessToken",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorisedUser_ApplicationId",
                table: "AuthorisedUser",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessToken");

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
