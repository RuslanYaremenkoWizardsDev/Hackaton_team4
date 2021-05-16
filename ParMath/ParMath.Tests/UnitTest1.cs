using NUnit.Framework;
using ParMath.Class;
using ParMath.Interface;

namespace ParMath.Tests
{
    public class Tests
    {
        private Engine _engine;
        private User _firstUser;

        [SetUp]
        public void Setup()
        {
            _engine = new Engine();
            _firstUser = User.CreateUser("Shaitan", "111111");
        }

        [Test]
        public void TestAddToDictionary()
        {
            _engine.AddToDictionary(_firstUser);
            Assert.Equals(1, _engine.AllUser.Count); 
        }

        [TestCase]
        public void FindInDictionaryUser()
        {
            
        }
    }
}