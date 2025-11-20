using Microsoft.AspNetCore.Mvc;

namespace dotnetbasic.Controllers
{
    public class CourseController : Controller
    {
        public string Index()
        {
            return "Course/Index";
        }
        public string List()
        {
            return "Course/List";
        }
        public string Details()
        {
            return "Course/Details";
        }
    }
}
