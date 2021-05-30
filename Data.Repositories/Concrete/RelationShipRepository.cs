using Data.Configuration;
using Data.Models.Common;
using Data.Repositories.Interface;

namespace Data.Repositories.Concrete
{
    public class RelationShipRepository : GenericRepository<RelationShipMaster>, IRelationShipRepository
    {

        public RelationShipRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
