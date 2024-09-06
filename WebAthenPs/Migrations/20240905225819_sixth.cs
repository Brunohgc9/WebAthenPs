using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("88ab7c1d-00f3-4635-af57-878e58349ebd"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("f27f329d-8571-4f8a-90ec-d950203f8fa8"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("faa9a6fa-42e4-46c1-a654-ce1176e99d68"));

            migrationBuilder.DropColumn(
                name: "ProfessionalType",
                table: "GenericProfessionals");

            migrationBuilder.AddColumn<string>(
                name: "ProfessionalTypes",
                table: "GenericProfessionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("259f4d97-80dd-4cf1-9047-4146e07666ad"), "Residencial", "123456", 1 },
                    { new Guid("2d1d1a53-4b6c-4788-a30a-4a8020ea8a50"), "Comercial", "654321", 6 },
                    { new Guid("80ee912d-9dc4-47ec-a837-64d7d26e7fe8"), "Industrial", "112233", 11 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "36e37099-4875-45e4-ab99-d7b21274c23a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2732), "750832e6-79dd-4a56-9c82-f858f19bcdb2", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9a5f559e-5966-45cd-9506-bfb489554063", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2931), "837c4e10-db6b-4230-a5eb-bb90d51134a7", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf652324-db17-402e-a1cc-68cefe0c1279", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2943), "ece7d7a5-a852-4cd9-ba73-d51f6050dfa1", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d5274849-5597-40a9-b504-e0b3fefc412b", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2954), "8f3c842e-6fe5-45f7-97fb-8dcac1de8184", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ede134ee-61e3-45f8-a8f1-09a95ab76ba2", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2966), "250e508b-fe5c-4d47-a6b9-272d10fa7de0", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dd2937e8-9dd4-41ae-b640-ee8b22664a87", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2978), "53521165-a8c2-4f0b-a13e-89551365ab21", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "02b13eef-9b13-4000-b9a5-76f3217aa164", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2989), "5516cba2-5e70-4da0-9bf5-6c6d1c3c900a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ffcc617c-654f-4ee3-bdb6-8a88a9d751d4", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3000), "7200c8a3-9834-4a9e-9777-d9ee2fbfe814", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "deded771-43b4-4704-8f98-e8467804a4a2", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3014), "8fff3ef6-4722-4ad2-a92b-7fda7f4b5268", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "09bbb044-c5b1-404e-85a9-73a729e9ae87", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3025), "221d1750-1da9-4307-b908-490350e2dd9a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fadb2f1d-bd8b-40ea-9085-af67833783e9", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3038), "bda62e59-10a0-4e43-901f-ced807869b90", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f9f490ca-17a1-4810-b4d9-4247a14ea441", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2793), "bcf7c457-fb35-4353-935f-ebaa2f2c1ca1", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8fbf1cd8-2622-4f17-9cd8-003131258610", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3078), "742412bc-fccf-4da5-830d-661424258b23", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "116b8c45-7a99-49e1-bce3-8cca6217cecb", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3090), "3092a4d2-d183-4216-af63-3f6b61a3f356", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6ea18c9f-b5fb-48c7-a7c8-be986465c21e", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3103), "2eeddd8b-385f-437e-bcc6-6f75a7ad62a0", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3f31fc61-bb06-4bd4-8532-e75f5e1d502a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3114), "44096433-1801-4936-9d07-e577756ef79f", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "52070d67-22f3-4ebc-832b-1a7bef21b7fb", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3126), "7aa84a4c-decc-412f-b406-77e856fb71f8", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "75c668d5-51d7-41a2-abcf-5bd456ae60fa", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3138), "b29961ac-19a4-4b16-b11b-f269458056fe", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d6a7cb53-90e7-498b-8077-9e2ec57b7d22", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3149), "4d304c1e-9568-494f-9b6c-0b0114184677", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aa72673b-b2ac-4240-81f1-fcbfb0d65c5d", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3162), "e58528a1-0483-4446-a486-63e53e04230a", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "42978c87-3365-4d0f-ae31-6c4903ac13d6", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3173), "95196c81-e9ba-4f00-b444-da195d226b44", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fe16e034-609e-4540-830e-59b4fdd953b1", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3185), "87acb264-7e40-4a8b-b998-874f6d89f80c", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1a31a70b-c5dd-4f2a-bc6c-f0ce17d506d2", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2846), "13339d06-f55d-467d-b17a-3bb43f6707c4", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "199e8393-c178-4a4d-8504-96ce49a41651", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3198), "eab26efa-f6ce-4d2f-a82e-b2f06c8f9183", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b3a8fc7d-263c-4765-8481-96fccba79929", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2859), "e24ddc3e-e304-4fde-b15a-8d45ec318176", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "610e6034-c4ba-4aec-829f-d14ad085081e", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2870), "55034b79-14c5-4889-8856-e7099c631cf6", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3eaf810d-4574-4ab3-a527-8420f3853110", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2884), "4abe9d47-638f-414a-be68-aa69b83407e4", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c6f2214d-c4bf-4b74-bd1f-fb90588d68d5", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2895), "bd2304c8-3d43-4724-af42-ca8f66f755f3", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e841737e-b24b-4141-9e3f-a987a5d0488b", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2907), "fee3240f-e7ba-492c-be44-cef0e68a45d0", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5522eb9b-cfd9-4e5f-a865-f851035c0f24", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2919), "bf54bccd-c94f-46af-a266-53e9a990967d", new DateTime(2024, 9, 5, 22, 58, 18, 613, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfessionalTypes",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfessionalTypes",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfessionalTypes",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfessionalTypes",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfessionalTypes",
                value: "[\"Encanador\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProfessionalTypes",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProfessionalTypes",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProfessionalTypes",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProfessionalTypes",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProfessionalTypes",
                value: "[\"Encanador\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProfessionalTypes",
                value: "[\"Arquiteto\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProfessionalTypes",
                value: "[\"Eletricista\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProfessionalTypes",
                value: "[\"Engenheiro\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProfessionalTypes",
                value: "[\"Pedreiro\"]");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProfessionalTypes",
                value: "[\"Encanador\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("259f4d97-80dd-4cf1-9047-4146e07666ad"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("2d1d1a53-4b6c-4788-a30a-4a8020ea8a50"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("80ee912d-9dc4-47ec-a837-64d7d26e7fe8"));

            migrationBuilder.DropColumn(
                name: "ProfessionalTypes",
                table: "GenericProfessionals");

            migrationBuilder.AddColumn<string>(
                name: "ProfessionalType",
                table: "GenericProfessionals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("88ab7c1d-00f3-4635-af57-878e58349ebd"), "Comercial", "654321", 6 },
                    { new Guid("f27f329d-8571-4f8a-90ec-d950203f8fa8"), "Industrial", "112233", 11 },
                    { new Guid("faa9a6fa-42e4-46c1-a654-ce1176e99d68"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3a010d00-ba47-4a9e-a0d1-c18edc291202", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(569), "3fdeb60b-7b40-43f8-8ded-cfc74f04858f", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "68e3add2-d204-4f68-bd0b-5af3c8d08113", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(735), "8560b735-4494-45c0-865b-da394db9ed9a", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d89a7aca-13a1-4c93-8841-3b4540d026e6", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(747), "0f1089ce-a620-4cea-b5c5-13ea49f3f1c9", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1bbd8cd0-1cfd-42d0-b29c-17f0201eb8ec", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(780), "2bec1fc1-44aa-41b1-a181-24b11a42665e", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "60def7d2-b041-4bc8-98e1-03d30b69096a", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(792), "972c5493-ff6f-4448-ac72-b15073e9aac2", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ed0b18a0-d61c-4efd-bfb2-9c13a2eb2d3c", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(804), "5b14a4e9-6cd3-4851-9779-dccea35f555f", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3631365f-6c77-4895-9f9d-468be02a6123", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(815), "3712efc1-130d-463f-a9bb-64aae0ef4c43", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7bb082d5-97e4-407b-b0d7-fc530eda3f48", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(828), "2e68d62e-1c2b-41c8-b1e6-615f1bfd32d9", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2121f451-c92b-491f-9c90-6f0229b94128", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(838), "f1a3b751-22d1-4d54-9f27-25685aeeb6f8", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "777c8a8b-7a79-44a9-8905-0ee82ced7db6", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(850), "322f6e2f-d0fc-4825-b6a7-68c7844ec36b", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc089b40-f362-481e-9a8f-4252228a59c5", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(862), "1ccac29f-4a44-4b74-b34d-abd6115df34c", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3ce94cef-ff9f-47c9-8ead-524e253bc5f1", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(631), "bd01c1d9-e478-4aee-b40b-554f1d35f3a1", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5843948f-745e-4f42-a7b5-061bed373d75", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(873), "45c39558-9eab-4038-9de7-5060ed27dc91", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bfc9c1c8-53f8-4b3a-a244-c5a7c3052759", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(885), "3dda68e4-5a08-4db5-971f-757b31fab156", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2990beee-786b-4be8-a31b-03772024acd7", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(897), "d28ac616-a4f3-4095-9572-3bfcb3d2966c", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b514136d-8245-4e6b-af25-da56e66a5407", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(908), "7f451972-c26b-45b3-b62a-f9554ab2ea50", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "35361860-dd47-4a81-bd3f-bce2df42cacf", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(919), "710cec31-ad78-4cd6-bfce-ffdf910ae020", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4df4d1a1-4ba1-4243-817a-f240884468a7", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(930), "1ae5fb8e-c588-40d6-bf6c-ca1542857577", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "781a7b20-2e31-4b3b-99ce-2f52a1f570e2", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(941), "32a1936e-10bb-4193-8b57-602237419ae1", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb786475-7bdd-47e3-ab08-dd76abd036fa", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(953), "ac89e6c8-5967-48e5-bb69-05151359140a", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "27237bb3-a829-407a-964b-3bf2e4598037", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(984), "0ef7fe39-8035-413e-b2cd-ef7f002ea095", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "487688a9-7aa3-4db2-b2bc-07a2dca03f88", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(995), "653341e7-0e48-48a4-adb0-e072336ea76a", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "10b2260e-9e24-4880-aa21-59ba5870e0c2", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(652), "f39f1482-64ea-4630-ba50-59c7f1c5affc", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8a1c8b5e-95b7-4357-a8ef-44da1af874dd", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(1007), "048b70ef-22a5-4d74-abd1-6b04a74aaa9d", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b9b7d6e7-8640-437a-bf9e-1d0cdeb74dbb", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(663), "127dc31b-0f6d-4cf7-864d-d5bcf1e5f4e5", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "91b203cf-8d4a-41bb-98e2-95d64ad6b79e", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(674), "e00c65c8-7ab9-43b8-97bb-d063f8dab3a0", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "248bc8ab-b2b5-4950-9f7c-fa9df5b1fbba", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(687), "b6eceb83-cff2-4803-8709-537ff2c26ed4", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "acfbbbd6-e4c8-4142-824e-c324a013d6a7", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(697), "c9563428-b6a2-4eaa-8571-3a840ab6d2e8", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ffe4893e-a2d6-4be4-b5e5-badb0e888571", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(714), "d2339e6c-a4bd-4dd3-b2bf-e02536226274", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "56889661-b54d-467f-8f80-607b9ea32883", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(725), "0d9f75f5-0268-49d0-b2d0-0c89f1ac1c25", new DateTime(2024, 9, 5, 21, 55, 13, 189, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfessionalType",
                value: "Arquiteto");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfessionalType",
                value: "Eletricista");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfessionalType",
                value: "Engenheiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfessionalType",
                value: "Pedreiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfessionalType",
                value: "Encanador");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProfessionalType",
                value: "Arquiteto");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProfessionalType",
                value: "Eletricista");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProfessionalType",
                value: "Engenheiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProfessionalType",
                value: "Pedreiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProfessionalType",
                value: "Encanador");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProfessionalType",
                value: "Arquiteto");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProfessionalType",
                value: "Eletricista");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProfessionalType",
                value: "Engenheiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProfessionalType",
                value: "Pedreiro");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProfessionalType",
                value: "Encanador");
        }
    }
}
