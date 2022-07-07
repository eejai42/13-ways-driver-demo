using NUnit.Framework;
using System;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var command = new InputType0Command("0220558000");
            if (!command.IsValid)
            {
                command.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid command: {command.InputString}");
            }
            else
            {
                Assert.IsTrue(command.Wash_Category == 22, $"Wash Category {command.Wash_Category} not 22 as expected.");
                Assert.IsTrue(command.Initial_Volume == 55, $"Wash Category {command.Initial_Volume} not 55 as expected.");
                Assert.IsTrue(command.Flow_Rate == 8, $"Wash Category {command.Flow_Rate} not 8 as expected.");
            }
        }
    }
}