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
            AddNewContact();
            ContactsData contacts = new ContactsData ("lopux");            
            contacts.Middlename = "lop";
            contacts.Lastname = "lopuxov";
            FillContactForm(contacts);
            SubmitNewContact();
            


        private void FilloutForm(ContactsData contacts)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contacts.Firstname);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contacts.Middlename);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contacts.Lastname);
        }

        }
    }
}
    


