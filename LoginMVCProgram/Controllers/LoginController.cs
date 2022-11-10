
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using LoginMVCProgram.Models; 

namespace LoginMVCProgram.Controllers
{
    public class LoginController : Controller
    {


        //[HttpGet]
        //public IActionResult Index()
        //{

        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Index(string name,string password)
        //{
        //    if(name=="ABC" && password=="XYZ")
        //    {
        //        return RedirectToAction("Dashboard");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //public IActionResult Dashboard()
        //{
        //    return View();
        //}


        [HttpGet]
        public IActionResult Index()
        {
            Student s = new Student();
           
             return View(s);

        }
        [HttpPost]
        public IActionResult Index(Student s )
        {
            if(s.name=="ABC" && s.password=="XYZ")
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("Index");
            }
          
            return View();

        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
