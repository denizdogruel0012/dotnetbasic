using Microsoft.AspNetCore.Mvc;

namespace dotnetbasic.Controllers
{
    public class CourseController : Controller
    {
        public string List()
        {
            return "List";
        }
        public string Details()
        {
            return "Details";
        }
    }
}
