using Microsoft.EntityFrameworkCore;

namespace ECOM_Pro_api.DataModel
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions options): base(options)
         {
             
         }
        public DbSet<Productcs> product { get; set; }
    }
}
