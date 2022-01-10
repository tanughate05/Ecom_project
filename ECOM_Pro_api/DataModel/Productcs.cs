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
    }
}
