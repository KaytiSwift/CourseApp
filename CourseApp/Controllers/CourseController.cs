using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp
{
    public class CoursesController : Controller
    {
        private ICourseRepository courseRepo;

        public CoursesController(ICourseRepository reviewRepo)
        {
            this.courseRepo = reviewRepo;
        }
        public ViewResult Index()
        {
            var model = courseRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = courseRepo.FindById(id);
            return View(model);
        }
    }
}
