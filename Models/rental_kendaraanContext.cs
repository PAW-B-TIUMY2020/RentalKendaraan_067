using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentalKendaraan_20180140067.Models
{
    public partial class rental_kendaraanContext : DbContext
    {
        public rental_kendaraanContext()
        {
        }

        public rental_kendaraanContext(DbContextOptions<rental_kendaraanContext> options)
            : base(options)
        {
        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-SU3D3TD;Database=rental_kendaraan;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
