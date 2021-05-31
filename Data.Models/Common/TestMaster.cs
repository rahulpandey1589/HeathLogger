using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Common
{
    public class TestMaster : AuditEntity<int>
    {
        public int TestName { get; set; }
    }
}
