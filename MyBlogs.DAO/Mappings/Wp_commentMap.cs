using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlogs.Domain;

namespace MyBlogs.DAO.Mappings
{
    public class Wp_commentMap : EntityTypeConfiguration<Wp_comment>
    {
        public override void Configure(EntityTypeBuilder<Wp_comment> builder)
        {
            builder.ToTable("wp_comments");
            builder.HasKey(u => u.comment_ID);
        }
    }
}
