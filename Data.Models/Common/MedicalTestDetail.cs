using Data.Models.Patient;
using System.Collections.Generic;

namespace Data.Models.Common
{
    public class MedicalTestDetail : AuditEntity<int>
    {
        public int MedicalTestMasterId { get; set; }

        public virtual MedicalTestMaster MedicalTestMaster { get; set; }

        public string ComponentName { get; set; }

        public double MaxValue { get; set; }

        public double MinValue { get; set; }

        public virtual IEnumerable<PatientTestLogger> PatientTestLogger { get; set; }
    }
}
