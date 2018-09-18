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
            app.Contacts.AddNewContact();
            ContactsData contacts = new ContactsData("lopux");
            contacts.Middlename = "lop";
            contacts.Lastname = "lopuxov";


            app.Contacts
                .FillContactForm(contacts)
                .SubmitNewContact();


        }
        [Test]
        public void EmptyContactCreationTest()

        {

            app.Contacts.AddNewContact();
            ContactsData contacts = new ContactsData("");
            contacts.Middlename = "";
            contacts.Lastname = "";


            app.Contacts
                .FillContactForm(contacts)
                .SubmitNewContact();

        }


    }
}
    


