using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests

{
    public class ContactsHelper
    {
         
        private IWebDriver driver;


        public ContactsHelper(IWebDriver driver)
        {
            this.driver = driver;

        }
        public void AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void FillContactForm(ContactsData contacts)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contacts.Firstname);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contacts.Middlename);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contacts.Lastname);
        }
        public void SubmitNewContact()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
    }
}
