using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Models;

namespace TheShop.DataAccess.InMemory
{
    public class ProductCategoryRepository
    {

        ObjectCache cache = MemoryCache.Default;
        List<ProductCategory> productCategories;

        public ProductCategoryRepository()
        {
            productCategories = cache["productCategories"] as List<ProductCategory>;
            if (productCategories == null)
            {
                productCategories = new List<ProductCategory>();
            }

        }
        public void Commit()
        {
            cache["productCategories"] = productCategories;
        }

        public void Insert(ProductCategory p)
        {
            productCategories.Add(p);
        }

        public void Update(ProductCategory productcaterogy)
        {
            ProductCategory productcaterogyproductToUpdate = productCategories.Find(p => p.Id == productcaterogy.Id);
            if (productcaterogyproductToUpdate != null)
            {
                productcaterogyproductToUpdate = productcaterogy;
            }
            else
            {
                throw new Exception("Product category not found");
            }
        }
        public ProductCategory Find(string Id)
        {
            ProductCategory productcaterogy = productCategories.Find(p => p.Id == Id);
            if (productcaterogy != null)
            {
                return productcaterogy;
            }
            else
            {
                throw new Exception("Product category not found");
            }
        }

        public IQueryable<ProductCategory> Collection()
        {
            return productCategories.AsQueryable();
        }
        public void Delete(String Id)
        {
            ProductCategory productcaterogyToDelete = productCategories.Find(p => p.Id == Id);
            if (productcaterogyToDelete != null)
            {
                productCategories.Remove(productcaterogyToDelete);
            }
            else
            {
                throw new Exception("Product Category  not found");
            }
        }

    }
}
