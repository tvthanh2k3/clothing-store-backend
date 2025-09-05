using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		[Authorize]
		[HttpGet("secure")]
		public IActionResult SecureData()
		{
			return Ok("Bạn đã truy cập endpoint bảo vệ thành công!");
		}

		[HttpGet("public")]
		public IActionResult PublicData()
		{
			return Ok("Ai cũng xem được");
		}
	}
}
