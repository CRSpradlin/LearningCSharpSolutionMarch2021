using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class NullStuffPartOne
    {
        [Fact]
        public void ElvisOperator()
        {
            Dinner d = new Dinner { MainCourse = "tacos" };
            //Dinner d = null;

            var mainCourse = d?.MainCourse;

            Assert.Equal("tacos", mainCourse)
        }

        [Fact]
        public void ConditionalAssignment()
        {
            var age = 10;
            string message = "";

            //if (age >= 21)
            //{
            //    message = "Old Enough";

            //} else
            //{
            //    message = "Too Young";
            //}

            message = age >= 21 ? "Old Enough" : "Too Young";

            Assert.Equal("Too Young", message);
        }

        [Fact]
        public void NullCoalescingOperator()
        {
            string firstName = null, lastName = "Smith";
            string preferredName = firstName ?? lastName;

            //if (firstName == null)
            //{
            //    preferredName = lastName;
            //} else
            //{
            //    preferredName = firstName;
            //}

            Assert.Equal("Smith", preferredName);
        }
    }
}
