using Data.Models.Common;

namespace Data.Models.Patient
{
    public class PatientEmergencyContactDetails : BaseModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public int RelationShipId { get; set; }
        public virtual RelationShipMaster RelationShip { get; set; }
        
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }

        public virtual Address EmergencyContactDetailAddress { get; set; }
        public int AddressId { get; set; }
    }

   
}
