using SquirrelData.Context;
using SquirrelData.Generic;
using SquirrelData.Intefaces;
using SquirrelDomain.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SquirrelData.Repositories
{
    public class LoginRepository : GenericContext, ILoginRepository
    {
        public LoginRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<bool> HasAnyAccount(Account account)
        {
            var hasAnyAccount = await _context.AccountDomains.AnyAsync(x => x.UserName == account.UserName && x.Password == account.Password);
            return hasAnyAccount;
        }
    }
}
