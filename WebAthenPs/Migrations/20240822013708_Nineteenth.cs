using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class Nineteenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "87400767-ee32-42b7-9dae-43115ec60120", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(576), "c68324a8-c5d9-4c3b-806e-2a13f1a8c194", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e076c750-01f8-4c72-9fd9-f0576f0e0a6d", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(762), "4327e9a2-1160-4f47-aa38-fa596b38c794", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "12293a37-57cf-4557-a126-18fe2bdca9d9", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(774), "8376c1af-ab70-489d-af0b-4ad4ade27b8d", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "931eabc9-d868-456f-be3c-c3c3d1042ca0", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(785), "82ddf32b-e629-4e8e-8a36-5f28882d7201", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b53197dc-55ba-4233-bec2-357aaa732f40", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(796), "736a6d57-e8a0-4ee4-80f8-d6c37a767024", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5be78af9-d92b-4700-bf21-1e360730fe80", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(808), "110b8f1b-788e-4449-a47f-e80167b41297", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cf032a86-9d58-4d7e-a623-e613aafa7b66", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(820), "687b00c7-f3b0-45fe-a22a-6d6cf1516e2a", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4bd41121-7f96-4041-801f-8e09208b7bef", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(832), "7611d11d-069c-4d42-9580-2829ff924e60", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9796b7a5-e61b-467d-8592-19b3a8dbcfc3", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(842), "c1c8d4ab-8ad4-4139-8ad5-a3792a0c61de", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1f5089e1-775d-4191-87b2-9d715abf4adf", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(853), "34406b2c-624d-4c9f-82bc-cde1445d0fd7", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dc108575-48c7-4976-b53b-6ef385fbce5e", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(865), "fb3998a2-52f1-483a-8f2c-90950604214a", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "843ddb58-8419-445f-bf08-23573ae69f6b", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(637), "daf7bb55-18bd-4e27-83dd-becbac0f2c03", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "203d75f0-a2aa-47e0-8e04-de74c99d54bd", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(877), "432fd000-c607-440d-9084-238c30d04c08", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f6637374-ce58-4e4c-8a7e-31409da4b267", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(887), "a9321513-f1bb-4154-b4f8-c24fc7c61cb7", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5f38ee8f-9925-4b69-963c-989058f4a806", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(923), "a7147c4e-1540-41d9-baf7-202258e508f2", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c501aedd-c7d4-486f-b3e9-0a9e221bf2fe", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(933), "4dab3e22-0a69-4d34-8ab0-d09c8bf59a60", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fd236e1f-0d68-4e63-8543-ccba4885e4ed", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(946), "a50020e0-abcf-4870-820f-672ebd974bbe", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0eb77c38-d256-4ce1-81ef-30f5f4489384", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(956), "69949803-a902-486f-abb9-0984b5ec474d", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5bb361ba-f0a9-4fe5-b59f-85461e3c8e1d", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(967), "f255b6f5-1db8-499e-ad29-7d6bcdd7d9c5", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "af71ca63-c317-4b0a-988a-189c2de186d3", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(979), "8c5fda9b-91b1-41a0-97b2-d3d213f551f4", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0217b2d1-98de-46db-8961-5940938867ea", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(990), "8d95cb85-600a-4acf-86f6-3dea805e5b2d", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "918830f6-cee9-4148-baac-0d4d616721a9", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(1001), "5738f2ec-7247-47c1-818d-03a0d6634782", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "32fa3f23-ef0f-468e-ad6c-cbbb61d351ff", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(657), "c0ab352e-ad1e-4105-9717-076bf37e30d1", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "70e6f792-a849-460e-ba48-6943f566c4cf", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(1013), "f49fbfdc-03fd-4da1-97eb-0a4c80f4d464", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "54794021-22ad-4766-8cb7-b101518c8784", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(668), "43b6915c-0c78-4a26-be12-3b70486ebeef", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fd1513f1-7ee0-455c-88f3-3a6f8129c06d", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(679), "6386f391-4648-46d9-ba8f-b0f1e585a269", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7bc7f78a-8b78-49ed-919d-718c8a3b9b9a", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(715), "c7392410-c40b-4bdf-a05e-f7eb408ee814", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4dcc8fd6-8b37-4131-a142-462b62f1fd9a", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(726), "300cf8f5-e9cf-4cd0-b7b1-9b47338ca0f8", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0e5deb30-6ac9-41a9-a74a-c54e43db4fc3", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(738), "770bee58-bb85-4e5a-a5e1-01b28426189d", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f2fc6b38-30b7-4556-b1dc-c111ccd1cad5", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(749), "77bc82cd-186a-4424-92ed-7b0c80b7ac4b", new DateTime(2024, 8, 22, 1, 37, 8, 404, DateTimeKind.Utc).AddTicks(750) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f18abf64-0857-4e1d-9c7b-342334f54d57", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6635), "f65be8ef-4cf6-45a9-aceb-5cb35906cb07", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7fdb0cdf-d206-4542-a60a-a6dce53b70da", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6801), "026f33c1-473d-4ba0-9fd0-287008fd2374", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1e3b52df-9412-45bc-9ba0-9b6f49c60008", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6812), "91be045a-2277-4e55-b105-9bf0c5996d66", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "67286777-7ae9-4575-9110-b48c08ee997f", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6825), "988370fc-a46a-4fa1-8d40-67404715bc65", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "799df3ca-19bb-4c09-bc6d-e97869d95e64", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6836), "507e49bc-e65f-4b3d-99d5-efa871e3bf17", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9fe54c4-4ec7-4e3d-a776-02d02f642b2e", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6848), "bd9be48a-2331-4567-8470-7a87c5e853a1", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a4d1af73-e8af-4434-818f-0f46cd61e4ea", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6890), "3561c0ce-6cda-490f-b4ca-7c397684d245", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a02578e3-7d99-4ade-8aeb-c3d378610b91", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6900), "f202c67b-27c6-42ab-8dd4-03090fe13d12", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d8410337-ada4-4bcb-a1a7-be08f1f82ea5", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6913), "69246bb8-9f9a-4792-9a29-244ceefbdd2c", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a9d6b9f1-c942-4999-a079-4cdaacf272ea", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6925), "92cea3dd-5be7-4798-83e3-5d35078c1d8e", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33c50eb5-4d5f-4a33-8bcd-480451431694", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6936), "6a84e486-eaa7-4b0d-a200-43e58909531b", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e23f0b27-d132-4bd4-92af-e2aec8f3f6e5", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6697), "5d87fa3f-42bc-4835-8536-390624d35ac1", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fbbdff3d-cee2-4e28-9223-a0fbf3b1dd1e", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6950), "e13cd4c2-9cb6-46fd-8d81-af7819f1f383", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cb7ebe0b-8807-451d-a60b-0081c4aa8ab8", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6961), "fc172b41-e6dc-47cb-b73b-dc86b0ceb55f", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7ef4315-95f1-4feb-8f1c-744de7cf6541", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6973), "e42714d9-f8a6-4f77-9638-eb2e364b6c6b", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7325bc9c-698c-428c-aed0-e40e5c8cba8e", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6985), "68fbf8c4-e3e9-460b-b7d8-a43388ec3c54", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "215108be-4a44-42dd-915c-a697b1bc9a56", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6996), "fed5bd6d-b135-4943-90b2-7ec4012086a8", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e7bc7108-aa22-41e0-9b44-19de533f013b", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7009), "1d52c55e-e69f-4568-81df-e66323e2e6fc", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8c9722c4-a84a-4a9a-9517-9817ede98b91", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7020), "a53a0ab0-9b9e-4850-bd7f-c54e0463e052", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a9f2fb0a-f7fa-46eb-9843-92f8d478d9ce", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7031), "2ba73a9a-acf7-4941-8d86-5eae837b30a6", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d684166a-289a-4f01-9499-a61a5bed1a75", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7044), "db93dde3-fe09-42b4-88ac-62935be03120", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b06be65f-9529-471a-b33f-cad3fd57ed34", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7055), "fdb2ac12-9d58-444c-9a0f-a66e26b0956d", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fabced7e-bb5a-43b8-bc9c-b70ee8561519", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6709), "ddbd6f6a-fdcb-4101-8b17-6be0eaa09e2e", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "30ece412-6dad-42a8-bf7b-f6ef16546bab", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7067), "1d754eff-7eb9-411b-88aa-fecce1916fa9", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d638715c-3829-4e65-bb5a-98dc424b4b02", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6729), "71abbff5-dc73-47cd-b611-b04173eefed8", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "970a0bdf-de74-4d29-ba66-436142ff6b05", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6741), "e1f0fbc5-9b92-4e7a-a349-7e6e1d5d42b9", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7913f8c5-2580-4c2e-a9a4-684804c1be35", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6753), "497e4efe-ab96-4739-8e81-15608cda5887", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e501f71f-0044-47c0-bb9f-c717594c69d2", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6765), "2cb8cb89-6234-4f8c-bc0b-e27e3102b9a2", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cd488cab-aff9-42f4-a273-0965fe38637d", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6777), "2f275e09-4143-44c8-9ea4-605bd36acdec", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "240bc7e7-4ff1-4652-9bb9-7e6408b44234", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6790), "669135d8-2caf-474e-916d-3bedad4f243c", new DateTime(2024, 8, 22, 1, 35, 26, 19, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ActStep", "Address", "Budget", "City", "ClientId", "ConstructionType", "Country", "Description", "EndDate", "Neighborhood", "NumberOfBathrooms", "NumberOfRooms", "PostalCode", "ProjectName", "StartDate", "State", "Status", "TotalArea" },
                values: new object[] { 15, "Design Approval", "1212 Birch St", 550000m, "CityO", 15, "Residential", "CountryO", "Eco-friendly home", null, "Green Valley", 3, 4, "56790", "Project Omicron", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StateO", "Planning", 275.0m });
        }
    }
}
