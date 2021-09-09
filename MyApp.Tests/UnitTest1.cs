using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var wr = new StringWriter();
            Console.SetOut(wr);

            //Act
            Program.Main(new String[0]);

            //Assert
            var line = wr.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!", line);
        }
    }
}
