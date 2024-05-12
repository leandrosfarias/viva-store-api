using Microsoft.AspNetCore.Mvc;

namespace VivaStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private List<Product> productsList = new()
        {
            new Product(1, "Headset Game Logitech G435", "Fone de Ouvido", 100, "Fones de Ouvido", 400f),
            new Product(2, "Mouse MSHARK", "Mouse gamer ergonômico", 399, "Mouses", 322f),
            new Product(3, "Teclado Mecânico Corsair", "Teclado mecânico para gamers", 150, "Teclados", 560f),
            new Product(4, "Monitor 24' Samsung", "Monitor LED Full HD", 80, "Monitores", 789f),
            new Product(5, "Impressora HP", "Impressora multifuncional HP", 40, "Impressoras", 350f),
            new Product(6, "Webcam Logitech C920", "Webcam HD para videoconferências", 200, "Webcams", 275f),
            new Product(7, "Cadeira Gamer DXRacer", "Cadeira ergonômica para longas sessões de jogos", 50, "Cadeiras", 1350f),
            new Product(8, "SSD 1TB Samsung", "Disco sólido interno de 1TB", 300, "Armazenamento", 500f),
            new Product(9, "Mousepad SteelSeries", "Mousepad grande para gamers", 500, "Acessórios", 99f),
            new Product(10, "Pen Drive 64GB Sandisk", "Pen Drive USB 3.0 de 64GB", 250, "Armazenamento Externo", 75f)

        };

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return productsList;
        }

        [HttpGet("{productId}")]
        public IEnumerable<Product> GetProductByID(int productId)
        {
            return Array.Empty<Product>();
        }

        [HttpPost]
        public IActionResult Post(Product product) 
        {
             try
            {
                productsList.Add(product);
                return Ok("Produto cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest(ex.Message);
            }
        }
    }
}