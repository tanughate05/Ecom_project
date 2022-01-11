using ECOM_Pro_api.DataModel.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ECOM_Pro_api.DataModel;
namespace ECOM_Pro_api.Controllers
{


    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IDataRepository<Productcs> _dataRepository;
        public ProductController(IDataRepository<Productcs> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET: api/product
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Productcs> product = _dataRepository.GetAll();
            return Ok(product);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Productcs product = _dataRepository.Get(id);
            if (product == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            return Ok(product);
            
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult Post([FromBody] Productcs product)
        {
            //data validation
            if (product == null)
            {
                return BadRequest("product is null.");
            }
            if(product.Product_Name == null)
            {
                return BadRequest("product name is null.");
            }
            //Exception Handling
            try
            {
                _dataRepository.Add(product);
                return CreatedAtRoute(
                    "Get",
                    new { Id = product.Product_id },
                    product);
            }
            catch
            {
                return BadRequest(" Something went wrong");
            }
        }
        // DELETE: api/Product/3
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Productcs product = _dataRepository.Get(id);
            if (product == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            _dataRepository.Delete(product);
            return NoContent();
        }
    }
}
