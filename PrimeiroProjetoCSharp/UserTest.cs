using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PrimeiroProjetoCSharp
{
    [TestFixture]
    class UserTest
    {
        User testUser;

        [SetUp]public void Init()
        {
            testUser = new User("Guilherme", "Reis Campos", 22);
        }
        [TestCase]
        public void assertFullName()
        {
            Assert.AreEqual(testUser.fullName(), "Guilherme Reis Campos");
        }
    }
}
