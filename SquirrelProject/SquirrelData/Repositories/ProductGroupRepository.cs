using SquirrelData.Context;
using SquirrelData.Generic;
using SquirrelData.Intefaces;
using SquirrelDomain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SquirrelData.Repositories
{
    public class ProductGroupRepository : GenericContext, IProductGroupRepository
    {
        public ProductGroupRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<List<ProductGroup>> GetAllProductGroup()
        {
            return await _context.ProductGroups.ToListAsync();
        }

        public async Task<ProductGroup> GetProductGroupById(int productGroupId)
        {
            return await _context.ProductGroups.FirstOrDefaultAsync(x => x.ProductGroupId == productGroupId);
        }

        public async Task InsertNeWProductGroup(ProductGroup productGroup)
        {
            await _context.ProductGroups.AddAsync(productGroup);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductGroup(ProductGroup productGroup)
        {
            _context.ProductGroups.Update(productGroup);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductGroup(int productGroupId)
        {
            var productGroup = await GetProductGroupById(productGroupId);
            _context.Remove(productGroup);
            await _context.SaveChangesAsync();
        }
    }
}
