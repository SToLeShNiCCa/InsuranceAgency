using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Курасач.Migrations
{
    /// <inheritdoc />
    public partial class Ititial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Agents_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Stat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Agents__9AC3BFD1A51891F5", x => x.AgentID);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    employee_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Branches__3213E83FE024473C", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Common_User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Phone_Number = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Passport_ID = table.Column<int>(type: "int", nullable: false),
                    Passport_Number = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Cards_Number = table.Column<int>(type: "int", nullable: false),
                    Users_Login = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Users_Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Users_Mail = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Common_U__3214EC276E91DF7C", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name_of_Messager = table.Column<string>(type: "text", nullable: false),
                    Message_Contacts = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contacts__3214EC27A3580288", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PolicyTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    base_price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PolicyTy__3213E83FD4FC7218", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Version_Update",
                columns: table => new
                {
                    Number_of_Update = table.Column<int>(type: "int", nullable: false),
                    Date_of_update = table.Column<DateOnly>(type: "date", nullable: false),
                    Content_Update = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Version___5546AFC7697D25DD", x => x.Number_of_Update);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    agent_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    contract_date = table.Column<DateOnly>(type: "date", nullable: false),
                    terms = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contract__3213E83F1E331B48", x => x.id);
                    table.ForeignKey(
                        name: "FK__Contracts__agent__6A30C649",
                        column: x => x.agent_id,
                        principalTable: "Agents",
                        principalColumn: "AgentID");
                    table.ForeignKey(
                        name: "FK__Contracts__clien__6B24EA82",
                        column: x => x.client_id,
                        principalTable: "Common_User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HealthInsurance",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    medical_conditions = table.Column<string>(type: "text", nullable: true),
                    coverage_limit = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HealthIn__3213E83F43DE6109", x => x.id);
                    table.ForeignKey(
                        name: "FK__HealthIns__clien__59063A47",
                        column: x => x.client_id,
                        principalTable: "Common_User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "LifeInsurance",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    insured_amount = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    expiration_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LifeInsu__3213E83F2C0D22B8", x => x.id);
                    table.ForeignKey(
                        name: "FK__LifeInsur__clien__70DDC3D8",
                        column: x => x.client_id,
                        principalTable: "Common_User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID_Payment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Clients = table.Column<int>(type: "int", nullable: false),
                    ID_Polices = table.Column<int>(type: "int", nullable: false),
                    Summa = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Date_of_pay = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Type_of_pay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payments__C2118ADE0E433BB5", x => x.ID_Payment);
                    table.ForeignKey(
                        name: "FK_Clients_Payment",
                        column: x => x.ID_Clients,
                        principalTable: "Common_User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    PolicyType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CoverageAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Premium = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Stat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Policies__2E13394422DFE35E", x => x.PolicyID);
                    table.ForeignKey(
                        name: "FK_Policies_Clients",
                        column: x => x.ClientID,
                        principalTable: "Common_User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    property_type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    insured_value = table.Column<decimal>(type: "decimal(15,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Property__3213E83F33F856D7", x => x.id);
                    table.ForeignKey(
                        name: "FK__Property__client__60A75C0F",
                        column: x => x.client_id,
                        principalTable: "Common_User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: true),
                    comments = table.Column<string>(type: "text", nullable: true),
                    review_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reviews__3213E83F7801039F", x => x.id);
                    table.ForeignKey(
                        name: "FK__Reviews__client___5DCAEF64",
                        column: x => x.client_id,
                        principalTable: "Common_User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    mark = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    model = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    year_of_made = table.Column<int>(type: "int", nullable: false),
                    registration_number = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    insured_value = table.Column<decimal>(type: "decimal(15,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vehicles__3213E83F33F7BEBE", x => x.id);
                    table.ForeignKey(
                        name: "FK__Vehicles__client__6477ECF3",
                        column: x => x.client_id,
                        principalTable: "Common_User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "InsuranceClaims",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    policy_id = table.Column<int>(type: "int", nullable: false),
                    incident_date = table.Column<DateOnly>(type: "date", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    claim_status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Insuranc__3213E83FB28608C4", x => x.id);
                    table.ForeignKey(
                        name: "FK__Insurance__polic__6E01572D",
                        column: x => x.policy_id,
                        principalTable: "Policies",
                        principalColumn: "PolicyID");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Common_U__2FB2F31021894295",
                table: "Common_User",
                column: "Users_Mail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Common_U__4DF299E60AFE24D9",
                table: "Common_User",
                column: "Users_Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Common_U__A6C3B540101978FB",
                table: "Common_User",
                column: "Passport_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Common_U__EC266AD93892A158",
                table: "Common_User",
                column: "Passport_Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_agent_id",
                table: "Contracts",
                column: "agent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_client_id",
                table: "Contracts",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInsurance_client_id",
                table: "HealthInsurance",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceClaims_policy_id",
                table: "InsuranceClaims",
                column: "policy_id");

            migrationBuilder.CreateIndex(
                name: "IX_LifeInsurance_client_id",
                table: "LifeInsurance",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ID_Clients",
                table: "Payments",
                column: "ID_Clients");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_ClientID",
                table: "Policies",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_client_id",
                table: "Property",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_client_id",
                table: "Reviews",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_client_id",
                table: "Vehicles",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Vehicles__125DB2A3F4B512EA",
                table: "Vehicles",
                column: "registration_number",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "HealthInsurance");

            migrationBuilder.DropTable(
                name: "InsuranceClaims");

            migrationBuilder.DropTable(
                name: "LifeInsurance");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PolicyTypes");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Version_Update");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Common_User");
        }
    }
}
