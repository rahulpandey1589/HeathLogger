using Data.Models.Common;
using System.Collections.Generic;

namespace Data.Models.Patient
{
    public class Patient : BaseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public byte[] RowVersion { get; set; }
        public virtual IEnumerable<PatientEmergencyContactDetails> EmergencyContact { get; set; }
    }
}
