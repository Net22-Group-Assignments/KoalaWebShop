using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstMidName", "LastLogin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredAt", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 11, 0, "d5235a4c-76de-4116-b96d-832a5ae0e43d", "jon.westman@mail.com", true, "Jon", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Westman", true, null, "JON.WESTMAN@MAIL.COM", "JON.WESTMAN@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9634), "HL6ILB3DGTLX6CWG5FYGORM5HUJ4LZ4GYE6AF354NG54PC6OJFHA", false, "jon.westman@mail.com" },
                    { 12, 0, "8f593cac-f367-4c99-a4c0-593235d5882a", "bjorn.agnemo@mail.com", true, "Björn", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Agnemo", true, null, "BJORN.AGNEMO@MAIL.COM", "BJORN.AGNEMO@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9693), "FJNAYIRVEBW754UEHYOM4PWKOSRZPGCR74S4XOGP3IXVX5D3CVWQ", false, "bjorn.agnemo@mail.com" },
                    { 13, 0, "aa8bf9f4-7a9b-42b6-881c-8681f9808d77", "Oskar.Ahling@mail.com", true, "Oskar", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Åhling", true, null, "OSKAR.AHLING@MAIL.COM", "OSKAR.AHLING@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9702), "YH3AXUDGP2CGMA6LRCVCMP3BSPCK74FRTXCT4WRYTIF7D5NRVYUQ", false, "Oskar.Ahling@mail.com" },
                    { 14, 0, "e1abd513-2a1c-42b5-b41b-d287c2d1984b", "Reidar.Nilsen@mail.com", true, "Reidar", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nilsen", true, null, "REIDAR.NILSEN@MAIL.COM", "REIDAR.NILSEN@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9711), "BEWA3FHZUINAOB64DO22VAFIO3OC24JFGRK7PNPRCZ3MK2UAH5RA", false, "Reidar.Nilsen@mail.com" },
                    { 15, 0, "01140f0d-5e9f-409f-adae-072b706ff55b", "Ina.Nilsson@mail.com", true, "Ina", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nilsson", true, null, "INA.NILSSON@MAIL.COM", "INA.NILSSON@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9720), "5NDAKAVHTA5Z7TAQPTHAQ4MKRVRHKYFN7WVB3EJDCVHGU6LMV3NA", false, "Ina.Nilsson@mail.com" },
                    { 16, 0, "4fbe0493-2aff-4d59-8fca-e0bdd03df84b", "Martin.Petersson@mail.com", true, "Martin", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Petersson", true, null, "MARTIN.PETERSSON@MAIL.COM", "MARTIN.PETERSSON@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9729), "P2SDHRM3GSSWYMKJZW26TJDUB67NI65HRGKAFXNO7DR26MT4PG7A", false, "Martin.Petersson@mail.com" },
                    { 17, 0, "21eab18b-4499-4b34-84bd-a75edc02e471", "Steve.Carell@mail.com", true, "Steve", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Carell", true, null, "STEVE.CARELL@MAIL.COM", "STEVE.CARELL@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9749), "IXT2IZC7XGM26EOG7QIVZLTSARIPCVYOJJIUI56MGOB5FQHM4JZQ", false, "Steve.Carell@mail.com" },
                    { 18, 0, "87b8ff09-9000-4eb1-ae15-5344e43852e5", "Grogu.Mandelorian@mail.com", true, "Grogu", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Mandelorian", true, null, "GROGU.MANDELORIAN@MAIL.COM", "GROGU.MANDELORIAN@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9758), "ZANUQC47CL53SQCBSNWTUNMXJUG33GAOGBWPSZG3EEJSPU22IDYA", false, "Grogu.Mandelorian@mail.com" },
                    { 19, 0, "e6f97042-9953-4f9f-a813-56fdde9dd6f6", "Lotta.Svensson@mail.com", true, "Lotta", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Svensson", true, null, "LOTTA.SVENSSON@MAIL.COM", "LOTTA.SVENSSON@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9787), "26BMRZ7BGRCN2FDEL5SCJN5DHSHBXC7ECBV5J6LLWK3J7MGBSL3A", false, "Lotta.Svensson@mail.com" },
                    { 20, 0, "5531053b-032f-4828-af3a-760e0a3990b8", "Emilia.Ristersson@mail.com", true, "Emilia", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Ristersson", true, null, "EMILIA.RISTERSSON@MAIL.COM", "EMILIA.RISTERSSON@MAIL.COM", "AQAAAAIAAYagAAAAEDyBfyIwQfQLwPgoQ68v7EH1nCheUBVlb85wa50JQygVy061TmdSa3Qfhck3MWfQUQ==", null, false, new DateTime(2023, 5, 16, 22, 44, 18, 791, DateTimeKind.Local).AddTicks(9796), "CLZRZLFQL6Z3LDYLFWCFWQ2NRSPQRVUDKZE2S2YUAX2R3NBNIA4A", false, "Emilia.Ristersson@mail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstMidName", "LastLogin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredAt", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 3, 0, "47171075-2d8e-43ac-8d03-bf94a0d4ac2b", "jon.westman@mail.com", true, "Jon", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Westman", true, null, "JON.WESTMAN@MAIL.COM", "JON.WESTMAN@MAIL.COM", "AQAAAAIAAYagAAAAEK/UHEmz3TwOdGrPRQ96MQ7/nSwAp+2MFMtiBwCJQ6EdI8k037rtW8PFL8vOSFdfXA==", null, false, new DateTime(2023, 5, 16, 11, 35, 53, 553, DateTimeKind.Local).AddTicks(7454), "7YBEG6N75RUNAWOXV54JKAXZFZQY4B6VXBNERGCEQKKQTW6HUHFA", false, "jon.westman@mail.com" },
                    { 4, 0, "2e7fcc50-82de-4cc1-be72-ec0653fba86c", "bjorn.agnemo@mail.com", true, "Björn", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Agnemo", true, null, "BJORN.AGNEMO@MAIL.COM", "BJORN.AGNEMO@MAIL.COM", "AQAAAAIAAYagAAAAEK/UHEmz3TwOdGrPRQ96MQ7/nSwAp+2MFMtiBwCJQ6EdI8k037rtW8PFL8vOSFdfXA==", null, false, new DateTime(2023, 5, 16, 11, 35, 53, 553, DateTimeKind.Local).AddTicks(7510), "HK5CPMWGT7AWBIO3VTTLMRP6BHYR2VIVND2YYZJZXJE6DE77TLBQ", false, "bjorn.agnemo@mail.com" }
                });
        }
    }
}
