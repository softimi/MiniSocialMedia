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
    public class FollowConfiguration : IEntityTypeConfiguration<Follow>
    {
        public void Configure(EntityTypeBuilder<Follow> builder)
        {
            builder.HasData(
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"), FolloweeId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3"), FolloweeId = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"), FolloweeId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"), FolloweeId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"), FolloweeId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"), FolloweeId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"), FolloweeId = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"), FolloweeId = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"), FolloweeId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"), FolloweeId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3"), FolloweeId = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0"), FolloweeId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897"), FolloweeId = new Guid("7a12fb6b-894f-4e09-b380-d9cb29e69dc3") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b"), FolloweeId = new Guid("1a83b474-9838-4d8c-b469-6dd066ab8897") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("4a45ee48-63de-4467-836f-43d2e20d7d14"), FolloweeId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("71b0c3e5-675c-49a0-8b2d-3f1b085b1c86"), FolloweeId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("8a57fb3f-75bb-41d0-97d0-5c470015a688"), FolloweeId = new Guid("c82e1f84-1e0e-46de-b4e7-6c69c02237c0") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("1d7d9e8c-1340-4911-b65e-4a04f5709f6b"), FolloweeId = new Guid("8bf3a042-17b2-4a18-aec2-df199a1ee4b3") },
                new Follow { Id = Guid.NewGuid(), FollowerId = new Guid("f3826e1e-dba9-421b-834d-30be8926cb5b"), FolloweeId = new Guid("9e25e0d4-c05e-4a3a-a9ef-fb55d2248f1b") }
            );
        }
    }
}
