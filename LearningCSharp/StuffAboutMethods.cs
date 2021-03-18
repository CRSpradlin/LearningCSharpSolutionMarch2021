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
        [Fact]
        public void PassingByRef()
        {
            int y = 12;
            MessWithItRef(ref y);
            Assert.Equal(24, y);
        }
        [Fact]
        public void CanSwapStuff()
        {
            int a = 10, b = 20;

            Swap<int>(ref a, ref b);

            Assert.Equal(20, a);
            Assert.Equal(10, b);

            var bestFriend = "Sean";
            var otherFriend = "Billy";

            Swap<string>(ref bestFriend, ref otherFriend);

            Assert.Equal("Billy", bestFriend);
        }
        [Fact]
        public void UsingOutParams()
        {
            // int x;
            Assert.Equal("Solo, Han", FormatName("Han", "Solo", out int x));
            Assert.Equal(9, x);
        }

        [Fact]
        public void NullableTypes()
        {
            //Is a struct
            //DateTime birthday = null;
            Nullable<DateTime> birthday = null;
            DateTime? birthday2 = null;

            //Is an object
            string myName = null;
        }


        public string FormatName(string first, string last, out int length)
        {
            var fullName = $"{last}, {first}";
            length = fullName.Length;
            return fullName;
        }
        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }



        public void MessWithItRef(ref int x)
        {
            x = x * 2;
        }

        public void MessWithIt(int x)
        {
            x = x * 2;
        }

        public void MessWithIt(Dinner x)
        {
            x.MainCourse = "McDonalds";
        }
    }
}