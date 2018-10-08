using CourseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp
{
    public interface ICourseRepository
    {
        List<Course> GetAll();
    }
}
