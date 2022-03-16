using Microsoft.AspNetCore.Mvc;
using StudentsMangment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsMangment.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository _repo;

        public HomeController(IStudentRepository repository)
        {
            _repo = repository;
            
        }
        
        public IActionResult Index()
        {
            var model = _repo.Students;
            return View(model);
        }
    }
}
