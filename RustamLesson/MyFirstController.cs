using Microsoft.AspNetCore.Mvc;

namespace RustamLesson
{
	[ApiController]
	[Route("game-zone")]
	public class MyFirstController : Controller
	{
		// /game-zone/c80261
		[HttpGet("c80261")]
		public string GetCatalogByName([FromQuery]string name, int count)
		{
			return $"Товары для геймеров: {name}, {count} шт";
		}

		// game-zone/garden
		[HttpGet("garden")]
		public string GetGardens()
		{
			return "Товары для сада";
		}

		// game-zone/add-product
		[HttpPost("add-product")]
		public string AddProduct([FromBody]Product product)
		{
			return $"Товар {product.Name} добавлен со стоимостью {product.Price}";
		}
	}


	public class Product
	{
		public string Name { get; set; }
		
		public string Price { get; set; }
	}
}