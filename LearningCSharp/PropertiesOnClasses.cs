using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class PropertiesOnClasses
    {
        [Fact]
        public void UsingProperties()
        {
            var cust = new Customer();
            cust.FirstName = "Joe";
            Assert.Equal("Joe", cust.FirstName);
        }

        [Fact]
        public void UsingPropertiesBetter()
        {
            var cust = new Customer
            {
                FirstName = "Chris",
                LastName = "Spradlin"
            };

            Assert.Equal("Chris", cust.FirstName);
            Assert.Equal("Spradlin", cust.LastName);
        }
    }

    public class Customer
    {
        // classes are a combination of state and behavior (data, code)
        private string _firstName; // "backing Field"

        //public string GetFirstName()
        //{
        //    return _firstName;
        //}

        //public void SetFirstName(string newValue)
        //{
        //    _firstName = newValue;
        //}

        public string FirstName // "property"
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }

        // Can set private on either methods or both and set default value at the very end
        public decimal CreditLimit { get; private set; } = 5000M;
    }
}
