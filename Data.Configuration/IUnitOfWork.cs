using System.Threading.Tasks;

namespace Data.Configuration
{
    public interface IUnitOfWork
    {
       Task<int> CommitAsync();
    }
}
