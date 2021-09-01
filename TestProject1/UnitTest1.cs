using NUnit.Framework;
using WebApplication2.Models;


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

            TodoItem item = new TodoItem();
            double res = item.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
      
    }
}