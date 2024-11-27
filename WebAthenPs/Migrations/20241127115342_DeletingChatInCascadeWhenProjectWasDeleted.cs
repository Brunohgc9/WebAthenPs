using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class DeletingChatInCascadeWhenProjectWasDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Projects_ProjectId",
                table: "Chats");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1e018f2f-ccf1-4878-a9a6-8c10b85a1e5a", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2632), "756c4f05-a7f2-4d79-87af-4684c002aad6", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0610399a-14d5-47d6-81dc-3f5177721b07", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2880), "bb2a5ae8-c2ac-42db-a01c-efe0c6db423c", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6a8b7042-bbd8-477c-93ff-751fa9a2196c", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2929), "71fe8316-fee3-4c13-a4c5-a059ae01f165", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "76bc4815-0891-44aa-940b-f7347729bb57", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2941), "a1890ba3-670d-4e03-bd58-7c057924f8a6", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "104e69ba-fa20-456b-8db2-677e4bd59578", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2952), "ddba3f56-e44b-4fa1-be42-0c238d99e6a5", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "672b20e8-1a48-4979-a000-dba98a79895b", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2964), "0073c965-6e29-4ca8-8657-69a490b3fb38", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "950c16e6-99b3-429e-9b6b-f26163972416", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2976), "890c17d0-669d-4b77-8001-3d05b2d2646e", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "350569fc-0e61-42d5-bb5b-67878c82d42f", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3120), "401d41aa-a771-4109-b435-8ccedf0fae57", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37cd9ef7-9989-4dcc-9ab0-8eb747019a59", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3132), "be3cabcf-be03-4411-820b-6f4186fba2ea", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "556715d5-6c53-4b37-9280-139289b55295", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3143), "36a16503-7b13-4210-8eda-a9266a033826", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d972ad6e-1f8d-4924-8044-350b9d9a54b0", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3156), "bb5315e8-47f9-4def-9e9b-2a612f663e6d", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d0297304-8e8c-40d0-8e0d-266dde8290f0", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2739), "17267159-37ad-422c-b28b-4c5abbd390b9", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c5fdb524-4d2e-4b27-8a2a-ed14ba878e91", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3169), "cc3790cc-1fd1-4dd5-8402-82ffbcbbd569", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e05e1149-3b8e-4d96-a0a5-25e2175060c8", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3180), "2d807d0c-f068-4ea1-a7c7-1dbc15166517", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5a528189-7d81-46ce-a5ee-c055c27d4b23", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3193), "82bbb07f-6f91-4262-b509-d2ac621b7d5f", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ab224a95-0510-4cbc-bb7a-776d974c878d", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3204), "54e1772f-f672-4793-a475-91a3c8745242", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c699287c-8405-4a4e-aaa8-593aad669725", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3243), "05ecde36-f9cb-412e-a292-2b1cd4f0fdf5", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a19d094d-bb96-4a5d-8fdc-7f33cc6dd8c4", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3256), "725479e5-5ab5-488b-84f9-488f922362e5", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7cabc2c-c814-493c-b09a-ebf1d3fcf319", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3267), "363eae56-d97b-4af0-a770-743a0ee76f5f", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cc7ed453-d960-4b5a-ad1d-a9b55398b74a", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3280), "cd02cdb7-1a98-4379-a59c-233f4841f1f6", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d05816c1-a7de-4445-adac-37fe1bef87dd", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3292), "2e0095ec-73a0-4f2b-baf9-8eed64675e39", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0a4b31da-cec2-4ff6-9ea1-a1c2e30bb26d", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3304), "e7d6c669-9a12-4b04-9dc2-3f3b63a3f2cc", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6dd45197-2aa7-4228-af79-0078a8d7f729", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2762), "3b33a587-8d56-46f4-873e-d3a112c60ad5", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dd2f1620-b7b1-484a-bd12-489f3d62e764", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3317), "6097eed5-c80d-46bc-8575-ccae6d1defab", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "157e07e6-1116-43b2-abf0-78bd9581ef21", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2775), "fc166d31-c021-4f90-89bd-3a61c83bd499", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9692a9b2-560b-4876-b5c6-90ac1236a3c1", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2786), "23c4a91f-f45a-43de-9fe3-423914734670", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a919f27d-c750-4a8a-bb16-2b49715d7ee8", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2805), "490309f5-9d29-47c4-bb78-14c6f4b99368", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "44e266b8-ed29-4471-9d8c-8cbdea44737a", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2817), "89088bc8-eb55-4997-bfab-acafe2f32b3f", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "db092d26-40e1-471a-ac1a-dac1789d0df0", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2858), "d515f9dc-53b6-462a-8ed0-325feabb19d2", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4656fcb2-f56e-426d-b980-1100b7e0652e", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2868), "d3bb1f74-6c81-453d-af2c-083a9ddac40a", new DateTime(2024, 11, 27, 11, 53, 40, 742, DateTimeKind.Utc).AddTicks(2869) });

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Projects_ProjectId",
                table: "Chats",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Projects_ProjectId",
                table: "Chats");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a2b3ce24-f6c3-4235-9b6c-6909f13392aa", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3431), "c091bc3c-cb9b-4cfd-9c07-8ddd5bb23525", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d4cdbcae-f5ca-4fd6-881f-fa02d1b428c7", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3673), "8cafa894-fd20-4b6f-af50-c5a21349bf15", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f91ec773-a8ca-4d5f-8b7b-2db0bc243e5a", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3722), "8dca5a01-200f-44b0-8fb7-2715e870d86c", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "26989f64-9a28-49cb-80d1-4b58a1917c12", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3734), "e062570e-deba-44a2-ab6f-ec73c9a14c72", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f413cc2-8b07-4cd6-a9de-6ef4e760a9dc", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3746), "4d60bdc4-e028-465f-b103-056089b56e24", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "05a6b33a-32f1-444b-8891-0b496569bfbe", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3759), "2f89e941-326d-40ba-93ab-2f744bea5dd4", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a6dc8077-9255-4fc3-a5af-c38023736b4a", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3774), "18c7bcec-6b1a-4adf-8f67-d03054ccbd5f", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3498dd25-a2d1-4853-8c0e-47cf355d8877", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3790), "fd57170d-a373-43ea-a6aa-d9f5c8f0f45b", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "35f81dfd-c14b-4071-ad1b-353a109262df", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3802), "7d9b480f-776d-4955-bc7c-6ddb032ecee8", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "41560e12-a231-4f13-8b5d-59fe60321749", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3832), "c5927788-14c6-4df6-a1ee-17ebc6583767", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4dd52e04-e4e9-4c7b-8482-5274ee811697", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3846), "d183d4c8-304c-4ca7-ac2b-fd81177bbd68", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3f75b81d-2609-425d-87d4-018115fe97aa", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3534), "28f3a4b7-9405-4902-8b7a-40087fff08c8", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4015ed33-461a-4f7c-8688-376f13907125", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3859), "f7ee81ca-3598-4f2c-ad52-075975525b5d", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f803ec40-5d09-4c1c-8dad-4d6c5de98da1", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3870), "6491196b-5505-4f7d-9cf4-81e2ad25d91d", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e44d1a96-ebb4-48cb-b5e3-2382f91b7fce", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3883), "9d256eec-f3d1-4186-89da-5a0ef150268f", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "01cc04ce-2194-4cff-95e6-75cd685ee735", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3896), "b62c46bd-1746-400b-b321-508a8ef31a33", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5d84bb4e-9961-40d5-af8a-b6dffbc02f08", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3907), "a1ee1a86-b65d-4afa-8330-187a99539c77", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "887e0eb2-b130-49cb-81a1-20c87096fdd0", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3920), "44331ddc-8e72-4d48-8472-053cbb517940", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ee43d244-e339-4171-9249-d153d4bd33ad", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3931), "1529ca7a-2800-40b6-bfb3-ce1108357b5a", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b165fa72-7823-4770-9c93-391e14339217", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3944), "156d9536-2b14-4bc0-9ac6-cd93a01ea973", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "16a0513f-f36b-40c3-8f7f-973ab2ae1c4a", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3955), "15a93a98-e3c7-4782-87b2-d8a1a811cb2d", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb3dd514-5028-47d0-844d-ac6a4c12f9bd", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3968), "0be9bf5c-0f08-405c-b510-33c3a26012a4", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4dd6cdac-553e-4c14-828f-a39f367cf49a", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3580), "99375deb-8b35-414f-ad80-14172993fe0c", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d93917c2-550d-46cb-abe6-2f7e0efecad7", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3980), "10ca42f9-82ba-4abd-9441-59a3c8797550", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f84128a9-ea0c-46f0-a555-9ae2b0984ade", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3593), "6da33982-976b-4bf7-8667-fa3d58129546", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4f27628b-7843-4df0-968c-e403bbc8d65b", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3605), "acb48e2a-c027-4cb7-a414-ab154ab9af3e", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0a035808-54b8-491f-8ae7-255fce3abee0", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3624), "b12908d1-a9b6-47cf-9c50-b8980d6afb9b", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "96f0e9fd-941b-40ee-8931-4eba4d866fed", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3636), "1cd1545c-9fd9-42a2-bbf9-36d12cf90193", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5268fbd7-b081-4c11-984b-df325badeac9", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3648), "7e0d81ee-c29c-4dac-b6dd-86e22bfe032b", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "126edcf8-5d79-443c-a18e-018a62b8ac0b", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3661), "f9cd26a9-dd1f-4738-8ed0-3b56673656c5", new DateTime(2024, 11, 27, 0, 45, 1, 210, DateTimeKind.Utc).AddTicks(3662) });

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Projects_ProjectId",
                table: "Chats",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");
        }
    }
}
