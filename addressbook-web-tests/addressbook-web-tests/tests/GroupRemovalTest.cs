﻿using System;
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
           
            app.NavigationHelper.GotoGroupsPage();
            app.Groups
            .SelectGroup(1)
            .RemoveGroup()
            .ReturntoGroupsPage();
        }

       
        

       

        
      
    }
}
