using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlogs.Domain;

namespace MyBlogs.DAO.Mappings
{
    public class Wp_userMap : EntityTypeConfiguration<Wp_user>
    {
        public override void Configure(EntityTypeBuilder<Wp_user> builder)
        {
            builder.ToTable("wp_users");
            builder.HasKey(u => u.ID);
        }
    }
}
