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
            AddressData newData = new AddressData("John", "Cena");

            app.NewAddress.Modify(newData);
            app.Auth.Logout();
        }
    }
}
