using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnlineStudyV2.Models
{
    public partial class OnlineStudyWebsiteContext : DbContext
    {
        public OnlineStudyWebsiteContext()
        {
        }

        public OnlineStudyWebsiteContext(DbContextOptions<OnlineStudyWebsiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConatctUs> ConatctUs { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-8RTHSCD;Database=OnlineStudy(Website);Trusted_Connection=True;User ID=sa; Password=16009065048;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ConatctUs>(entity =>
            {
                entity.ToTable("Conatct_us");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("Email_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
