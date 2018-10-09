using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseApp.Tests
{
    public class CourseRepositoryTests
    {
        [Fact]
        public void GetAll_Returns_3_Courses()
        {
            var underTest = new CourseRepository();
            var result = underTest.GetAll();
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void FindById_Returns_Correct_Dog()
        {
            var underTest = new CourseRepository();
            var result = underTest.FindById(1);
            Assert.Equal("HTML", result.Name);
        }
    }
}
