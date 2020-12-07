using SquirrelDomain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SquirrelData.Intefaces
{
    public interface IProductGroupRepository
    {
        Task<List<ProductGroup>> GetAllProductGroup();
        Task<ProductGroup> GetProductGroupById(int productGroupId);
        Task InsertNeWProductGroup(ProductGroup productGroup);
        Task UpdateProductGroup(ProductGroup productGroup);
        Task DeleteProductGroup(int productGroupId);
    }
}
