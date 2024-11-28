using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingProjectStepsIForgotTheReferenceInsideProjecty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProjectSteps_ProjectId",
                table: "ProjectSteps");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9c0747a2-f274-403a-8427-75e9c52bbc31", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(365), "176d68ac-122f-47d3-80c6-67f0e3de3a32", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "76204834-78be-4b79-96fd-007d0e355368", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(663), "7a7abf44-5f21-4584-8366-b280aa621a2b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "41a07a32-9250-490c-96a9-01978644908b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(707), "18c51151-2753-4ca5-9f3b-8a0196842237", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4b9c27cc-f45e-4c5c-a0c1-4ae4ac677c2b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(721), "decd89c4-9393-4abb-be3c-0c6454303dcd", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0270a804-6714-4643-b7de-0642d524641f", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(733), "764e1d81-a850-4b9e-bdb7-6edfa5f93019", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1e4652cc-0a9e-4ecf-9c38-c8c8d41e7cc2", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(745), "f246e02a-0e0f-4408-a385-39307876fc19", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "12e20da1-b75b-4e20-aaf3-a0f5b01ed0bf", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(761), "de9fade7-aadd-40e4-b6fb-ef528eb3f4ed", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4177e6a3-0cec-467d-b6ed-dfc94a2d8533", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(775), "4afe70cd-e969-4545-9659-d49c7d5f96a1", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f5eded8a-8754-41f9-8111-509eb9122806", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(789), "1533fb4c-7a10-46b7-9caf-3effdf5d7247", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9759bee-7e79-4ec2-a17a-ae321000573b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(802), "be6470ab-3a48-434d-8b20-456dd1c55e41", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5f3bffb9-b64d-4382-b285-daaa38c5978c", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(814), "17d490a3-89fb-4872-9b1e-4a5920676597", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c9df1a74-cc94-4237-b456-249bf00eff98", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(516), "8b74b7aa-9306-4595-8a46-028dd8b80b70", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f3cedc7-f1cc-4ad1-854c-b33b8d0f5a74", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(826), "7e0e8786-d56d-42e2-bf89-3a13d8d8432d", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "397dae6b-5756-44cc-a66a-41b1856dc474", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(857), "d1dfd6e6-5d02-427c-9e30-601b331d6f91", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0cd118b2-f9f8-472a-b3e3-329c4a6dd872", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(869), "be24c125-65ed-4be3-b1ba-48192ce2486f", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19a3c0e2-44d8-4587-a1ec-286b23f5d34e", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(885), "515cf714-3c8c-48bf-816a-2d58a583ae88", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e25e6e7c-5601-4f18-b7f7-f135ef5db9a2", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(896), "cd2cde8b-3250-494d-976b-c9f918f97473", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cbf8840a-8070-4bf7-8396-ff0bf21e717e", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(910), "6e134e06-e230-4016-ab0e-e4570f41979d", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d35ee2d0-5f34-4982-9457-79cebf94256e", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(924), "ecd00f35-d098-4a61-a19f-3eabd9751487", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a4edd41f-a643-4fc8-b61f-e6a64b56d728", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(936), "225aaf8d-c557-4e16-8fdd-18283ceb59e2", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f266d003-5ef4-4611-ba6f-7d43e9aebfba", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(949), "8ff160e6-3393-4d91-af11-224d41753b62", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0a76d706-420a-4979-a390-9030c2426cf2", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(961), "b9f6d693-93a0-4079-92f9-66c87328b963", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "710f1a0b-90f2-4fd3-b085-b89ffb6b7815", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(529), "951eed0f-7428-4db9-8ef4-3af3d2dbf1ff", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "28a85ff9-419a-43d8-a933-934533ab8a6d", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(972), "a03f01df-9a82-4dfa-a49a-142403a76ae5", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "91b59584-3bbb-4a81-98c3-9df1960fd590", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(543), "fc757ca3-07f9-49b9-bc47-56b2b8133ce3", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "14294145-7112-443b-af2d-412808add84d", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(554), "41ccefac-edcd-4ca1-b605-e8e4f9d2bb94", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e41a0752-d1a2-4c8c-999e-d3d3fc877bab", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(612), "f0ef98c9-c835-4d0a-83db-40ea3454a109", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1ed02366-c109-4178-bb4c-493bd3cae202", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(625), "f2a0175f-eae4-4c97-8922-23014c7d2aa7", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9f4cc061-96ee-4f50-b21a-4979d9df9bb9", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(638), "93dc3bb1-e6e8-46ef-b937-f9569a2735a1", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb244566-e012-4e78-802b-1004c81f4c9b", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(650), "599327ec-c11f-4545-bfde-ff96332d2a78", new DateTime(2024, 11, 28, 0, 11, 17, 815, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_ProjectId",
                table: "ProjectSteps",
                column: "ProjectId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProjectSteps_ProjectId",
                table: "ProjectSteps");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4b164875-6c3d-4216-8de6-2429cb540a23", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7774), "cf6111c2-ef09-49bb-aa5c-2d21bf14526d", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a9394d94-326e-47dd-b600-fda74c0ecb23", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8042), "5855e4ad-0417-47ca-83e2-b4ee82de8245", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1c71b94-50a0-4693-aa47-9a4dedf29d0d", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8088), "d5d01534-db58-4251-bb94-ae7a50e23f2a", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "12c5af4c-43d9-468a-a5db-d1ee670339d0", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8100), "5c00fd9a-b17b-4eee-aa4d-2cda2a407651", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f495884b-13ec-4fd4-a0b5-81d84b9afa84", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8112), "8bb31c51-ab28-4636-b05e-a69394f8b795", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "25a7c3fc-d76a-4dba-a9a0-fb63fc4a1a98", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8122), "e92bccd2-861d-4fbd-b12c-93709beeda73", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1c97ca11-1a93-4c87-8e9b-7a9217ea9293", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8138), "d6164781-26f3-4f48-965f-901c3619ccb2", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "798243fc-900b-4c5e-b1e6-7427b768c929", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8155), "96f1bcb7-f7fd-41cd-869a-e35767dc363f", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "778792ff-48da-4930-9c41-e266fa7c40a3", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8200), "14755bd8-0fb2-48e4-ac7f-963574a24a73", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a5b1d3e8-cf2c-43b7-b3fb-128dd4ea88df", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8213), "969ffa31-4306-42ed-a362-060820721bf8", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4846ff2e-7e2f-4f1d-901b-f90f2972a627", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8224), "505306cd-906a-43a0-8dcc-fc1d690b9715", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cb4af3fd-9f0b-443b-92f1-a034c3b85bb3", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7935), "df7c80ee-1c1f-4c02-96cb-33079a0bea43", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1a44859f-f974-40ad-9f9c-5a724e710d99", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8236), "eb837bf7-31a5-418d-b837-6873d97055d8", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c25d1ce6-8c5a-4620-a572-8c71de207944", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8248), "77a9286c-f25c-4d05-95d9-d4cc6e9254ee", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5f422a42-d159-43a5-a548-7e596c4d3599", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8259), "26b2b1b2-898d-4c0b-a696-e902340d04dd", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b2807599-ec13-4f26-b8a6-f8ac82e914e7", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8271), "c8694bc3-c694-4129-9b65-fc6cbb2ff37a", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1bd109c-ac1d-4025-910f-fba8fb44f7ff", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8283), "5b637313-8abf-4e26-b7cf-1b29d40b17e7", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "69b6b00e-11c6-43ff-b5dd-608d3d596d1a", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8293), "a9825586-c190-4877-abd1-a0341aa65a14", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "561f57f9-a591-4877-b549-f9a2a9f896a9", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8305), "549eb112-a456-4216-9ce9-c7d5010186c0", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "60f8358d-1de1-496d-8e30-e14a1863ed84", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8316), "7f2512cb-ee38-4984-a3f1-757ea2222d3d", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "af95d710-afa6-4edc-b9b3-46567626002e", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8327), "933b83b5-8e61-4ac1-8da1-0d1b3c90d727", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b90ad0ac-27e6-4bb7-95d4-aaf12472dd4b", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8339), "fae80681-e47c-4719-9aa4-47907c1cc5fb", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1352d887-6466-49fa-809e-c0002d0985fa", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7949), "d52a2bbe-c942-4157-8804-3c1c3397d9dc", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "893e105f-75c3-40f5-a8ee-50979c4e99d3", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8350), "6fd343a5-6903-4651-bc51-a4a42c3391ad", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19b4a14c-3456-4bbe-a7a6-582e79a949dd", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7960), "d90ae0ff-9e8d-4e36-b71f-d49064854ca4", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f14586e9-518a-4319-9ee2-e11e81a47d6f", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7973), "c787270a-ad81-4073-9ff6-80483e3a1f83", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71378ea1-9858-4872-809e-fba959c693ea", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7994), "67efc25b-8a11-4d33-85a7-97f6a7d2fb13", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "31772000-e71c-4472-91c4-fd4211d2585b", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8005), "10494ab6-1915-4849-9bb7-b1cb74530761", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4fc06849-b357-4573-b827-f4f307875319", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8018), "b45df76c-fefc-45c2-a403-f3ccd74326e0", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c94bddd1-962d-4e14-81c0-92025fd84dd1", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8029), "34b4fce6-91ed-49b3-9595-b276f5f2c2d6", new DateTime(2024, 11, 28, 0, 7, 15, 676, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSteps_ProjectId",
                table: "ProjectSteps",
                column: "ProjectId");
        }
    }
}
