using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;

namespace CourseApp
{
    public class CourseRepository : ICourseRepository
    {

        List<Course> all = new List<Course>()
        {
            new Course()
            {
                Name = "HTML",
                Id =1,
                Description ="Intro Course to HTML"
            },

            new Course()
            {
                Name = "CSS",
                Id =2,
                Description ="Intro Course to CSS"
            },

            new Course()
            {
                Name = "Javascript",
                Id =3,
                Description ="Intro Course to Javascript"
            }
        };

        public Course FindById(int id)
        {
            return all[id-1];
        }

        public List<Course> GetAll()
        {
            
            return all;
        }
    }
}
