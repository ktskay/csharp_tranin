﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactsHelper contactsHelper;

        public ApplicationManager()
        {
                  
            loginHelper = new LoginHelper(this );
            navigationHelper = new NavigationHelper(this);
            groupHelper = new GroupHelper(this);
            contactsHelper = new ContactsHelper(this);
        }

        public string Driver
        {
            get
            {
                return driver;
            }
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }
        public NavigationHelper NavigationHelper
        {
            get
            {
                return navigationHelper;
            }
        }
         public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }
          public ContactsHelper Contacts
        {
            get
            {
                return contactsHelper;
            }
        }

        
    }
}
