using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRENATALv2.Areas.Home.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Models
{
    public class Context:IdentityDbContext<AppUser, AppRole, int>
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppUser>().HasOne(mr => mr.MedicalRecord).WithOne(u => u.AppUser)
                .HasForeignKey<MedicalRecord>(c => c.MedicalRecordId);

        }
        public DbSet<Files> Files { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<MedicalRecord> MedicalRecord { get; set; }
        public DbSet<Allergies> Allergies { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<BloodExaminations> BloodExaminations { get; set; }
        public DbSet<MedicalHistory> MedicalHistory { get; set; }
        public DbSet<Referrals> Referrals { get; set; }
        public DbSet<Therapies> Therapies { get; set; }
        public DbSet<Ultrasound> Ultrasound { get; set; }
        public DbSet<UrineExaminations> UrineExaminations { get; set; }
        public DbSet<VitalSigns> VitalSigns { get; set; }
        public DbSet<ExpectedBirth> ExpectedBirth { get; set; }
        public DbSet<HistoryOfSubstanceUse> HistoryOfSubstanceUse { get; set; }
        public DbSet<PreviousPregnancyHistory> PreviousPregnancyHistory { get; set; }
        public DbSet<PregnancyLossHistory> PregnancyLossHistory { get; set; }
        public DbSet<Partner> Partner { get; set; }
        
    }
}
