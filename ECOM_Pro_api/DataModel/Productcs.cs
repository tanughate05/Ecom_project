using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOM_Pro_api.DataModel
{
    public class Productcs
    {
        [Key]
       
        public long Product_id{ get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public int categoryId { get; set; }    
        public int price{get;set;}
        public bool is_available { get; set; }
         public string productImg{get;set;}
         public int rating{get;set;}
        public int review { get; set; }
        public string vendor_name { get; set; }
        public int warranty { get; set; }
 
    }
}
