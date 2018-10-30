using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactInformationTests : AuthTestBase
    {
        //Задание №12: реализовать тесты для проверки детальной информации о контакте
        [Test]
        public void ContactEditInformationTest()
        {
            int index = 0;
            ContactData fromTable = app.Contacts.GetContactInformationFromTable(index);
            ContactData fromEdit = app.Contacts.GetContactInformationFromEditForm(index);

            Assert.AreEqual(fromTable, fromEdit);
            Assert.AreEqual(fromTable.Address, fromEdit.Address);
            Assert.AreEqual(fromTable.AllEmails, fromEdit.AllEmails);
            Assert.AreEqual(fromTable.AllPhones, fromEdit.AllPhones);
        }

        //Реализовать тест, который проверяет, что для некоторого отдельно взятого контакта информация на главной странице (в таблице) соответствует информации, представленной в форме редактирования контакта (где задаются все его свойства).
        [Test]
        public void ContactViewInformationTest()
        {
            int index = 0;

            ContactData fromEdit = app.Contacts.GetContactInformationFromEditForm(index);
            ContactData fromView = app.Contacts.GetContactInformationFromViewForm(index);

            Assert.AreEqual(fromEdit.View, fromView.View);
        }
    }
}
