using NUnit.Framework;
using ParMath.Class;
using ParMath.Interface;

namespace ParMath.Tests
{
    public class Tests
    {
        private Engine _engine;
        private User _firstUser;
        private User _invalideUser; 

        [SetUp]
        public void Setup()
        {
            _engine = Engine.GetEngine();
            _firstUser = User.CreateUser("Shaitan", "111111");
            _invalideUser = User.CreateUser("Sh", "000");
            _engine.Users.Add(_firstUser);
        }

        [Test]
        public void TestAddOneUser()
        {
            Assert.AreEqual(1, _engine.Users.Count);
        }

        [Test]
        public void TestSeeds()
        {
            _engine.Seeds(7);
            Assert.AreEqual(8, _engine.Users.Count);
        }

        [Test]
        public void TestFindUsers()
        {
            Assert.AreEqual(true, _engine.FindUser("Shaitan", "111111"));
            Assert.AreEqual(false, _engine.FindUser("Demon", "1111111"));
        }

        [Test]
        public void TestUniquelyUser()
        {
            Assert.AreEqual(false, _engine.UniquelyUser("Shaitan"));
            Assert.AreEqual(true, _engine.UniquelyUser("Demon"));
        }
    }
}