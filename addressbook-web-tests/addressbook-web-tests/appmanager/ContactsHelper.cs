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

        public ContactsHelper AddNewContact()
        {
            AddNewContact();
            return this;
        }

       

        public ContactsHelper Modify(int v, ContactsData newContactsData)
        {
            SelectContact();
            InitContactsModification();
            FillContactForm(newContactsData);
            SubmitContactsModification();
            return this;
        }

        public ContactsHelper SubmitContactsModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactsHelper InitContactsModification()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }

        public ContactsHelper FillContactForm(ContactsData contacts)
        {
            FillContactForm(contacts);
            return this;
        }

       

       public ContactsHelper SubmitNewContact()
        {
            SubmitNewContact();
            return this;
        }

      


        public ContactsHelper SelectContact()
        {
            SelectContact();
            return this;
        }

       

        public ContactsHelper DeleteContact()
        {
            DeleteContact();
            return this;
        }

      
        public ContactsHelper ConfirmedWindow()
        {
            ConfirmedWindow();
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




