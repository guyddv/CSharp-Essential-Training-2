using System;
using Xunit;
using EssentialTraining;

namespace EssentialTrainingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var testInstance = new Class1();
            var testResult = testInstance.AddTwo(9, 5);
            Assert.Equal(14, testResult);
        }
    }
}
