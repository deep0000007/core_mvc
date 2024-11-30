using Microsoft.AspNetCore.Mvc;
using WebApplication4.Infrastructure.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication4.Controllers
{
    public class Class : Controller
    {
        private readonly IClass _cls;

        public Class(IClass cls)
        {
            _cls = cls;
        }

        public IActionResult Index()
        {
            var data = _cls.GetAll();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(WebApplication4.Models.Class cls)
        {
            _cls.Insert(cls);
            return RedirectToAction("Index");


           

        }
        public IActionResult Edit()
        {
            return View();

        }
    }
}
