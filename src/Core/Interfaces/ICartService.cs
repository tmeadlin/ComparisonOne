using System.Collections.Generic;
using ComparisonOne.Core.Models;

namespace ComparisonOne.Core.Interfaces
{
    public interface ICartService
    {
        IList<ProductItemModel> GetCartItems(int cartId);
        CartTotalsModel GetCartTotals(int cartId);
    }
}
