﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;


        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactsHelper contactsHelper;
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>() ;


        private  ApplicationManager()
        {

            FirefoxOptions options = new FirefoxOptions();
            options.UseLegacyImplementation = true;
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox/firefox.exe";
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost";
            verificationErrors = new StringBuilder();
            

            loginHelper = new LoginHelper(this );
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactsHelper = new ContactsHelper(this);
        }

         ~ApplicationManager()
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


        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.NavigationHelper.GoToHomepage();
                app.Value = newInstance;
               
            }
            return app.Value;
        }

        

        public IWebDriver Driver 
        {
            get
            {
                return driver;
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
