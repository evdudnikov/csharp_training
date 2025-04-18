﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class AddressHelper : HelperBase
    {
        public AddressHelper(ApplicationManager manager) : base(manager)
        {
        }

        public AddressHelper Create(AddressData group)
        {
            manager.Navigator.GoToAddressPage();
            FillAddressForm(group);
            SubmitAddressCreation();
            ReturnToHomePage();
            return this;
        }

        public AddressHelper Modify(AddressData newData)
        {
            manager.Navigator.OpenHomePage();
            InitAddressModification();
            EditAddressForm(newData);
            SubmitAddressModification();
            ReturnToHomePage();           
            return this;
        }

        public AddressHelper Remove()
        {
            manager.Navigator.OpenHomePage();
            SelectAddress();
            RemoveAddress();
            ReturnToHomePage();
            return this;
        }

        public AddressHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }

        public AddressHelper SelectAddress()
        {
            driver.FindElement(By.XPath("//*[@id='maintable']//tr[2]/td[1]")).Click();
            return this;
        }

        public AddressHelper InitAddressModification()
        {
            driver.FindElement(By.XPath("//*[@id='maintable']//tr[2]/td[8]")).Click();
            return this;
        }

        public AddressHelper SubmitAddressModification()
        {
            driver.FindElement(By.XPath("//input[@value='Update']")).Click();
            return this;
        }

        public AddressHelper RemoveAddress()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public AddressHelper SubmitAddressCreation()
        {
            driver.FindElement(By.XPath("//input[@value='Enter'][2]")).Click();
            return this;
        }

        public AddressHelper FillAddressForm(AddressData group)
        {
            Type(By.Name("firstname"), group.FirstName);
            driver.FindElement(By.Name("middlename")).Click();
            Type(By.Name("lastname"), group.LastName);
            driver.FindElement(By.Name("nickname")).Click();
            driver.FindElement(By.Name("title")).Click();
            driver.FindElement(By.Name("company")).Click();
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("home")).Click();
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("work")).Click();
            driver.FindElement(By.Name("fax")).Click();
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email2")).Click();
            driver.FindElement(By.Name("email3")).Click();
            driver.FindElement(By.Name("homepage")).Click();
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("new_group")).Click();
            return this;
        }

        public AddressHelper EditAddressForm(AddressData group)
        {
            Type(By.Name("firstname"), group.FirstName);
            driver.FindElement(By.Name("middlename")).Click();
            Type(By.Name("lastname"), group.LastName);
            driver.FindElement(By.Name("nickname")).Click();
            driver.FindElement(By.Name("title")).Click();
            driver.FindElement(By.Name("company")).Click();
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("home")).Click();
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("work")).Click();
            driver.FindElement(By.Name("fax")).Click();
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email2")).Click();
            driver.FindElement(By.Name("email3")).Click();
            driver.FindElement(By.Name("homepage")).Click();
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.Name("ayear")).Click();
            return this;
        }
        public void EnsureAddressExists()
        {
            var addresses = driver.FindElements
                (By.XPath("//*[@id='maintable']//tr"));
            if (addresses.Count <= 1) 
            {
                Create(new AddressData("Test", "User")); 
            }
        }
    }
}