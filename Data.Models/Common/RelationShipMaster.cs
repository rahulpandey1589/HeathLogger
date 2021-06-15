using Data.Models.Patient;

namespace Data.Models.Common
{
    public class RelationShipMaster : AuditEntity<int>
    {  
        public string RelationShipName { get; set; }

        public virtual EmergencyContactDetails PatientEmergency { get; set; }
    }
}
