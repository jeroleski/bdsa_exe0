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
            bool l = Program.IsLeapYear(4024);
            Assert.True(l);
        }

        [Fact]
        public void Test_DivBy4_2()
        {
            bool l = Program.IsLeapYear(4015);
            Assert.False(l);
        }

        [Fact]
        public void Test_DivBy100_1()
        {
            bool l = Program.IsLeapYear(1808);
            Assert.True(l);
        }

        [Fact]
        public void Test_DivBy100_2()
        {
            bool l = Program.IsLeapYear(1700);
            Assert.False(l);
        }

        [Fact]
        public void Test_DivBy100_3()
        {
            bool l = Program.IsLeapYear(2099);
            Assert.False(l);
        }

        [Fact]
        public void Test_DivBy400_1()
        {
            bool l = Program.IsLeapYear(1600);
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
            bool l = Program.IsLeapYear(1900);
            Assert.False(l);
        }

        [Fact]
        public void Test_DivBy400_4()
        {
            bool l = Program.IsLeapYear(1697);
            Assert.False(l);
        }

        [Fact]
        public void Test_ReadYearFromConsole_1()
        {
            //Arrange
            var wr = new StringWriter();
            Console.SetOut(wr);

            var re = new StringReader("2000");
            Console.SetIn(re);

            //Act
            Program.Main(new String[0]);

            //Assert
            var line = wr.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", line);
        }

        [Fact]
        public void Test_ReadYearFromConsole_2()
        {
            //Arrange
            var wr = new StringWriter();
            Console.SetOut(wr);

            var re = new StringReader("1703");
            Console.SetIn(re);

            //Act
            Program.Main(new String[0]);

            //Assert
            var line = wr.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", line);
        }

        [Fact]
        public void Test_IsNotYear()
        {
            //Arrange
            var wr = new StringWriter();
            Console.SetOut(wr);

            var re = new StringReader("bonjourno");
            Console.SetIn(re);

            //Act
            Program.Main(new String[0]);

            //Assert
            var line = wr.GetStringBuilder().ToString().Trim();
            Assert.Equal("Bish, you must write number!", line);
        }

        [Fact]
        public void Test_OnlyAfter1582()
        {
            bool l = Program.IsLeapYear(1580);
            Assert.False(l);
        }
    }
}
