using Layout_ViewModels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Layout_ViewModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            #region Model to view


            //ViewData["names"] = new string[] { "Elcan", "Pervin", "Aqshin" };

            //ViewBag.numbers = new int[] { 10, 20, 30, 40 };


            //    ViewBag.name = "Hemze";

            //    TempData["surname"] = "Elizade";

            //    return RedirectToAction(nameof(Detail));

            //}

            //public IActionResult Detail()
            //{
            //    return View();
            //}


            //Students stu1 = new Students()
            //{
            //    Id = 1,
            //    FullName = "Beshirzade Mirze",
            //    Age = 27,
            //};


            //Students stu2 = new Students()
            //{
            //    Id = 2,
            //    FullName = "Talibov Eli",
            //    Age = 22,
            //};



            //Students stu3 = new Students()
            //{
            //    Id = 3,
            //    FullName = "Anar Aliyev ",
            //    Age = 27,
            //};

            //List <Students> students = new List<Students> { stu1, stu2, stu3 };

            //return View (students);
            #endregion

            return View();


        }


        Product product = new Product()
        {
            Id = 1,
            Name = "Samsung"
        };
    }
}
