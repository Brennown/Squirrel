using SquirrelDomain.Entities;
using System.Threading.Tasks;

namespace SquirrelData.Intefaces
{
    public interface ILoginRepository
    {
        Task<bool> HasAnyAccount(Account accountDomian);
    }
}
