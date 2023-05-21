using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class ADdedImgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgURL",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "0df1b1ce-4e11-4550-8255-d1ebbe67544b", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1076), "MKHL3GE45DISYLU7YWXA52O4W2Y2BUDC2OTS7IACZ3UWA5QBXGSQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "ae89c1b0-0270-4a2a-beeb-905c7f611d9d", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1132), "KZDTXOVDOTNJUS74MPWZJPLIGAWXYIET4CEN4QVD55WC4ZRDDRVA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "ba7f551a-562c-47c6-a06f-602da73ffa9c", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1142), "K6DRNNWHPJTJLNA6UKJ7NI4EV4UH4RW6YD4VFFUYQS5OJQZB7TLA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "e83c3b92-75a5-46ef-abaf-d03f07d3123f", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1150), "2COKKSXTDVL4ZUMOXWGWNAJOB6IZBBBXBCTL6OHVNHBN5SFTRKDA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "d6ad097f-3a23-41ac-9b5c-8d47dd662553", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1159), "OJSWGLJ6AIHDRQYOOGPONGKZV4YIDOL2KW5QLPC7UYH3TW63JTYA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "2e15d5ca-1120-49d8-bf96-8fc6578b59a5", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1168), "NBT3IH2DPDNV3YZW3RXWPV7KUIJ5B2PJCQR64KHJFOA7GLWSXBHA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "2caf050e-b2db-43ac-b4ea-eaec6b4093aa", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1176), "RRRWRYK5RSIGCI7DRJ37ABPE54Q4OI2RZ2QPA233H4KKTTANG2ZQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "391403be-658d-4f02-bba9-feabd58b1739", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1185), "OMRO2LRCS2PE2TPMSIPV6HDS3WD7KTZRAL3CGSYSHFTEMMCHQSPQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "82462092-ebde-45b7-8495-299704f30b84", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1196), "QAA6PISJX2XSVNFDBUWUY23YTKPWRMQFA5U45S2CBMQRZRMSVMXA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "a73ddef5-8a38-4e80-b95c-d91ac8665431", "AQAAAAIAAYagAAAAEBJWvZUp+kRvLlIgmwFc1gMaNrZFBJ1mJfcnl0+qluO5yr/OGHDQ2Dlj93exmZdkYg==", new DateTime(2023, 5, 19, 12, 24, 14, 329, DateTimeKind.Local).AddTicks(1203), "PRZWQC3W2LMK5WMXUGJSR6MVBV7TSBV74XTEHNCMKH7MWUKPUSBQ" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgURL",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "7d16478c-80ec-43fe-94e3-07ab13c38cf1", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8453), "YVMQM56ICOUIV5F2OTMNZEU7H5HJCMXINV2OVSATBYNOTQV4LQHA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "36752463-45e4-449b-b456-08ab7afeb9eb", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8503), "YWIHECMCFSWL4BGOB252Z47U4VKFPRKFZ6A4UAZ4GPU6I4QILVRQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "5a025181-5ac6-463a-ac89-86223b236f54", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8512), "NA7K6GWHHX65PQFBVTFFN7OSUOFVAM4JVLQVBODJ6JEWOYC545VA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "0a60cf9a-0cd3-4753-b5a7-a1ff2da7a7a1", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8520), "7HV7D4HPGACVN2LNYY4M62SVYGDTP5FODUBDAZXGVMMTP572XR7A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "28668eee-bded-457b-a357-74bf2069e455", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8529), "MCFK7TKJXNZ3NYJFD4GOCGPM4FCTOG3RN26JIJD4COMHGFXSLBDQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "7f22b9ba-550b-4a7b-ba46-5cf12c6694f5", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8536), "UKU22CFLDWTSV46BP37CLQVBOWMLW4M3I36HBRVDNTP7ZN3DH7LA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "ae454e74-aa4a-4e85-ac28-0a93be9fcb4b", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8554), "Z4GZ6RD6AVH63PUB3AL5LTEDYRVMJGV2T2UWH4I3OL5PD7NGOBDQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "618e149c-aa8a-4b54-8d23-eea6849428fd", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8579), "7234TR6OXKDKU5JGXAZXCTCWCDODEF4BIYOUJCUI4AFCXSPHJ4CQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "89b3e1c0-5507-4551-9211-9314311e7d09", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8587), "CDJ6YGPKEGLGTHRLUH5QNSGMD2UEYXK3SZMZ6TUULH5Y4HQFIXBA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "798de012-b68c-438e-b653-cb2c92a8aa6b", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8596), "5DPYZVILA2FNVUHR4PQWR5ZX4GYRFTTZZDEMGHFUNAA6SRNP3EYQ" });
        }
    }
}
