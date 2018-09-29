using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {     
      

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Create(group);

            List<GroupData> newGroups = app.Groups.GetGroupList();
			oldGroups.Add(group);
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";


            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);

        }
    }
}

