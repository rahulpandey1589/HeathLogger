using Data.Configuration;
using Data.Models.Common;
using Data.Repositories.Interface.Common;

namespace Data.Repositories.Concrete.Common
{
    public class RelationShipRepository : GenericRepository<RelationShipMaster>, IRelationShipRepository
    {

        public RelationShipRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
