using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddressRemovalTests : AuthTestBase
    {

        [Test]
        public void AddressRemovalTest()
        {
            app.NewAddress.EnsureAddressExists();
            app.NewAddress.Remove();
            app.Auth.Logout();
        }
    }
}
