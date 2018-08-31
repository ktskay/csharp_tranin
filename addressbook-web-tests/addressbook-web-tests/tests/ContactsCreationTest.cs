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
            app.NavigationHelper.OpenHomepage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.AddNewContact();
            ContactsData contacts = new ContactsData ("lopux");            
            contacts.Middlename = "lop";
            contacts.Lastname = "lopuxov";
            app.Contacts. FillContactForm(contacts);
            app.Contacts.SubmitNewContact();
            




        }
    }
}
    


