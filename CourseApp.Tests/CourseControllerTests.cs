using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class CoursesControllerTests
    {
        ICourseRepository courseRepo;
        CoursesController underTest;

        public CoursesControllerTests()
        {
            courseRepo = Substitute.For<ICourseRepository>();
            underTest = new CoursesController(courseRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_All_Courses()
        {            
            var result = underTest.Index();
            courseRepo.Received().GetAll();
        }

        [Fact]
        public void Index_Sets_AllCourse_As_Model()
        {
            var expectedModel = new List<Course>();
            courseRepo.GetAll().Returns(expectedModel);

            var result = underTest.Index();

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Sets_Dog_To_Model()
        {
            var expectedModel = new Course();
            courseRepo.FindById(1).Returns(expectedModel);
            var result = underTest.Details(1);
            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }
    }
}
