using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : TestBase
    {

        [Test]
        public void ContactCreationTest()

        {
            navigationHelper.OpenHomepage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactsHelper.AddNewContact();
            ContactsData contacts = new ContactsData ("lopux");            
            contacts.Middlename = "lop";
            contacts.Lastname = "lopuxov";
            contactsHelper. FillContactForm(contacts);
            contactsHelper.SubmitNewContact();
            




        }
    }
}
    


