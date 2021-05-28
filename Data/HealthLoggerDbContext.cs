using Data.Infrastructure;
using Data.Models.Common;
using Data.Models.Patient;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class HealthLoggerDbContext : DbContext
    {

        public HealthLoggerDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<PatientEmergencyContactDetails> PatientEmergencyContactDetails {get;set;}

        public DbSet<RelationShipMaster> RelationShipMasters { get; set; }

        public DbSet<Address> Address { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientEmergencyContactDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new RelationShipMasterConfiguration());


        }
    }
}
