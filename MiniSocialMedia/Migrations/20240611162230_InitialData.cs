using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniSocialMedia.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Username" },
                values: new object[,]
                {
                    { new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"), "EchoSpecter" },
                    { new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"), "SolarFlare" },
                    { new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"), "LunaEclipse" },
                    { new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"), "NovaWhisperer" },
                    { new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"), "StellarWanderer" },
                    { new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"), "PhoenixBlaze" },
                    { new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"), "AzureSkywalker" },
                    { new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"), "CrimsonShadow" },
                    { new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"), "TwilightSeeker" },
                    { new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"), "MidnightRider" }
                });

            migrationBuilder.InsertData(
                table: "Follows",
                columns: new[] { "FollowId", "FolloweeId", "FollowerId" },
                values: new object[,]
                {
                    { new Guid("046597f2-022b-4410-bf14-fcde493714c6"), new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"), new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b") },
                    { new Guid("05b56d7f-ed44-4d58-9bf9-b884bb9d32a5"), new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"), new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b") },
                    { new Guid("05cf48f1-3f91-4eee-899c-491771b2d1b8"), new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"), new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86") },
                    { new Guid("0bb1a3a8-7a0b-4fe5-b5e4-62cf4505965b"), new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"), new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688") },
                    { new Guid("1e52ee4a-52c9-4619-9140-02e47678e998"), new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"), new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3") },
                    { new Guid("234ce2af-d775-4637-a1f7-b3d4948c3a61"), new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"), new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b") },
                    { new Guid("324f90c5-00aa-4189-a7c5-210952822263"), new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"), new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0") },
                    { new Guid("33e4fdcd-fa8c-4598-80d9-ef02169f2c3a"), new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"), new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0") },
                    { new Guid("43fd0e11-9ec3-412b-949d-78cd82908b11"), new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"), new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897") },
                    { new Guid("44f23e8b-f0f5-489c-97de-4616de7a0bce"), new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"), new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3") },
                    { new Guid("833d692b-7513-4edb-b39e-db0b4af3445b"), new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"), new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b") },
                    { new Guid("a0333ea4-2df9-4f59-b74d-b470ee7ee06a"), new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"), new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b") },
                    { new Guid("a84df130-eca5-4e3a-bb12-ee9e6f6777da"), new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"), new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688") },
                    { new Guid("aaa27bfd-ac48-4483-afab-be59776dd0f3"), new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"), new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14") },
                    { new Guid("b402fe59-71a2-471e-8a0e-f22543e22ecb"), new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"), new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897") },
                    { new Guid("b55242a2-d821-460c-b6d7-e2a401e3809f"), new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"), new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3") },
                    { new Guid("cda2238d-6554-4a6d-84f8-c2196e8f3460"), new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"), new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86") },
                    { new Guid("f0ec6eda-2d99-433f-b761-8a1192214e5a"), new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"), new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b") },
                    { new Guid("ff96eebd-eb32-4b59-ab86-03d7025581ac"), new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"), new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14") }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CreatedAt", "Likes", "ModifiedAt", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d1e786f-53c1-4b76-8a6d-32a47ac70845"), new DateTime(2024, 6, 9, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9211), 0, new DateTime(2024, 6, 9, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9212), "Duis aute irure dolor in reprehenderit in voluptate.", new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0") },
                    { new Guid("0f60bba2-6480-4c89-b46e-8470d62d7c87"), new DateTime(2024, 6, 11, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9214), 0, new DateTime(2024, 6, 11, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9214), "Excepteur sint occaecat cupidatat non proident.", new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b") },
                    { new Guid("1a38e76d-6834-438e-b89e-1eae1ecb0a72"), new DateTime(2024, 6, 3, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9174), 0, new DateTime(2024, 6, 3, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9175), "Ut enim ad minim veniam, quis nostrud exercitation ullamco.", new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3") },
                    { new Guid("292f0ff3-5ff3-4b15-85a2-9bb97b08ec22"), new DateTime(2024, 6, 6, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9204), 0, new DateTime(2024, 6, 6, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9204), "Lorem ipsum dolor sit amet, consectetur adipiscing.", new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b") },
                    { new Guid("5f9c37e3-06b6-4a3e-b728-7b2c7e2aebf4"), new DateTime(2024, 6, 1, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9164), 0, new DateTime(2024, 6, 1, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9168), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3") },
                    { new Guid("b5d54b1e-99d7-4b1d-b8da-9c8f4cde7a9e"), new DateTime(2024, 6, 15, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9206), 0, new DateTime(2024, 6, 7, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9207), "Sed do eiusmod tempor incididunt ut labore.", new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688") },
                    { new Guid("d10f6b89-cc26-40b7-881f-8d97b7bb9309"), new DateTime(2024, 6, 8, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9209), 0, new DateTime(2024, 6, 8, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9209), "Ut enim ad minim veniam, quis nostrud exercitation.", new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897") },
                    { new Guid("d9a32e19-48f2-4b4d-b62b-1d5509b18d2d"), new DateTime(2024, 6, 4, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9177), 0, new DateTime(2024, 6, 4, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9177), "Duis aute irure dolor in reprehenderit in voluptate velit.", new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14") },
                    { new Guid("e9fbf5a4-985c-4f16-ae19-3a6788f8900e"), new DateTime(2024, 6, 5, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9179), 0, new DateTime(2024, 6, 5, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9201), "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim.", new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86") },
                    { new Guid("f6c96d6b-3f45-4728-afd3-2ee9ef1d8ab8"), new DateTime(2024, 6, 2, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9172), 0, new DateTime(2024, 6, 2, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9172), "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("046597f2-022b-4410-bf14-fcde493714c6"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("05b56d7f-ed44-4d58-9bf9-b884bb9d32a5"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("05cf48f1-3f91-4eee-899c-491771b2d1b8"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("0bb1a3a8-7a0b-4fe5-b5e4-62cf4505965b"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("1e52ee4a-52c9-4619-9140-02e47678e998"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("234ce2af-d775-4637-a1f7-b3d4948c3a61"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("324f90c5-00aa-4189-a7c5-210952822263"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("33e4fdcd-fa8c-4598-80d9-ef02169f2c3a"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("43fd0e11-9ec3-412b-949d-78cd82908b11"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("44f23e8b-f0f5-489c-97de-4616de7a0bce"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("833d692b-7513-4edb-b39e-db0b4af3445b"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("a0333ea4-2df9-4f59-b74d-b470ee7ee06a"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("a84df130-eca5-4e3a-bb12-ee9e6f6777da"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("aaa27bfd-ac48-4483-afab-be59776dd0f3"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("b402fe59-71a2-471e-8a0e-f22543e22ecb"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("b55242a2-d821-460c-b6d7-e2a401e3809f"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("cda2238d-6554-4a6d-84f8-c2196e8f3460"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("f0ec6eda-2d99-433f-b761-8a1192214e5a"));

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "FollowId",
                keyValue: new Guid("ff96eebd-eb32-4b59-ab86-03d7025581ac"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("0d1e786f-53c1-4b76-8a6d-32a47ac70845"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("0f60bba2-6480-4c89-b46e-8470d62d7c87"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("1a38e76d-6834-438e-b89e-1eae1ecb0a72"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("292f0ff3-5ff3-4b15-85a2-9bb97b08ec22"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("5f9c37e3-06b6-4a3e-b728-7b2c7e2aebf4"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("b5d54b1e-99d7-4b1d-b8da-9c8f4cde7a9e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("d10f6b89-cc26-40b7-881f-8d97b7bb9309"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("d9a32e19-48f2-4b4d-b62b-1d5509b18d2d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("e9fbf5a4-985c-4f16-ae19-3a6788f8900e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("f6c96d6b-3f45-4728-afd3-2ee9ef1d8ab8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"));
        }
    }
}
