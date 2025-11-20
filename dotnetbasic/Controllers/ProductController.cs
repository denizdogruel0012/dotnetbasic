using Microsoft.AspNetCore.Mvc;

namespace dotnetbasic.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {
            return "Product/Index";
        }
        public string Details()
        {
            return "Product/Details";
        }
        public string List()
        {
            return "Product/List";
        }
        public string Update()
        {
            return "Product/Update";
        }
    }
}
