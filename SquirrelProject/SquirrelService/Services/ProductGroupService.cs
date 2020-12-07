using SquirrelData.Intefaces;
using SquirrelDomain.Entities;
using SquirrelService.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SquirrelService.Services
{
    public class ProductGroupService : IProductGroupService
    {
        private readonly IProductGroupRepository _productGroupRepository;
        public ProductGroupService(IProductGroupRepository productGroupRepository)
        {
            _productGroupRepository = productGroupRepository;
        }

        public async Task<List<ProductGroup>> GetAllProductGroup()
        {
            return await _productGroupRepository.GetAllProductGroup();
        }

        public async Task<ProductGroup> GetProductGroupById(int productGroupId)
        {
            return await _productGroupRepository.GetProductGroupById(productGroupId);
        }


        public async Task InsertNewProductGroup(ProductGroup productGroup)
        {
            await _productGroupRepository.InsertNeWProductGroup(productGroup);
        }

        public async Task UpdateProductGroup(ProductGroup productGroup)
        {
            await _productGroupRepository.UpdateProductGroup(productGroup);
        }

        public async Task DeleteProductGroup(int productGroupId)
        {
            await _productGroupRepository.DeleteProductGroup(productGroupId);
        }
    }
}
