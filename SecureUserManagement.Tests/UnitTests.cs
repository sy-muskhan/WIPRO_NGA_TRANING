using NUnit.Framework;
using SecureUserManagement;

namespace SecureUserManagement.Tests
{
    public class Tests
    {
        private User user;
        [SetUp]
        public void Setup()
        {
            user = new User();
            user.Register("pass");
        }
        [Test]
        public void RegisterTest()
        {
            User user = new User();
            user.Register("pass");
            Assert.That(user.HashedPassword.Equals("pass"), Is.False);
        }

        [Test]
        public void AuthenticateSuccessTest()
        {
            User user = new User();
            user.Register("pass");
            Assert.That(user.Authenticate("pass"), Is.True);
        }

        [Test]
        public void AuthenticateFailTest()
        {
            User user = new User();
            user.Register("pass");
            Assert.That(user.Authenticate("wrong"), Is.False);
        }
    }
}
