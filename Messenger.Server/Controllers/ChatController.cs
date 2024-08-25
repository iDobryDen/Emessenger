using Microsoft.AspNetCore.Mvc;

namespace Messenger.Server.Controllers
{
	public class ChatController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		
	}
}
