using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //[Attribute] ... Javada ise [Annotation] 
    public class ProductsController : ControllerBase
    {
        //Loosly coupled---gevşek bağımlı
        //naming convention
        //IoC Container -- Inversion of Control
        //Belleğe ekleyerek istediğimiz zaman oradan çekebilir hale getiriyoruz
        IProductService _productService;
        //Bu adama soyut referans vermemiz gerekiyor
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        //Bir katman diğer katmanın somutuna bağlantı kuramayız
        //Yarın karşısına ne çıkacağını bilmeyen ama bileerek yazan geliştirici ol
        //IProductService _productService = new ProductManager(new EfProductDal());
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger --> 
            //Dependency chain -- bağımlılık var
            var result = _productService.GetAll();
            if (result.Success)
            { //200 dönderecek get request 200 ile çalışır
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //silme ve güncellemeler için post kullanılır ama
        //silme için httpdelete kullanabiliriz
        //güncelleme için httpput kullanabiliriz
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
