using Microsoft.AspNetCore.Mvc;

namespace Cinema_API.Controllers
{
    public class CinemaRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
