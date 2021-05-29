using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Common
{
    public class TestMaster : AuditEntity<short>
    {

        public int Id { get; set; }

        public int TestName { get; set; }

        public bool IsActive { get; set; }
    }
}
