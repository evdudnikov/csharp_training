﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager ) : base(manager)
        {
        }

        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.GoToGroupsPage();
            InitNewGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }
        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(v);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();
            return this;
        }
        public GroupHelper Remove(int v)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(v);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }
        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + (index + 1) + "]/input")).Click();
            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public GroupHelper FillGroupForm(GroupData group)
        {

            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();

            return this;
        }
        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();

            return this;
        }

        public void EnsureGroupExists(int index)
        {
            manager.Navigator.GoToGroupsPage();
            if (!IsElementPresent(By.XPath("//*[@id='content']/form/span[" + (index + 1) + "]/input")))
            {
                Create(new GroupData("Test Group"));
            }
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> groups = new List<GroupData>();
            manager.Navigator.GoToGroupsPage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
            foreach (IWebElement element in elements) 
            {
               groups.Add(new GroupData(element.Text));
            }
            return groups;
        }
    }
}
