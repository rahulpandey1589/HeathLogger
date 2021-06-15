using Data.Configuration;
using Data.Models.Common;
using Data.Repositories.Interface.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Repositories.Concrete.Common
{
    public class TestMasterRepository : GenericRepository<MedicalTestMaster>, ITestMasterRepository
    {
        public TestMasterRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
