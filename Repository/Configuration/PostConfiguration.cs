using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
                new Post 
                { 
                    Id = new Guid("5f9c37e3-06b6-4a3e-b728-7b2c7e2aebf4"), 
                    UserId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"), 
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", 
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(-10),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-10)
                },
                new Post 
                { 
                    Id = new Guid("f6c96d6b-3f45-4728-afd3-2ee9ef1d8ab8"), 
                    UserId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"), 
                    Text = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(-9),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-9)
                },
                new Post 
                { 
                    Id = new Guid("1a38e76d-6834-438e-b89e-1eae1ecb0a72"),
                    UserId = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"), 
                    Text = "Ut enim ad minim veniam, quis nostrud exercitation ullamco.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(-8),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-8)
                },
                new Post
                {
                    Id = new Guid("d9a32e19-48f2-4b4d-b62b-1d5509b18d2d"),
                    UserId = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"),
                    Text = "Duis aute irure dolor in reprehenderit in voluptate velit.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(-7),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-7)
                },
                new Post
                {
                    Id = new Guid("e9fbf5a4-985c-4f16-ae19-3a6788f8900e"),
                    UserId = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"),
                    Text = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(-6),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-6)
                },
                new Post
                {
                    Id = new Guid("292f0ff3-5ff3-4b15-85a2-9bb97b08ec22"),
                    UserId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"),
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(-5),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-5)
                },
                new Post
                {
                    Id = new Guid("b5d54b1e-99d7-4b1d-b8da-9c8f4cde7a9e"),
                    UserId = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"),
                    Text = "Sed do eiusmod tempor incididunt ut labore.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(4),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-4)
                },
                new Post
                {
                    Id = new Guid("d10f6b89-cc26-40b7-881f-8d97b7bb9309"),
                    UserId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"),
                    Text = "Ut enim ad minim veniam, quis nostrud exercitation.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(-3),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-3)
                },
                new Post
                {
                    Id = new Guid("0d1e786f-53c1-4b76-8a6d-32a47ac70845"),
                    UserId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"),
                    Text = "Duis aute irure dolor in reprehenderit in voluptate.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow + TimeSpan.FromDays(-2),
                    ModifiedAt = DateTime.UtcNow + TimeSpan.FromDays(-2)
                },
                new Post
                {
                    Id = new Guid("0f60bba2-6480-4c89-b46e-8470d62d7c87"),
                    UserId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"),
                    Text = "Excepteur sint occaecat cupidatat non proident.",
                    Likes = 0,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                }
            );
        }
    }
}
