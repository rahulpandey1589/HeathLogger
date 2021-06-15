using Data.Models.Patient;

namespace Data.Models.Common
{
    public class Address : AuditEntity<int>
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public virtual EmergencyContactDetails PatientEmergency { get; set; }


    }
}