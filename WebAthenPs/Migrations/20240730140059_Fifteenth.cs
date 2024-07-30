using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Fifteenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua A, 123", "São Paulo", "014ebe22-bc7c-42d2-bfc8-0ae78b855d47", new DateTime(2024, 7, 30, 14, 0, 58, 983, DateTimeKind.Utc).AddTicks(9962), "carlos.silva@example.com", "01000-000", null, "601f6a10-bf39-4228-a6a3-5d62e36145bb", "SP", new DateTime(2024, 7, 30, 14, 0, 58, 983, DateTimeKind.Utc).AddTicks(9963), "Carlos Silva", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua J, 707", "Manaus", "c2a4d6a8-1686-4308-8226-8b8403d43be0", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(152), "claudia.rodrigues@example.com", "69000-000", null, "235adac0-1c7e-4dde-b88e-e7117a60a0f0", "AM", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(152), "Claudia Rodrigues", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua K, 808", "São Luís", "f7d951eb-9923-4d9d-8850-4ba1acdcc00a", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(163), "fernando.oliveira@example.com", "65000-000", "1234567", null, "aa1fad67-206d-40fd-9014-0dfea9117771", "MA", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(163), "Fernando Oliveira", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua L, 909", "São José de Ribamar", "4e050584-948b-44ec-aa33-a892aa321d68", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(175), "luciana.pereira@example.com", "65100-000", "2345678", null, "a6b6a316-a2dc-4d3d-a1ba-708b813cc9ec", "MA", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(175), "Luciana Pereira", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua M, 1010", "Teresina", "055716a9-00d7-4743-816d-9bd225d3d8ac", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(186), "eduardo.costa@example.com", "64000-000", "3456789", null, "7a8a4d70-9330-4cc9-b045-dff59a8383af", "PI", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(186), "Eduardo Costa", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua N, 1111", "Maceió", "4dcb3a90-3e9b-4f59-a11c-6503e40ef2ad", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(196), "renata.almeida@example.com", "57000-000", "4567890", null, "266925bd-04af-493b-8c65-0f0746a6392a", "AL", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(197), "Renata Almeida", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua O, 1212", "João Pessoa", "b573d528-a36d-4836-ba87-09fc2db47d92", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(230), "carlos.eduardo@example.com", "58000-000", "5678901", null, "19ead207-5edf-46ea-a7a5-3bb0b973c7be", "PB", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(230), "Carlos Eduardo", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua B, 456", "Rio de Janeiro", "4ce3df16-586b-4e83-b42b-bebe4256e12c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(60), "ana.souza@example.com", "20000-000", null, "b648bad1-ae28-4768-b246-2f2b56c6879e", "RJ", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(60), "Ana Souza", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua C, 789", "Belo Horizonte", "0e3cd2ed-5947-4e18-8d66-cc2e8c2fe636", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(72), "joao.oliveira@example.com", "30000-000", null, "c42e8333-239e-4502-9a16-09f6d2391c26", "MG", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(72), "João Oliveira", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua D, 101", "Salvador", "9b0788b3-b2f1-41d3-a54e-6d6f2cf04fde", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(84), "maria.santos@example.com", "40000-000", null, "3707f14d-d5d1-4696-ad8c-3979eadc69cb", "BA", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(84), "Maria Santos", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua E, 202", "Fortaleza", "b32219f6-0fab-4855-a33e-45378f48874e", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(95), "pedro.almeida@example.com", "60000-000", null, "649e8ac2-cab4-4d49-810c-72c09039762c", "CE", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(95), "Pedro Almeida", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua F, 303", "Curitiba", "81a44a90-2a99-4819-b840-c628fbf134b9", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(106), "juliana.costa@example.com", "80000-000", null, "9d726bfa-f21c-424b-9830-e5c31de26335", "PR", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(106), "Juliana Costa", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua G, 404", "Porto Alegre", "5d26ab5c-ed6e-4492-9cbb-1ac17104ce16", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(118), "roberto.lima@example.com", "90000-000", null, "98ff433b-7f96-4d63-9db1-872a4968c93e", "RS", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(118), "Roberto Lima", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua H, 505", "Recife", "9002754a-031b-480d-ab41-c2baa6586f50", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(129), "patricia.martins@example.com", "50000-000", null, "84c3dc31-a174-4a9d-9e44-407923e4eb7e", "PE", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(129), "Patricia Martins", "Client" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "Rua I, 606", "Belém", "80e6ad40-c567-43de-b00c-408d0fa2059c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(140), "ricardo.fernandes@example.com", "66000-000", null, "b84c74ec-949f-4f1c-afdc-e59087f099db", "PA", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(140), "Ricardo Fernandes", "Client" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CPF", "City", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "RG", "Role", "SecurityStamp", "State", "TwoFactorEnabled", "UpdatedDate", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user16", 0, "Rua P, 1313", "67890123456", "São Paulo", "7d9074c5-a83d-49d9-b363-558dd9001d90", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(241), "lucas.oliveira@example.com", false, "M", false, null, null, null, null, null, false, "01001-000", "6789012", null, "f0370ec2-5f50-475c-b142-84639179a6b0", "SP", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(241), "Lucas Oliveira", "Professional" },
                    { "user17", 0, "Rua Q, 1414", "78901234567", "Rio de Janeiro", "101f3dfe-2576-4195-8c27-7564f503c5fc", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(252), "mariana.silva@example.com", false, "F", false, null, null, null, null, null, false, "20001-000", "7890123", null, "368f9986-403b-40c2-93ed-432d01e79974", "RJ", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(252), "Mariana Silva", "Professional" },
                    { "user18", 0, "Rua R, 1515", "89012345678", "Belo Horizonte", "aec8a4ed-bc82-4c4e-b83d-61a10cbb330c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(264), "gabriel.santos@example.com", false, "M", false, null, null, null, null, null, false, "30001-000", "8901234", null, "cb4879ef-55c9-44a3-ab11-2a11b07d9944", "MG", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(264), "Gabriel Santos", "Professional" },
                    { "user19", 0, "Rua S, 1616", "90123456789", "Salvador", "80e8bafe-86cb-49c8-919d-b2faed77392c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(275), "juliana.costa@example.com", false, "F", false, null, null, null, null, null, false, "40001-000", "9012345", null, "17843166-3617-4c85-83ce-09188d8b3651", "BA", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(275), "Juliana Costa", "Professional" },
                    { "user20", 0, "Rua T, 1717", "01234567890", "Fortaleza", "86e397d0-86a9-4f1d-9884-5f54f02a5745", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(287), "roberto.almeida@example.com", false, "M", false, null, null, null, null, null, false, "60001-000", "0123456", null, "b83a7cff-3fbf-4a32-b080-de42735afa86", "CE", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(287), "Roberto Almeida", "Professional" },
                    { "user21", 0, "Rua U, 1818", "12345678901", "Curitiba", "37cf6df8-d304-47c9-af82-a663aaee8a58", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(298), "patricia.martins@example.com", false, "F", false, null, null, null, null, null, false, "80001-000", "1234567", null, "73f09d8c-e698-45b0-964e-e3a1b40c5ef4", "PR", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(298), "Patricia Martins", "Professional" },
                    { "user22", 0, "Rua V, 1919", "23456789012", "Porto Alegre", "4479aa32-bd3e-4cbb-bf4b-d344e78738fc", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(309), "ricardo.lima@example.com", false, "M", false, null, null, null, null, null, false, "90001-000", "2345678", null, "f94b4e2e-4c98-40e9-b375-392c8993bb3b", "RS", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(309), "Ricardo Lima", "Professional" },
                    { "user23", 0, "Rua W, 2020", "34567890123", "São Luís", "c373572f-77b1-484d-9cdf-9bf310ca429a", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(322), "claudia.souza@example.com", false, "F", false, null, null, null, null, null, false, "65001-000", "3456789", null, "f577b22f-4b79-4ab0-85f9-d565a8565a8d", "MA", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(322), "Claudia Souza", "Professional" },
                    { "user24", 0, "Rua X, 2121", "45678901234", "Teresina", "65eff5e4-2777-4c52-8ee8-92c9b6267d94", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(333), "fernando.santos@example.com", false, "M", false, null, null, null, null, null, false, "64001-000", "4567890", null, "58d28135-245f-43f0-b173-b115dd02bf07", "PI", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(333), "Fernando Santos", "Professional" },
                    { "user25", 0, "Rua Y, 2222", "56789012345", "Maceió", "7c0be74e-7be8-4abd-abf0-ff6486f2219c", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(344), "juliana.lima@example.com", false, "F", false, null, null, null, null, null, false, "57001-000", "5678901", null, "53105d48-78a2-456d-baa2-0527eef8bb43", "AL", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(344), "Juliana Lima", "Professional" },
                    { "user26", 0, "Rua Z, 2323", "67890123456", "João Pessoa", "35efee7c-ab37-4e30-a781-4c94c36e67d1", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(355), "ricardo.costa@example.com", false, "M", false, null, null, null, null, null, false, "58001-000", "6789012", null, "78891687-ee6d-4220-b3b3-a1dcd5536e11", "PB", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(356), "Ricardo Costa", "Professional" },
                    { "user27", 0, "Rua AA, 2424", "78901234567", "São Paulo", "68384481-50a3-4861-ab3e-4d032f2b1588", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(366), "mariana.almeida@example.com", false, "F", false, null, null, null, null, null, false, "01002-000", "7890123", null, "ec261054-4080-4b9f-a92b-76942823f49d", "SP", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(367), "Mariana Almeida", "Professional" },
                    { "user28", 0, "Rua BB, 2525", "89012345678", "Rio de Janeiro", "88caa875-cc8e-4130-b74c-758bc8afac73", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(378), "gabriel.souza@example.com", false, "M", false, null, null, null, null, null, false, "20002-000", "8901234", null, "6ed44a2f-cf8a-458b-9373-cf571f6fd4ef", "RJ", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(378), "Gabriel Souza", "Professional" },
                    { "user29", 0, "Rua CC, 2626", "90123456789", "Belo Horizonte", "df0ae504-4363-47f9-b1eb-d7d9c5fb4384", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(389), "juliana.rodrigues@example.com", false, "F", false, null, null, null, null, null, false, "30002-000", "9012345", null, "26960c1f-5b9a-489f-bffa-67f0869e015f", "MG", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(389), "Juliana Rodrigues", "Professional" },
                    { "user30", 0, "Rua DD, 2727", "01234567890", "Salvador", "4cb176a1-8c1e-479d-a413-705bf9e29616", new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(399), "roberto.fernandes@example.com", false, "M", false, null, null, null, null, null, false, "40002-000", "0123456", null, "4cd6d7d6-d7e1-42c0-a67a-7eabb0036829", "BA", false, new DateTime(2024, 7, 30, 14, 0, 58, 984, DateTimeKind.Utc).AddTicks(400), "Roberto Fernandes", "Professional" }
                });

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 1,
                column: "UserId",
                value: "user16");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 2,
                column: "UserId",
                value: "user17");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 3,
                column: "UserId",
                value: "user18");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 4,
                column: "UserId",
                value: "user19");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 5,
                column: "UserId",
                value: "user20");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 6,
                column: "UserId",
                value: "user21");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 7,
                column: "UserId",
                value: "user22");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 8,
                column: "UserId",
                value: "user23");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 9,
                column: "UserId",
                value: "user24");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 10,
                column: "UserId",
                value: "user25");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 11,
                column: "UserId",
                value: "user26");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 12,
                column: "UserId",
                value: "user27");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 13,
                column: "UserId",
                value: "user28");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 14,
                column: "UserId",
                value: "user29");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 15,
                column: "UserId",
                value: "user30");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "123 Main St", "CityA", "43ee8865-9456-490d-a23b-e61338f69034", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1077), "john.doe@example.com", "12345", "Admin", "751bce85-f5f6-4593-bd0d-890f0cd73da2", "StateA", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1079), "John Doe", "Residential" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "707 Juniper St", "CityJ", "4a03b176-22f4-41f8-b1d6-c6939ada3da2", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1242), "madison.lee@example.com", "01234", "User", "dcc8860b-0b46-4c67-8844-4430d76d0653", "StateJ", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1242), "Madison Lee", "Commercial" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "808 Willow St", "CityK", "21e79358-0e18-4d9c-b4cd-d235764d488c", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1253), "ethan.harris@example.com", "12346", "1234568", "Admin", "ba557920-3faf-4244-9b8c-22413a24cf81", "StateK", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1253), "Ethan Harris", "Residential" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "909 Poplar St", "CityL", "17bc040b-5a78-41f0-93cd-8fd5bf9b5fdc", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1265), "isabella.clark@example.com", "23457", "2345679", "User", "57fd4bf1-e4bf-4e92-9778-005ac96c0449", "StateL", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1265), "Isabella Clark", "Commercial" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "1010 Redwood St", "CityM", "ef81655a-0a89-4427-9ba8-7b6c8aab8189", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1277), "alexander.lewis@example.com", "34568", "3456790", "Admin", "548c1164-ba42-4933-be0c-9f1e91dbcc81", "StateM", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1277), "Alexander Lewis", "Residential" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "1111 Fir St", "CityN", "503fe4e7-7d05-4e18-9efd-88df5c7631ee", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1288), "ava.walker@example.com", "45679", "4567901", "User", "5371bebb-8245-4e48-906f-8b1cebd350b8", "StateN", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1288), "Ava Walker", "Commercial" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "RG", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "1212 Elm St", "CityO", "2f916b96-d8e5-4c5d-85b2-5ec88464d953", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1300), "liam.young@example.com", "56780", "5678912", "Admin", "8fc97062-2abf-4f7c-a9d7-c1a23701f827", "StateO", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1300), "Liam Young", "Residential" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "456 Oak St", "CityB", "e89267f2-0c4b-4ae4-9af2-cb8c5299a808", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1148), "jane.smith@example.com", "23456", "User", "e6441bc7-12ae-48d8-a9d4-631bb451db4c", "StateB", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1148), "Jane Smith", "Commercial" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "789 Pine St", "CityC", "1cddcbb0-9fed-46fc-863a-7a0b5937c858", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1161), "michael.johnson@example.com", "34567", "Admin", "73014813-04e5-4f89-b159-88d45897a978", "StateC", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1161), "Michael Johnson", "Residential" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "101 Maple St", "CityD", "5a5fc741-4451-412a-bd97-7b23808cae1e", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1172), "emily.davis@example.com", "45678", "User", "59923096-13a6-4fb3-a754-04291661191e", "StateD", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1172), "Emily Davis", "Commercial" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "202 Birch St", "CityE", "19c6b37e-c403-4fb8-acc4-0f67229fa91a", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1184), "david.wilson@example.com", "56789", "Admin", "cda320d2-3b38-43c9-a3a8-535cc5dd5c68", "StateE", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1185), "David Wilson", "Residential" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "303 Cedar St", "CityF", "0ffad964-47be-4707-ba04-e59598eb1320", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1195), "sarah.miller@example.com", "67890", "User", "a4abd29b-d5f1-4041-b586-b29c7680445e", "StateF", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1196), "Sarah Miller", "Commercial" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "404 Fir St", "CityG", "b388425a-29e0-45ff-be83-b1e5cb5f601a", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1208), "james.moore@example.com", "78901", "Admin", "2bd5c7d8-6c61-4842-a426-2a6090528d34", "StateG", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1208), "James Moore", "Residential" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "505 Spruce St", "CityH", "05dde34a-eb41-4ffb-918e-3d263d87d998", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1219), "olivia.taylor@example.com", "89012", "User", "a528d58a-e582-452e-a789-c2518e34b41c", "StateH", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1219), "Olivia Taylor", "Commercial" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "Address", "City", "ConcurrencyStamp", "CreatedDate", "Email", "PostalCode", "Role", "SecurityStamp", "State", "UpdatedDate", "UserName", "UserType" },
                values: new object[] { "606 Hemlock St", "CityI", "b7768239-43cf-49b3-9dd4-03523259ebd5", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1229), "daniel.anderson@example.com", "90123", "Admin", "33e89c13-7e8e-4ecd-a605-54658eec5005", "StateI", new DateTime(2024, 7, 30, 13, 4, 14, 139, DateTimeKind.Utc).AddTicks(1230), "Daniel Anderson", "Residential" });

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 1,
                column: "UserId",
                value: "user1");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 2,
                column: "UserId",
                value: "user2");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 3,
                column: "UserId",
                value: "user3");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 4,
                column: "UserId",
                value: "user4");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 5,
                column: "UserId",
                value: "user5");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 6,
                column: "UserId",
                value: "user6");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 7,
                column: "UserId",
                value: "user7");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 8,
                column: "UserId",
                value: "user8");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 9,
                column: "UserId",
                value: "user9");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 10,
                column: "UserId",
                value: "user10");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 11,
                column: "UserId",
                value: "user11");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 12,
                column: "UserId",
                value: "user12");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 13,
                column: "UserId",
                value: "user13");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 14,
                column: "UserId",
                value: "user14");

            migrationBuilder.UpdateData(
                table: "GenericProfessionals",
                keyColumn: "GProfessionalId",
                keyValue: 15,
                column: "UserId",
                value: "user15");
        }
    }
}
