using SquirrelDomain.Entities;
using System.Threading.Tasks;

namespace SquirrelService.Interfaces
{
    public interface ILoginService
    {
        Task<bool> HasAnyAccount(Account accountDomain);
    }
}
