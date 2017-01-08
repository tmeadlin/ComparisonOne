using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparisonOne.Core.Interfaces;
using ComparisonOne.Core.Models;
using ComparisonOne.Services.ProductServices.Interfaces;

namespace ComparisonOne.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public IList<int> GetAllItemIds()
        {
            return _productRepo.GetItems().Select(x => x.Id).ToList();
        }

        public ProductItemModel GetById(int productId)
        {
            return _productRepo.GetItems().FirstOrDefault(x => x.Id == productId);
        }
    }
}
