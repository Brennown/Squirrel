using SquirrelData.Context;

namespace SquirrelData.Generic
{
    public class GenericContext
    {
        protected readonly ApplicationContext _context;
        public GenericContext(ApplicationContext context)
        {
            _context = context;
        }
    }
}
