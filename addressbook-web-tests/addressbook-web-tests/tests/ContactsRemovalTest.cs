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
    public class ContactsRemovalTest : AuthTestBase
    {
       

        [Test]
        public void ContactRemovalTest()
        {
	        List<ContactsData> oldContact = app.Contacts.GetContactsList();

			app.Contacts
                .SelectContact()
                .DeleteContact()
                .ConfirmedWindow();

	        List<ContactsData> newContact = app.Contacts.GetContactsList();
	        oldContact.RemoveAt(0);

	        Assert.AreEqual(oldContact, newContact);

		}


        }
    }

