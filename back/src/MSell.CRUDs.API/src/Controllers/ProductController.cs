using Microsoft.AspNetCore.Mvc;
using MSell.CRUDs.BL.src;
using MSell.CRUDs.Share.src.ENTITY;
using System.Collections.Generic;

namespace MSell.CRUDs.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
   
        public ProductController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            BoProduct bo = new BoProduct();
            IList<Product> list = bo.GetAllProduct();
            return Ok(list);
        }
    }
}
