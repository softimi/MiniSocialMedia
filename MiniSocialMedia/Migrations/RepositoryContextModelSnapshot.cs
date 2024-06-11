﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace MiniSocialMedia.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Follow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FollowId");

                    b.Property<Guid>("FolloweeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FollowerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FolloweeId");

                    b.HasIndex("FollowerId", "FolloweeId")
                        .IsUnique();

                    b.ToTable("Follows");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b55242a2-d821-460c-b6d7-e2a401e3809f"),
                            FolloweeId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"),
                            FollowerId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3")
                        },
                        new
                        {
                            Id = new Guid("1e52ee4a-52c9-4619-9140-02e47678e998"),
                            FolloweeId = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"),
                            FollowerId = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3")
                        },
                        new
                        {
                            Id = new Guid("05cf48f1-3f91-4eee-899c-491771b2d1b8"),
                            FolloweeId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"),
                            FollowerId = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86")
                        },
                        new
                        {
                            Id = new Guid("0bb1a3a8-7a0b-4fe5-b5e4-62cf4505965b"),
                            FolloweeId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"),
                            FollowerId = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688")
                        },
                        new
                        {
                            Id = new Guid("33e4fdcd-fa8c-4598-80d9-ef02169f2c3a"),
                            FolloweeId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"),
                            FollowerId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0")
                        },
                        new
                        {
                            Id = new Guid("234ce2af-d775-4637-a1f7-b3d4948c3a61"),
                            FolloweeId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"),
                            FollowerId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b")
                        },
                        new
                        {
                            Id = new Guid("aaa27bfd-ac48-4483-afab-be59776dd0f3"),
                            FolloweeId = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"),
                            FollowerId = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14")
                        },
                        new
                        {
                            Id = new Guid("046597f2-022b-4410-bf14-fcde493714c6"),
                            FolloweeId = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"),
                            FollowerId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b")
                        },
                        new
                        {
                            Id = new Guid("b402fe59-71a2-471e-8a0e-f22543e22ecb"),
                            FolloweeId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"),
                            FollowerId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897")
                        },
                        new
                        {
                            Id = new Guid("05b56d7f-ed44-4d58-9bf9-b884bb9d32a5"),
                            FolloweeId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"),
                            FollowerId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b")
                        },
                        new
                        {
                            Id = new Guid("44f23e8b-f0f5-489c-97de-4616de7a0bce"),
                            FolloweeId = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"),
                            FollowerId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3")
                        },
                        new
                        {
                            Id = new Guid("324f90c5-00aa-4189-a7c5-210952822263"),
                            FolloweeId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"),
                            FollowerId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0")
                        },
                        new
                        {
                            Id = new Guid("43fd0e11-9ec3-412b-949d-78cd82908b11"),
                            FolloweeId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"),
                            FollowerId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897")
                        },
                        new
                        {
                            Id = new Guid("f0ec6eda-2d99-433f-b761-8a1192214e5a"),
                            FolloweeId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"),
                            FollowerId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b")
                        },
                        new
                        {
                            Id = new Guid("ff96eebd-eb32-4b59-ab86-03d7025581ac"),
                            FolloweeId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"),
                            FollowerId = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14")
                        },
                        new
                        {
                            Id = new Guid("cda2238d-6554-4a6d-84f8-c2196e8f3460"),
                            FolloweeId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"),
                            FollowerId = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86")
                        },
                        new
                        {
                            Id = new Guid("a84df130-eca5-4e3a-bb12-ee9e6f6777da"),
                            FolloweeId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"),
                            FollowerId = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688")
                        },
                        new
                        {
                            Id = new Guid("a0333ea4-2df9-4f59-b74d-b470ee7ee06a"),
                            FolloweeId = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"),
                            FollowerId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b")
                        },
                        new
                        {
                            Id = new Guid("833d692b-7513-4edb-b39e-db0b4af3445b"),
                            FolloweeId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"),
                            FollowerId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b")
                        });
                });

            modelBuilder.Entity("Entities.Models.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PostId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5f9c37e3-06b6-4a3e-b728-7b2c7e2aebf4"),
                            CreatedAt = new DateTime(2024, 6, 1, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9164),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 1, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9168),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            UserId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3")
                        },
                        new
                        {
                            Id = new Guid("f6c96d6b-3f45-4728-afd3-2ee9ef1d8ab8"),
                            CreatedAt = new DateTime(2024, 6, 2, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9172),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 2, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9172),
                            Text = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            UserId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b")
                        },
                        new
                        {
                            Id = new Guid("1a38e76d-6834-438e-b89e-1eae1ecb0a72"),
                            CreatedAt = new DateTime(2024, 6, 3, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9174),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 3, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9175),
                            Text = "Ut enim ad minim veniam, quis nostrud exercitation ullamco.",
                            UserId = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3")
                        },
                        new
                        {
                            Id = new Guid("d9a32e19-48f2-4b4d-b62b-1d5509b18d2d"),
                            CreatedAt = new DateTime(2024, 6, 4, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9177),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 4, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9177),
                            Text = "Duis aute irure dolor in reprehenderit in voluptate velit.",
                            UserId = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14")
                        },
                        new
                        {
                            Id = new Guid("e9fbf5a4-985c-4f16-ae19-3a6788f8900e"),
                            CreatedAt = new DateTime(2024, 6, 5, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9179),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 5, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9201),
                            Text = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim.",
                            UserId = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86")
                        },
                        new
                        {
                            Id = new Guid("292f0ff3-5ff3-4b15-85a2-9bb97b08ec22"),
                            CreatedAt = new DateTime(2024, 6, 6, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9204),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 6, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9204),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing.",
                            UserId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b")
                        },
                        new
                        {
                            Id = new Guid("b5d54b1e-99d7-4b1d-b8da-9c8f4cde7a9e"),
                            CreatedAt = new DateTime(2024, 6, 15, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9206),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 7, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9207),
                            Text = "Sed do eiusmod tempor incididunt ut labore.",
                            UserId = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688")
                        },
                        new
                        {
                            Id = new Guid("d10f6b89-cc26-40b7-881f-8d97b7bb9309"),
                            CreatedAt = new DateTime(2024, 6, 8, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9209),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 8, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9209),
                            Text = "Ut enim ad minim veniam, quis nostrud exercitation.",
                            UserId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897")
                        },
                        new
                        {
                            Id = new Guid("0d1e786f-53c1-4b76-8a6d-32a47ac70845"),
                            CreatedAt = new DateTime(2024, 6, 9, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9211),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 9, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9212),
                            Text = "Duis aute irure dolor in reprehenderit in voluptate.",
                            UserId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0")
                        },
                        new
                        {
                            Id = new Guid("0f60bba2-6480-4c89-b46e-8470d62d7c87"),
                            CreatedAt = new DateTime(2024, 6, 11, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9214),
                            Likes = 0,
                            ModifiedAt = new DateTime(2024, 6, 11, 16, 22, 29, 978, DateTimeKind.Utc).AddTicks(9214),
                            Text = "Excepteur sint occaecat cupidatat non proident.",
                            UserId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b")
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"),
                            Username = "StellarWanderer"
                        },
                        new
                        {
                            Id = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"),
                            Username = "CrimsonShadow"
                        },
                        new
                        {
                            Id = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"),
                            Username = "AzureSkywalker"
                        },
                        new
                        {
                            Id = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"),
                            Username = "LunaEclipse"
                        },
                        new
                        {
                            Id = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"),
                            Username = "NovaWhisperer"
                        },
                        new
                        {
                            Id = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"),
                            Username = "MidnightRider"
                        },
                        new
                        {
                            Id = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"),
                            Username = "PhoenixBlaze"
                        },
                        new
                        {
                            Id = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"),
                            Username = "EchoSpecter"
                        },
                        new
                        {
                            Id = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"),
                            Username = "TwilightSeeker"
                        },
                        new
                        {
                            Id = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"),
                            Username = "SolarFlare"
                        });
                });

            modelBuilder.Entity("Entities.Models.Follow", b =>
                {
                    b.HasOne("Entities.Models.User", "Followee")
                        .WithMany("Followers")
                        .HasForeignKey("FolloweeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "Follower")
                        .WithMany("Followees")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Followee");

                    b.Navigation("Follower");
                });

            modelBuilder.Entity("Entities.Models.Post", b =>
                {
                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Navigation("Followees");

                    b.Navigation("Followers");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
