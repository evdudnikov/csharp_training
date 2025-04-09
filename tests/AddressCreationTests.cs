using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddressCreationTests : AuthTestBase
    {

        [Test]
        public void AddressCreationTest()
        {
            AddressData newAddress = new AddressData("Mike", "Adrian");

            app.NewAddress.Create(newAddress);
            app.Auth.Logout();
        }

        [Test]
        public void EmptyAddressCreationTest()
        {
            AddressData group = new AddressData("", "");

            app.NewAddress.Create(group);
            app.Auth.Logout();
        }
    }
}
