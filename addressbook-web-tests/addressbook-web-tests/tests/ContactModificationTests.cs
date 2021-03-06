﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : ContactTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("ztest1", "ztest2");
            int num = 0;

            //интеллектуальность теста
            if (!app.Contacts.FindContact(num))
            {
                ContactData data = new ContactData("contactModif", "contactModif");
                app.Contacts.Create(data);
            }

            List<ContactData> oldContacts = ContactData.GetAll(); //Сравнение данных из БД и интерфейса
            ContactData oldData = oldContacts[num];

            app.Contacts.Modify(oldData, newData);

            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactCount());

            List<ContactData> newContacts = ContactData.GetAll(); //Сравнение данных из БД и интерфейса
            oldData.Lastname = newData.Lastname;
            oldData.Firstname = newData.Firstname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            foreach (ContactData contact in newContacts)
            {
                if (contact.Id == oldData.Id)
                {
                    Assert.AreEqual(newData.Lastname, contact.Lastname);
                    Assert.AreEqual(newData.Firstname, contact.Firstname);
                }
            }
        }
    }
}
