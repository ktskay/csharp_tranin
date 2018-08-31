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
    public class NavigationHelper : HelperBase 
    {
        
        private string baseURL;

        public NavigationHelper(ApplicationManager manager) : base(manager)
        {
            this.baseURL = manager.Driver;
        }
        public void OpenHomepage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }


        public void GotoGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
