using SquirrelDomain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SquirrelService.Interfaces
{
    public interface IProductGroupService
    {
        Task<List<ProductGroup>> GetAllProductGroup();
        Task<ProductGroup> GetProductGroupById(int productGroupId);
        Task InsertNewProductGroup(ProductGroup productGroup);
        Task UpdateProductGroup(ProductGroup productGroup);
        Task DeleteProductGroup(int productGroupId);
    }
}
