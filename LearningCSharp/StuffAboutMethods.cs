using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class StuffAboutMethods
    {

        [Fact]
        public void RefAndVal()
        {
            int age = 12;
            MessWithIt(age);
            Assert.Equal(12, age);
        }

        [Fact]
        public void RefAndVal2()
        {
            var dinner = new Dinner { MainCourse = "Palek Paneer" };
            MessWithIt(dinner);
            Assert.Equal("McDonalds", dinner.MainCourse);
        }

        public void MessWithIt(Dinner x)
        {
            x.MainCourse = "McDonalds";
        }

        public void MessWithIt(int x)
        {
            x = x * 2;
        }
    }
}
