using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAddressbookTests;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            
            ContactsData newContacts = new ContactsData("petr");
            newContacts.Middlename = "petrovich";
            newContacts.Lastname = "petrov";


            app.Contacts.Modify(1, newContacts);


        }
    }
}
