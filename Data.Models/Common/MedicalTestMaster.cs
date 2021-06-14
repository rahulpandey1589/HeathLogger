using System;
using System.Collections.Generic;
using System.Text;
using Data.Models.Patient;

namespace Data.Models.Common
{
    public class MedicalTestMaster : AuditEntity<int>
    {
        public string TestName { get; set; }

        public virtual IEnumerable<MedicalTestDetail> MedicalTestDetails { get; set; }
        public virtual IEnumerable<PatientTestLogger> PatientTestLoggers { get; set; }

    }
}
