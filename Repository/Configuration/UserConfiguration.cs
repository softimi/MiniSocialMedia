using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User 
                { 
                    Id = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"), 
                    Username = "StellarWanderer"
                },
                new User 
                { 
                    Id = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"),
                    Username = "CrimsonShadow"
                },
                new User 
                { 
                    Id = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"),
                    Username = "AzureSkywalker"
                },
                new User
                {
                    Id = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"),
                    Username = "LunaEclipse"
                },
                new User
                {
                    Id = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"),
                    Username = "NovaWhisperer"
                },
                new User
                {
                    Id = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"),
                    Username = "MidnightRider"
                },
                new User
                {
                    Id = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"),
                    Username = "PhoenixBlaze"
                },
                new User
                {
                    Id = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"),
                    Username = "EchoSpecter"
                },
                new User
                {
                    Id = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"),
                    Username = "TwilightSeeker"
                },
                new User
                {
                    Id = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"),
                    Username = "SolarFlare"
                }
            );
        }
    }
}
