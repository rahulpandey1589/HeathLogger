using Data.Models.Common;
using System.Collections.Generic;

namespace Data.Models.Patient
{
    public class PatientTestLogger : AuditEntity<int>
    {
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int MedicalTestMasterId { get; set; }
        public virtual MedicalTestMaster MedicalTestMaster { get; set; }
        public int MedicalTestDetailId { get; set; }
        public virtual MedicalTestDetail MedicalTestDetail { get; set; }

        public double TestValue { get; set; }
    }
}
