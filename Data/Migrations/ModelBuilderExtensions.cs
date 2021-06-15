using Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Migrations
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            InsertMedicalTestMasterData(modelBuilder);
        }

        public static void InsertMedicalTestMasterData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalTestMaster>()
               .HasData(
                        new MedicalTestMaster() 
                        {
                            Id = 1,TestName = "Lipid Profile",
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                            CreatedBy = "System" 
                        },
                        new MedicalTestMaster()
                        {
                            Id = 2,
                            TestName = "Blood Sugar Fasting & PP",
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                            CreatedBy = "System"
                        }
                      );
        }
    }
}
