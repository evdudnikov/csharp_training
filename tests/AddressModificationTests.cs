using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddressModificationTests : AuthTestBase
    {
        [Test]
        public void AddressModificationTest()
        {
            app.NewAddress.EnsureAddressExists();

            AddressData newAddress = new AddressData("John", "Cena");

            app.NewAddress.Modify(newAddress);
            app.Auth.Logout();
        }
    }
}
