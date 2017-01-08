using System.Collections.Generic;
using ComparisonOne.Core.Models;

namespace ComparisonOne.Core.Interfaces
{
    public interface IProductService
    {
        IList<int> GetAllItemIds();
        ProductItemModel GetById(int productId);
    }
}
