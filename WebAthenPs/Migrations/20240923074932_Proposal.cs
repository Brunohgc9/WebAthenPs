using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Proposal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proposals",
                columns: table => new
                {
                    ProposalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProposalMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProposalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProposalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposals", x => x.ProposalId);
                    table.ForeignKey(
                        name: "FK_Proposals_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proposals_GenericProfessionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "GenericProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e3538538-12ad-4932-99bd-040e688669c5", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(1935), "9def778a-c77c-4577-b93c-ad1cde7adda9", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "57491d8e-5c0a-4751-83b3-3619ad36db6c", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2105), "82a04fc7-3c2a-4072-b3ea-1487411620e1", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "141e206f-5cd4-46de-88ea-d6ffbb5fd07f", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2117), "f94e7a92-ce95-494a-b98c-0288522b171d", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ea4a06b9-2b6c-45f1-b1ac-0cb583a5167f", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2128), "0dfcbdfa-5b55-4803-82b3-b78c0bfdf9bc", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "eee28990-cb51-44ee-a34b-1f84b5e0680f", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2140), "2098ed1b-84f5-488a-8fe0-ab073c6ca55c", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5e0af002-31d3-43ee-b947-a2ed4539933b", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2171), "900ea0a4-5c05-4320-8b55-89c22191e72e", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c2a7f8f1-d6dc-4881-8f7d-49a40dfc3897", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2182), "23faa74f-2b60-4c76-bfad-23f2e87dd6bf", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fe7a52e2-31bb-4e10-8251-2b9467ca9ab5", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2195), "017f7279-ca0e-4874-9a11-af9b801b9bc7", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9cb1503d-f13d-4990-bd2f-141cc87e7f6e", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2206), "dc9ce0d7-73f5-4359-b021-c275a59749ba", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6780a5f0-b6e2-40c2-9caa-4e6ab1a271b4", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2217), "c6a05128-769a-4671-99c4-e4948381ad46", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "afec7f67-fd57-4876-b8af-6ea76faa4c8a", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2231), "43ee610a-ddaa-4d08-b2c5-f8e3063a515d", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "adbe1407-e3a8-4ea4-9784-8a8310dede58", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2002), "596f5b60-ef34-4057-8773-f26ead5c33e2", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2819fa7c-7ab0-4f2d-ba9f-05388856410b", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2242), "6343a7a0-05e0-4054-a8a3-f0d73b892a15", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "59132cf1-a60e-4bb4-a954-b3eaca0538d9", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2253), "c29f7f21-f94b-42de-aec3-9749aa158c1e", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "11356d8d-6014-4f4a-8816-dd389c3b4d84", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2266), "e259c343-44e9-438e-bfd3-cb9601ee6b8c", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2aaa6369-2b6c-4c81-9ad0-b92375639565", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2277), "94ab2162-a5f9-4639-8949-140074c68035", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "451fd2b0-0e5f-42e8-b12b-a3b11c2ffea4", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2291), "43a262df-825f-47ca-8b2d-c690f626b728", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c548140a-e5fb-4489-a5af-2fabd2e5f6e8", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2302), "b168fb15-5fd8-4622-b303-7de4d0c90dc4", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "244774c2-a74f-444a-9b6b-883c07ab83aa", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2313), "4c2f8cc0-639e-4c49-ab79-d6999d54ad10", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9b21f488-ce7a-42c8-a500-22ddc1952808", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2326), "1846375c-8bc3-4ffe-bf3a-b429d2e5808e", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d690d075-ffeb-4ddf-bd78-bbad8894e92d", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2337), "27704980-83ed-483d-8667-5732e94d672e", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ac37f0ec-f2ef-4ebd-a905-9727e66e8418", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2433), "307f0802-7eac-4e22-9d44-2e8285d4c73e", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0081d5da-64cf-4aa3-a173-5405ee76fcc7", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2022), "694cfdea-d502-44e8-9708-6314b62b24f2", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "292c4a1e-dfa6-4160-bd07-298a0aa21bd0", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2485), "f6ad06f2-ecef-4d3e-aee7-d6111118cffe", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7afba68e-0fd3-4dbc-a648-a99b32f1035d", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2033), "5af4c8b6-d84b-4ee9-b1e4-26a6bfb81459", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a51ec611-a9f1-4fc5-b9fe-519c97f9bb9a", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2045), "97d862c0-2def-494b-98eb-3d0d052c834e", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7f980ab8-6018-41e5-bcdd-add676e899ea", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2058), "8283254e-8e52-43fa-8b99-0b680fea577b", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20120c58-7ed3-41e4-9f54-e3fdf4f9ee8f", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2069), "550de637-7016-41c9-8d68-14464d19a54c", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b89d5aed-8102-4f11-95fe-4f4d45cf3b59", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2082), "3bae0137-2837-4634-917e-b5d2dc9d53c2", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7d835a7d-24a5-43fe-b3ae-88ed09c5f13f", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2093), "6a47be8e-7141-4e99-839a-7c2070eb8004", new DateTime(2024, 9, 23, 7, 49, 32, 148, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_ClientId",
                table: "Proposals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_ProfessionalId",
                table: "Proposals",
                column: "ProfessionalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proposals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "24243f13-033a-4414-b380-59b548cce213", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5374), "c8685eba-6b1d-4cec-b303-eefe4c5f8684", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c36ed8e8-0af2-43eb-88cc-0db2a2d5ff67", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5607), "55f3c44a-431e-4eb8-9f97-b525d9520b38", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e0d5cbc8-150b-45d8-8995-6cda63bb0357", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5644), "14454056-a5e5-47bc-ae5f-d9571cb26bf8", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aacbe03d-9ac4-4d58-a8f8-6627be750648", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5656), "64cc40d0-50fc-46e1-b5d0-6dd8474a81bc", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d135cbb0-8fe2-4116-8bb5-f0fff3fbd091", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5672), "257d8241-cf51-4cbb-85f1-abe5e9a91c80", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "364d1df8-6baf-4a11-bb5d-87b593d6b44d", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5684), "9ec39f1e-2be8-471c-81f0-620329876cd3", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7b5f745c-be15-4daa-9511-fa8bb751fe4c", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5697), "9c7f9e7a-6517-4cbc-ba66-7329fc34c008", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fab8715b-3ca7-4e8d-894b-795a6dc71fc5", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5722), "ac397025-4d35-4b1e-946f-dc762b862d87", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9af55619-ac31-41f6-b205-75b3847953f3", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5734), "cf094c38-9da9-4d69-872e-343df90c4b73", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c7006bfb-e8c0-4b04-b8e9-33cb9c09232a", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5747), "01e268d2-0585-41f6-947a-80aeb7d5bf0b", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db17e84a-7814-4864-b836-a816849732fa", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5758), "59356e6d-d377-4891-ad28-0c1728aedaf3", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f8668cff-e13f-42a3-b34a-852c3c339e0e", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5463), "a638292c-ba2c-4e03-8deb-d2b5ced39d5e", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c413b900-d12d-48d4-968e-b2e5b7cf8361", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5769), "a7c7bc3b-f27a-41cd-8cb6-8e0c914eb2df", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9995ef73-83c4-4dd4-8080-7041ba6de4a7", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5781), "905f3750-cf90-4474-8877-85ca01f98366", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7a2c214c-9197-4348-be82-5fd8564e1726", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5793), "e03ecdf1-92cd-4f2b-b37b-9fb80cb37d3d", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1ba2a3d-1d27-46ec-a57f-21d6751acb40", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5804), "da1b6ab9-a81e-4dc2-949e-25711410f9e0", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5a84026e-4fe0-4777-b6c1-5524bd20c255", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5846), "dbf9ee0f-ce79-4695-9e32-5c47d8ec983a", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8a6f3cdb-d894-4537-9b24-64b3f6bdc3a4", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5858), "adf5bfb2-ab15-4b42-a410-dcfe9e0044a8", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5b5563cc-ba65-4615-beb0-fea9bfd2a3f9", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5871), "de8db9f8-a4ff-438a-a48c-06b752de0140", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ba8644f8-a3f3-498b-92b8-81c0ef48720b", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5882), "9499c777-4551-43f9-aac9-633d9c1b44d1", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c85ac9fa-a33a-4c62-881b-86d659fca0bf", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5893), "bb1f4395-0abe-4d81-8a85-87f3ea31e8c2", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2bb36310-11f8-4095-86b9-3a1a5244405e", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5905), "f74af61e-9691-4d0d-8c54-746065e8a060", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fe94a6f0-1ba6-499b-8d60-74aa4ad748cd", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5476), "295d1089-10f7-434e-9def-7fc2cbadcbe9", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f8bc05a6-4ae8-4553-a8c8-2a20a24d2545", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5916), "7b3520f3-4785-40c8-a4ca-f115076aa15f", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7491cc9c-1004-4ff3-92cf-67ee53e8eea2", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5489), "b49edc4f-4e5c-4ef4-8c16-b958821bb303", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "43c56d08-6912-4f5a-b522-b1755c056aef", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5503), "eb885118-a336-49b2-b25c-ed86cd3c6313", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7b05c955-0721-4807-95b1-ca24e3035827", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5520), "99fe2103-5551-4783-b8bb-59f9331f9589", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "85210c0d-9c1a-43f2-a006-c0b02a11046b", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5531), "bce5557a-b3c7-48a8-ab02-6dc31b96fd50", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a6d6a238-3fab-4d7e-9c19-01dc5bfe8bed", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5581), "979c7f77-cd54-48a2-b1a4-47cb8208e984", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6d7f71c5-329d-4265-83c8-2c3160b97655", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5594), "df252103-232f-4af9-84ec-8cb9538ff958", new DateTime(2024, 9, 18, 20, 27, 2, 89, DateTimeKind.Utc).AddTicks(5594) });
        }
    }
}
