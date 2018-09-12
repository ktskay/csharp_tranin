using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests

{
    public class ContactsHelper : HelperBase
    {
        private bool acceptNextAlert;
        private object verificationErrors;

        public ContactsHelper(ApplicationManager manager) : base(manager)
        {

        }

      public ContactsHelper Modify(int v, ContactsData newContacts)
      {
          SelectContact();
          InitContactsModification();
          FillContactForm(newContacts);
          SubmitContactModification();
          

                return this;
      }

        public ContactsHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            return this;
        }

        public ContactsHelper InitContactsModification()
        {
            driver.FindElement(By.CssSelector("img[alt=\"Edit\"]")).Click();
            return this;

        }

        public ContactsHelper AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
    

        public ContactsHelper FillContactForm(ContactsData contacts)
        {
            Type(By.Name("firstname"), contacts.Firstname);
            Type(By.Name("middlename"), contacts.Middlename);
            Type(By.Name("lastname"), contacts.Lastname);
            return this;
        }

        public ContactsHelper SubmitNewContact()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }




        public ContactsHelper SelectContact()
        {
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }

        public ContactsHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactsHelper ConfirmedWindow()
        {
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }

                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }


        [TearDown]
            public void TeardownTest()
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
                Assert.AreEqual("", verificationErrors.ToString());
            }






    }
    }




