using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests:TestBase
    {
       

        [Test]
        public void GroupRemovalTest()
        {
           navigationHelper.OpenHomepage();
           loginHelper.Login(new AccountData("admin","secret"));
            navigationHelper.GotoGroupsPage();
            groupHelper.SelectGroup(1);
            groupHelper.RemoveGroup();
            groupHelper.ReturntoGroupsPage();
        }

       
        

       

        
      
    }
}
