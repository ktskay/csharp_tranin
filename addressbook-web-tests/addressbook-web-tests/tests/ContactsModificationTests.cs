using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAddressbookTests;

namespace WebAddressbookTests
{
    [TestFixture ]
    class ContactsModificationTests : TestBase 
    {
        [Test]
        public void ContactsModificationTest()
        {
            
            ContactsData newContactsData  = new ContactsData("vasek");
            newContactsData.Middlename = "vasekovich";
            newContactsData.Lastname = "vasilkov";
            app.Contacts
                .FillContactForm(newContactsData)
                .SubmitNewContact();

            app.Contacts.Modify(1, newContactsData );

        }
    }
}
