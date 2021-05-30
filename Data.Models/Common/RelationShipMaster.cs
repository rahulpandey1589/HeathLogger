using Data.Models.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Common
{
    public class RelationShipMaster
    {
        public int RelationShipId { get; set; }

        public string RelationShipName { get; set; }

        public bool IsActive { get; set; }

        public virtual PatientEmergencyContactDetails PatientEmergency { get; set; }
    }
}
