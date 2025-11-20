using Microsoft.AspNetCore.Mvc;

namespace dotnetbasic.Controllers
{
    public class HomeController : Controller
    {
        public string About()
        {
            return "About";
        }
        public string Contact()
        {
            return "Contact";
        }
    }
}
