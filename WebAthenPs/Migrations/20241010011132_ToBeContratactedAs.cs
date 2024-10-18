using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAthenPs.API.Migrations
{
    /// <inheritdoc />
    public partial class ToBeContratactedAs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ToBeContractedAs",
                table: "Proposals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cecac9ae-43fb-4a02-a739-a396df5a620d", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7139), "69fe7464-42a9-4ef3-a3cb-596dc809ef20", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0895313b-ccda-41c8-8d7e-6cc93f4b9841", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7315), "8c794f9e-cd4d-4a72-8272-56680d7ecf60", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fe310e07-ec11-48d2-a80f-263bff034997", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7325), "d5321898-c158-4b4a-8c66-e560a841f70a", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "86a9f1f0-2105-415d-ad8d-36c81753d53e", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7337), "6c31c1aa-1015-4a1f-a184-fa97b0ab3958", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3bcf042d-71b5-43aa-937f-b385465bacf2", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7372), "1036eac8-1c2c-4f0b-ade3-02e340a70ef0", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3890d944-dd12-466f-ba9a-a82f52d79735", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7383), "73a5b487-f3a3-485a-a477-27ed6b1e44de", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3466e90e-397d-4b58-a1b4-732f5026bbb4", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7397), "a58131c1-3f5f-4139-b94d-be5fe8c85e8d", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3fa22fc5-2abc-41f2-aabc-d5642b39b76f", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7409), "831dacbe-0be0-4d28-a44c-622d976d6121", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c6bfc862-2b6d-41a3-ba05-bb47209f85a7", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7424), "dc104f7f-8bfc-4d08-a60f-71241f41881d", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "75a7682d-3c4c-4867-ad3b-965c9174826f", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7436), "92d0d22d-f368-473f-adc0-27dc5c8f4440", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "37b35cea-bd07-4fab-bebc-7da611672ec2", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7447), "fb0a9808-354e-4ec1-84e0-7f3c2bb21e43", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f78e00d-fe18-4717-b335-172873d60367", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7216), "e85d0991-b8b1-4724-a353-36173b295f1a", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8342aa83-4e1f-414e-90fb-632913c6ae34", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7460), "2193f1b3-95ae-4c15-a2fb-b3fef50e8e48", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5a3f281d-59bc-437f-956f-47a262a6937a", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7471), "89ea4f0d-7dea-469d-bd81-cd536ceb64e6", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4bed0eb7-35b6-4fa8-80c3-2d67c6d2a5b9", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7483), "bc7fd566-a02c-46f8-b6bb-ec6b9aa984d6", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6be423c3-4a3e-44b6-aed8-754c18e6706e", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7496), "23d62002-e965-433e-a5c1-9339fdea9048", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "17773665-e135-4ade-b153-478d233feee2", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7507), "821c52b4-1914-4262-9b78-b0a5ce41f760", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4aa782d6-3bb2-45b9-b7d3-0f44b5687f0a", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7521), "d838698e-4d7e-45be-9d93-eb0a29671ff9", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "97eeb67d-e13b-47eb-8c05-aed686e31b39", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7771), "c3ac6656-76e0-4d7b-aed1-9ef7afb2ef09", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4cf20192-e819-4c5f-b673-d7297756e08b", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7786), "7b3f3b2f-1717-4495-97a7-028cfe4c4976", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3b87fc0e-765b-40e1-a69b-fed44212ae57", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7801), "25273215-9164-4b7a-8b30-2fba8d3223b1", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5431be55-ef6a-4433-b57e-3a1396c611aa", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7843), "fc0f1e98-b38d-43a6-bb6e-8654e3b2f624", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ff06eb67-86a0-45eb-adfe-6b1ac9502a91", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7228), "c847a093-dff3-486a-b789-3797fce9a87b", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "09be54eb-4942-4ab2-b1c1-7682b85a4407", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7856), "6261a3ae-71d6-439e-8bb5-4e96b91be222", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1e71b460-9f79-4c22-ba0c-5f7dca37257e", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7251), "289b4ec7-55d9-40f5-9cea-84a826de9488", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bf353b61-ae75-4b6b-b88d-e531e37a0eae", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7262), "9886bb27-6936-4e4c-a30b-e156ff6116be", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9f2f4e2a-2a6d-45ce-8623-b8ce811e113f", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7272), "587a7269-8432-4adb-835d-5ffd8b770b44", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a7c9fd55-500a-4f68-a71d-70f05d9079a6", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7283), "a6d0871f-b289-4986-b161-36fbdd87ad8c", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "43b6daa8-a334-4d9d-887d-482af67bd08e", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7293), "a1a13382-e2c8-4805-8622-286587f23a35", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9bd3c361-492e-4749-ad01-cfc62530d975", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7304), "750197de-ea82-420c-8116-cd9f12ab7115", new DateTime(2024, 10, 10, 1, 11, 32, 360, DateTimeKind.Utc).AddTicks(7305) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToBeContractedAs",
                table: "Proposals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5104fbc6-bc64-4ac7-812b-313d3d99bc43", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4612), "f5939e7d-a2b0-4029-833d-04f2d686bdbd", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bdb9fd00-a20c-4499-a978-933edbe99488", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4864), "49246644-58bb-4d9d-bed9-46285d2bec5e", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b2db3caa-3974-4650-9465-232c91b5c22a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4910), "a6a75136-22a3-44b5-ba27-5859db1181a8", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e1d29d25-373c-4124-a8ea-460c39ef313a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4924), "8375c360-8cae-4624-8e14-69bd27b5369e", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "90c21d0c-b3ef-454e-a1b9-1b55770456eb", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4935), "7faca28e-1d11-4af6-b464-8e406b288a4c", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c82b07d8-76b0-4d5c-8f32-e6345a208a0c", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4945), "63fc46cc-52ed-40a7-8007-ff26f76c6191", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "85c14b03-8404-42f2-b991-cdb0c1c4e928", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4958), "4f9f8188-d1ac-469d-b1e7-5dd37b8f7b30", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "81d32f52-06f8-4921-8a25-3034ff7178d6", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4987), "845933bd-7d0a-4f2b-8799-765f0836d45b", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c7b66d32-1391-4e68-a127-171f58b890a5", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4998), "513a11a5-9b19-46fc-b4a5-4f889f548f3a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ebf6f39d-f7e6-47e0-88a1-1afda4b86b0a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5010), "0d56d958-e704-468e-9265-f42e3fe6290e", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "69831873-2bb2-4bd4-a59e-652c92c860b7", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5020), "12610df4-acfe-4d79-8dfe-b431108130c5", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f5c83c0-25ee-4604-acf9-bcd96c32e027", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4728), "d8969944-b5d6-4328-bf0c-39243d417023", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c09e6f3e-0a6d-4b54-a1b0-2a49827301cc", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5031), "a2a8d4c0-8be6-449f-81e1-b6b44882fd93", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4654b477-4ddf-44fd-b5ac-ea46c5ecbc5a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5064), "838bfc57-0007-4c9f-b607-29abb44adfa5", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c4ff36c5-f2a4-4f55-8053-7301d6c5612d", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5075), "346c9cc2-cbac-4bd0-a56c-79ef64ac9781", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f3db793-e45f-47f5-a385-92007669759b", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5087), "8583a46a-3021-4b75-a514-4708e8f14112", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c31e1e97-8160-48b8-be5e-40218f428c58", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5098), "7e6b0b40-64f4-41ff-8b5f-3ed7dd9eba6d", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "272cdc42-3b0c-4400-8b85-c027a2718e21", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5108), "5564b801-fae9-47c6-85d1-7f9dfeef7b37", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b5368c8-e9b9-4adc-b08b-e0090f7e6cd6", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5120), "62cdc326-7492-4f1e-8a3a-e2c9bd1f2b4a", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4d5c3c3e-d07e-446d-a71f-0b27cbcb4114", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5131), "4233f03a-c1b6-4a6a-bab7-34d3f499bcf3", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f06ad35c-9193-4e1a-84d2-91ea9d55a559", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5144), "a84cd1c2-3491-4d00-8b6e-34d85d5fc5db", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ca776b70-7fbd-4e66-bcc9-36587222425f", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5154), "33a7e192-f1df-4c6f-9d11-8cef43d179ec", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d262ef97-846a-46f8-ae77-fa911de4a650", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4740), "42588ae3-5b94-4fa2-be22-832273ae83a0", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f76195aa-ef0d-404a-96ff-dd8fd1142fdf", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5164), "9e286f9a-7140-4d35-91d0-ee1cfec4d0a0", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3e72e3f6-4fea-4656-9ca3-7d65becb1c66", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4752), "22db6cc9-b654-4d1c-89fc-9e382984ba93", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1136c1e2-0fed-45fd-a0a5-a3541826e638", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4796), "803cd0e7-609e-4d27-8b8e-0a1c14fcba85", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "13d5b448-09cf-4cc6-9877-e8bf39bbd44f", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4815), "4907dd08-be6d-4f63-8d33-1040f4884eae", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f2e06938-63a9-4b7c-a483-395b986b2181", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4828), "4f5b94c2-f068-40a8-9b3d-1cd45e9a70ce", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ad5b852e-e683-4305-9b0d-6f01addaca60", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4841), "a1543945-dded-45a9-9fec-007da0b7d317", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1d9ec50f-78cd-4031-9d4d-01834c4ea2df", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4852), "939661fa-4b80-46ab-9b48-d5e08858369d", new DateTime(2024, 10, 9, 21, 47, 28, 233, DateTimeKind.Utc).AddTicks(4852) });
        }
    }
}
