﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddressCreationTests : TestBase
    {

        [Test]
        public void AddressCreationTest()
        {
            AddressData group = new AddressData("Mike", "Adrian");

            app.NewAddress.Create(group); 
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
