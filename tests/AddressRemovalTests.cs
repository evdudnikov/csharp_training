using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddressRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);
            app.Auth.Logout();
        }
    }
}
