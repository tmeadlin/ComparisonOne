using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparisonOne.Core.Models;

namespace ComparisonOne.Services.ProductServices.Interfaces
{
    public interface IProductRepo
    {
        IList<ProductItemModel> GetItems();
    }
}
