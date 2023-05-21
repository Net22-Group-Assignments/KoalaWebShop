using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class movedImgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgURL",
                table: "Reviews"); 

            migrationBuilder.AddColumn<string>(
                name: "ImgURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "779a7cd8-130e-4aa7-93e5-446aed4e8152", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6114), "OYOPO3Q3X7Z3D65G4A5RIJRWMGE2WPMPKPWKT7JIBJF3VG6VJ4NA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "2d518292-ad86-4797-ad33-05ab0047d2db", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6210), "JQUPMFAP5OFMWVEU25IWA7IHY4YG7SQTVDUI7VU3ARUHZBBZPN5A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "73b919fe-426d-4175-be51-8d1e5d123715", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6220), "F33ZIG3LMMNCGSETL2AN4JTJN2657BASY4J72A6NGDOSRBYH5UZA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "25734deb-ae93-4b1d-9ecf-e58065f22c7e", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6229), "622VTMMPQULDRA5V4QQ47HRHIB6HKR5ZHVMHOH3YS5KPK6ESBJOA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "e45422da-ed53-44cc-addb-83bf2b988c58", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6247), "ZO5ERT2XTU2GFEPVJMJNZSPFDLFGVBPA4XWTMGVSU243MZXMH3JQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "ad09a618-48a4-48c7-99da-af493cfc5808", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6255), "RXAPWF6FKIFML4GGSI4RQ3X5YSUD7ZG3NHXRPG4KGJKSGGRX5NDQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "299896ca-c437-4519-8842-f1d3ad229ac5", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6264), "T3YLAN3BGKZG6HU42UUX3HJPJH5SKEF4C24K3KV4VFHSRJFWJEGA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "24fa530b-6e01-4111-8e72-a25e455db50d", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6274), "VDE4J6M7XV2DVQOJD3S3NOKJVBS5NXTG7VRQLR2WWKFACB3BPIKQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "8092b283-c362-4e42-b9fa-2e9fcaca8799", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6283), "UYZME6OAWYCNHQ7ZLW4YGDXRTHSEGZ7TD2IQIKQXIZYSPLJXDCSQ" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt", "SecurityStamp" },
                values: new object[] { "88916175-1e2b-417a-b7cc-c662b00fc072", "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==", new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6291), "XUXRNDZAC5V27IWEWCJZR2STN7TGHINGRNG4KJSRS6AKYL6GWXIA" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "ImgURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "ImgURL",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgURL",
                table: "Products");

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
    }
}
