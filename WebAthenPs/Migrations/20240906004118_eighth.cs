using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class eighth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("334b7cd1-71db-4291-8540-cc3ea52a774d"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("5630df84-37d6-4ff7-93ac-2a7495599da8"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("8f4a137b-097a-450b-b48d-ebb4fb827ae4"));

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("090501fd-3fd2-4ea8-950c-29cedaef6fbf"), "Residencial", "123456", 1 },
                    { new Guid("1984d0d4-c29c-4819-82b4-183306c27848"), "Industrial", "112233", 11 },
                    { new Guid("cf99ae71-1370-4133-8de8-4d413a4d654b"), "Comercial", "654321", 6 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d767b246-663e-48bf-b4fa-1746b5a47def", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7876), "e82414c2-f2c1-42f4-9101-f4b0340c77d1", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "615d19fc-e210-4166-a3a5-288921ddafd1", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8128), "a2cec6a3-bb3f-4bfa-a7f1-6fbf10542fdb", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "acd60d87-ff96-4ddd-9e02-3edcb826bea9", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8141), "af4ab2a6-0c30-4713-bc96-573120f91995", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5486b4a1-6cb7-4469-8a62-c2c542ea4b8c", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8152), "0529f72d-b379-445d-a28d-e912c3c24437", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "76fba486-dbea-454a-87b2-9eeb0ebdcd87", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8190), "bc55cbe4-bf2e-41b4-a9f0-f215bf374d37", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "938fdb42-b550-4a77-a963-bd26797f2704", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8202), "3db7e89e-7426-4373-acd3-e68783160e59", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f8d6db41-69ee-4564-a70e-d33bbd4dcdca", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8214), "ebba6605-3a88-4da9-94bd-4e190a60c3dc", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "79d117a2-078d-446c-ac74-aad1e9893179", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8225), "b32d3d6e-2347-44aa-82fa-1552f76eb668", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "154a2e49-3c87-4e0d-9708-2b365c3e1906", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8237), "99a345b8-256e-4cfa-9edb-bef12bec80f0", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "412a3dd0-a1c5-472b-9a05-e5dfea268413", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8249), "fcc4a209-1339-4922-a110-a6f1ea60701f", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "25fc5348-1e17-4afa-ab0c-d66de5435a8d", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8261), "7b997001-1d4d-4b6a-a223-9e1bd2a76ecc", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4fadd548-894e-48d3-9d36-ac7d7a8cf227", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7938), "dac8d65e-7fb3-4a4f-abb7-6230721a17d9", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "02814f90-5c7d-4799-a654-0b34bf567a77", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8273), "c1fe179b-c7f0-4409-aca5-077c94b785b2", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c78b8cd6-daed-4dc6-b994-c4a8943381af", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8284), "2867b52d-de75-4279-9f22-b78a8495aa7d", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9efc6edb-c7be-4295-b231-3427ceea8b58", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8297), "77521ea1-c51c-4091-91e3-3f2060eb7771", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6b76bede-061d-4017-b743-fad92ad5103b", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8308), "0837e953-7f6e-43c7-b400-792483f7fc45", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ca6cc24b-21ac-4b28-9ab1-defa93e21e70", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8319), "cc4c95b2-16eb-4412-bab3-8b84a229a4c2", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "adad444f-3999-46d5-92bc-aeabb2666c6f", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8332), "ade0456d-e718-46a4-a17c-f97d786848b3", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2c95d3ae-1807-4a2e-9f8b-1773d0f6d153", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8343), "5c356cd1-5e1b-4dee-a3b6-14a4c458a2e6", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "de66bf42-7daf-40d5-ae83-bbbf1b2514e7", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8355), "dd76251b-0b6d-4359-9a55-f733cd2d57f8", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f65822ce-2609-43e2-9a13-82cc3d15060b", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8367), "b2b05d5e-b695-4cfd-b17d-2e770d3d6cfa", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2259a897-6c55-4c68-a4b0-339e7604563a", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8379), "e00654b7-c444-4829-add4-1ada84c7da60", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f030fed-e4b6-46af-a19f-f4be873fbfb3", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7959), "32bac524-0a1d-48d8-b25b-f962b7b17dff", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e084f658-615f-40d5-a087-4c1fe02d525b", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8411), "375d8fee-3ea2-40c0-9276-0a9174eff0f3", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2d90cddc-eb93-4dec-92f6-6d9b287e2db1", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7971), "ab5c6850-9d45-4112-98d2-51d13e242c24", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "45762f7c-0a8f-4e52-8d4e-3dd3168da462", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7982), "d5215e37-6274-4ab5-8e9b-83b74622981e", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6561905f-7dee-4e58-9198-16a0cea4998c", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7995), "e3e94a2d-9bff-4439-bf5a-123cf94d45c3", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "67395cf2-f533-411d-bf88-df48eba19cfe", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8092), "13306284-e3bd-493b-b1be-fbb7f1e990bd", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf219788-b329-4676-83ad-813fecbeccde", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8104), "8cb7511c-1baa-4a97-9f59-2a103cb1f004", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "18031e90-c430-442f-a552-9ff610c39c3d", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8117), "fe78cf1d-1ae6-49a9-9b87-22e219720fac", new DateTime(2024, 9, 6, 0, 41, 17, 435, DateTimeKind.Utc).AddTicks(8117) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("090501fd-3fd2-4ea8-950c-29cedaef6fbf"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("1984d0d4-c29c-4819-82b4-183306c27848"));

            migrationBuilder.DeleteData(
                table: "Architects",
                keyColumn: "ArchId",
                keyValue: new Guid("cf99ae71-1370-4133-8de8-4d413a4d654b"));

            migrationBuilder.InsertData(
                table: "Architects",
                columns: new[] { "ArchId", "Especialidade", "RegistroConselho", "genericId" },
                values: new object[,]
                {
                    { new Guid("334b7cd1-71db-4291-8540-cc3ea52a774d"), "Comercial", "654321", 6 },
                    { new Guid("5630df84-37d6-4ff7-93ac-2a7495599da8"), "Industrial", "112233", 11 },
                    { new Guid("8f4a137b-097a-450b-b48d-ebb4fb827ae4"), "Residencial", "123456", 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9f86d399-8782-4c86-af51-07b745856e1b", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9469), "37f6b0cd-b7ed-4853-99a0-d1d68abe541c", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d03e4c9a-001a-4002-80bc-ebe74d1ce3ab", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9636), "3a41aa1f-eae9-43a5-829c-80e5e092fc5c", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ba9471f6-b0c2-48b3-ac94-56dd1b66bed1", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9648), "955f55cb-e3b3-47f2-a383-82449e80f8cd", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "899226d1-433a-42b3-b4f9-3665dcdde8ca", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9684), "089815ef-9161-4d4d-9504-34f4c3466379", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e4955fdf-0860-470c-a665-34e18b3f06d3", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9694), "bc17d299-649a-4af1-bc6a-8361dc7ba36a", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2ad21e8-412e-4792-a9e0-2929105f8a41", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9707), "521c8cc5-258f-438d-9a5d-2738e542574e", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bc374244-3725-436d-9193-7cd0830e9091", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9719), "dca3f4c2-2668-4ff3-9173-b0fe1e956dbe", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2f39b7e7-f858-4285-9dde-4cc1a322bab4", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9730), "9d6e57c4-1bc6-4932-a0f0-0f73f8366df4", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "93986e57-9d24-4c67-aad5-91ec54d6aef9", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9742), "be11cf5e-4b20-4dd3-95e1-de2a130ec2cd", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1c47089a-5742-4b02-be6d-e0b84ebeb99d", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9754), "6acc9ba3-cf18-4548-a16b-0d21b2da8c91", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "66c1e57f-555b-4022-bafb-8ea5141a69db", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9766), "22f35837-5203-4d54-9a27-f6cd62d324ae", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7f1cfaa-3f3f-406d-a1c8-4b96e116450c", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9531), "26bd876a-9d31-44c6-84e8-ef58b5ef1d8f", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc76763d-b96f-4913-ac55-652b6e35d034", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9777), "1f8b0ab4-4ae2-4622-9a18-89808a8f6381", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e2421e0f-f6e3-48ca-b59a-c3ea92d7f1a7", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9789), "4a8ba20d-32aa-4dad-b903-8df46fa77af8", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "806fd935-82fb-454a-80f1-8d00fe58bd9a", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9802), "55ad17d6-0814-495f-b58d-f1253c5d2986", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3325335f-049f-49ca-8465-76e44d558f97", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9813), "59dd81c7-22f1-4a19-866e-1187c4334546", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f214892a-d4ab-4252-b56f-f456431c1970", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9824), "0c7aa67c-17eb-465a-a9e9-c23f3319c10a", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "14522e0a-ad0a-4bbc-9f89-923dd8d5aa1c", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9837), "5d182990-2463-46c9-9de6-b16d6d67c6b6", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6270a877-39b3-4460-ae01-f6355885b140", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9848), "50843fb2-c812-416d-9fd8-8b1fdc376a23", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e1c8d772-c5cf-443d-bf0c-f73031277e93", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9860), "1f003e38-1722-4552-94e4-04fa394999b9", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5865644d-466e-498f-8c13-e11a41e8cb7d", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9873), "4977ea0d-7c8f-4af8-92d2-feceeab3a798", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d8b96bc7-8ad9-45ea-95fd-fa89b36a4aad", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9905), "a19368b1-b1b4-47fa-8bc1-7adc74c5688e", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6b2b7809-268d-4f4d-ade4-1bf239192a4a", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9552), "402d3446-054d-4bb6-8aaa-ed1850734282", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2161fc21-d990-4b6c-8aee-2c1d5e6082de", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9919), "6de0317b-1c56-4f19-86b4-3664a0d1f203", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "50062a41-bcaa-4f67-8394-1e7b7a2363a1", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9564), "63d0f1af-afc2-4183-9c89-26327c9079c9", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8cf4e796-fbf9-4700-98ab-bcf0a73e2014", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9575), "0c65c176-0398-4a1d-9e25-e218fb0f6d18", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f7b6422a-9bff-441e-8220-6743666542cf", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9588), "db6ea8c0-e04f-4ee8-88da-63d53964b35f", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f0d58882-0668-47fd-8b3b-d2e2f512692e", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9600), "8a8cff52-d6f3-439f-853c-cc09efa7f3c7", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0e8719a3-6b0f-400f-a17f-39cea095569f", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9612), "4d0da625-dff5-4a2d-bd48-5b566648f821", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1a4c0aed-4a2e-4df3-918b-58bc52785317", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9624), "5e29f8d4-d7cb-4d2f-b135-bf3b503bc2b8", new DateTime(2024, 9, 6, 0, 38, 17, 111, DateTimeKind.Utc).AddTicks(9625) });
        }
    }
}
