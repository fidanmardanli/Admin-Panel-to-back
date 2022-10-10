using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Area_AdminPanel.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class DashboardController : Controller
    {
 
        public  IActionResult Index()
        {
            return View();
        }

       
    }
}
