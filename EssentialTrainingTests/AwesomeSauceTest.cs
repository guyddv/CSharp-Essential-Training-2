using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EssentialTraining;

namespace EssentialTrainingTests
{
    public class AwesomeSauceTest
    {
        [Fact]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            Assert.True(testInstance.IsSauceAwesome("Trailer Trash"));

            Assert.False(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
