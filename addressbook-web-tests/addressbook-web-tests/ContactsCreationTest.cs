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
            OpenHomepage();
            Login(new AccountData("admin", "secret"));
            AddNewContact();
            ContactsData contacts = new ContactsData ("lopux");            
            contacts.Middlename = "lop";
            contacts.Lastname = "lopuxov";
            FillContactForm(contacts);
            SubmitNewContact();
            



        }
    }
}
    


