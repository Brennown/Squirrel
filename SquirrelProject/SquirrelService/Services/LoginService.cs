using SquirrelData.Intefaces;
using SquirrelDomain.Entities;
using SquirrelService.Interfaces;
using System.Threading.Tasks;

namespace SquirrelService.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<bool> HasAnyAccount(Account account)
        {
            return await _loginRepository.HasAnyAccount(account);
        }
    }
}
