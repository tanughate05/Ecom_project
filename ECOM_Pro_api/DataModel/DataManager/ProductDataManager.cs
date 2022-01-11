using ECOM_Pro_api.DataModel.Repository;
using System.Collections.Generic;
using System.Linq;
namespace ECOM_Pro_api.DataModel.DataManager
{
    public class ProductDataManager : IDataRepository<Productcs>
    {
        

    
        
        
            readonly ProductContext _productContext;

            public ProductDataManager(ProductContext context)
            {
                _productContext = context;
            }

            public IEnumerable<Productcs> GetAll()
            {
                return _productContext.product.ToList();
            }

            public Productcs Get(long id)
            {
                return _productContext.product
                      .FirstOrDefault(e => e.Product_id == id);
            }

            public void Add(Productcs entity)
            {
                _productContext.product.Add(entity);
                _productContext.SaveChanges();
            }

            public void Update(Productcs product, Productcs entity)
            {
                product.Product_id = entity.Product_id;
                product.Product_Name = entity.Product_Name;
                product.Description = entity.Description;
                product.categoryId = entity.categoryId;
                product.is_available = entity.is_available;
                product.price = entity.price;
                product.productImg = entity.productImg;
                product.rating = entity.rating;
                product.review = entity.review;
                product.vendor_name = entity.vendor_name;
                product.warranty = entity.warranty;
               
                _productContext.SaveChanges();
            }

            public void Delete(Productcs product)
            {
                _productContext.product.Remove(product);
                _productContext.SaveChanges();
            }
        }
    
}

