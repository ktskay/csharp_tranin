using System;
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
    public class ContactsRemovalTest : TestBase 
    {
       

        [Test]
        public void ContactRemovalTest()
        {
            
            app.Contacts.SelectContact();
            app.Contacts.DeleteContact();
            app.Contacts.ConfirmedWindow();
            
        }


        }
    }

