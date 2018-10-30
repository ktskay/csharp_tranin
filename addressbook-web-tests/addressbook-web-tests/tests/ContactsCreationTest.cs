using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : AuthTestBase
    {

        [Test]
        public void ContactCreationTest()
        {
	        List<ContactsData> oldContact = app.Contacts.GetContactsList();

			app.Contacts.AddNewContact();
            ContactsData contacts = new ContactsData("lopux");
            contacts.Middlename = "lop";
            contacts.Lastname = "lopuxov";

            
            app.Contacts
                .FillContactForm(contacts)
                .SubmitNewContact();

			

            List<ContactsData> newContact = app.Contacts.GetContactsList();
			oldContact.Add(contacts);
			oldContact.Sort();
			newContact.Sort();
            Assert.AreEqual(oldContact, newContact);


        }
        [Test]
        public void EmptyContactCreationTest()

        {
	        List<ContactsData> oldContact = app.Contacts.GetContactsList();

			app.Contacts.AddNewContact();
            ContactsData contacts = new ContactsData("");
            contacts.Middlename = "";
            contacts.Lastname = "";


            
            app.Contacts
                .FillContactForm(contacts)
                .SubmitNewContact();


            List<ContactsData> newContact = app.Contacts.GetContactsList();
            Assert.AreEqual(oldContact.Count + 1, newContact.Count);
        }


    }
}
    


