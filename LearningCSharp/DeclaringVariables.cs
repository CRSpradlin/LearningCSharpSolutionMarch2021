using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class DeclaringVariables
    {
        [Fact]
        public void SamplesOfExplicitLocalVariables() 
        {
            int age = 51;
            decimal pay = 52.32M;

            string yourName = "Gambit";
            DateTime myBirthday = new DateTime(1969, 4, 20);

            Assert.Equal("Gambit", yourName);
            Assert.Equal(51, age);
        }
        [Fact]
        public void ImplicitlyTypesLocalVariables()
        {
            var age = 51;
            var pay = 52.32M;

            var yourName = "Gambit";
            var myBirthday = new DateTime(1969, 4, 20);

            DateTime yourBirthday = new(); // new in C# 9
        }

        [Fact]
        public void ObjectInitializers()
        {
            var myDinner = new Dinner()
            {
                MainCourse = "Tacos",
                Drinks = "Beer",
                Desert = "Another Beer"
            };
            //myDinner.MainCourse = "Tacos";
            //myDinner.Drinks = "Beer";
            //myDinner.HasSides = false;
            //myDinner.Desert = "Another Beer";

            Assert.Equal("For Dinner you will have Tacos With Another Beer",
                myDinner.GetPlan());
        }
    }
}
