using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        /*[Fact]
        public void Test_MainPrintsHelloWorld()
        {
            //Arrange
            var wr = new StringWriter();
            Console.SetOut(wr);

            //Act
            Program.Main(new String[0]);

            //Assert
            var line = wr.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!", line);
        }*/

        [Fact]
        public void Test_DivBy4_1()
        {
            bool l = Program.IsLeapYear(24);
            Assert.True(l);
        }

        [Fact]
        public void Test_DivBy4_2()
        {
            bool l = Program.IsLeapYear(15);
            Assert.False(l);
        }

        [Fact]
        public void Test_DivBy100_1()
        {
            bool l = Program.IsLeapYear(208);
            Assert.True(l);
        }

        [Fact]
        public void Test_DivBy100_2()
        {
            bool l = Program.IsLeapYear(700);
            Assert.False(l);
        }

        [Fact]
        public void Test_DivBy100_3()
        {
            bool l = Program.IsLeapYear(1199);
            Assert.False(l);
        }

        [Fact]
        public void Test_DivBy400_1()
        {
            bool l = Program.IsLeapYear(1200);
            Assert.True(l);
        }

        [Fact]
        public void Test_DivBy400_2()
        {
            bool l = Program.IsLeapYear(1836);
            Assert.True(l);
        }

        [Fact]
        public void Test_DivBy400_3()
        {
            bool l = Program.IsLeapYear(300);
            Assert.False(l);
        }

        [Fact]
        public void Test_DivBy400_4()
        {
            bool l = Program.IsLeapYear(697);
            Assert.False(l);
        }

        [Fact]
        public void Test_ReadYearFromConsole_1()
        {
            
            //Arrange
            var wr = new StringWriter();
            Console.SetOut(wr);

            var re = new StringReader("400");
            Console.SetIn(re);

            //Act
            Program.Main(new String[0]);

            //Assert
            var line = wr.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", line);
        }

        public void Test_ReadYearFromConsole_2()
        {
            
            //Arrange
            var wr = new StringWriter();
            Console.SetOut(wr);

            var re = new StringReader("703");
            Console.SetIn(re);

            //Act
            Program.Main(new String[0]);

            //Assert
            var line = wr.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", line);
        }

        [Fact]
        public void Test_1()
        {
            
        }

        [Fact]
        public void Test_2()
        {
            
        }
    }
}
