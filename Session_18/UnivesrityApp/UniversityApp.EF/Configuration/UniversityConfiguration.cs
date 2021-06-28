using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Model;

namespace UniversityApp.EF.Configuration {
    class UniversityConfiguration : IEntityTypeConfiguration<Student> {
        public void Configure(EntityTypeBuilder<Student> builder) {

            builder.ToTable("Uni", "Education");
        }
    }
}
