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
    public class NavigationHelper : HelperBase 
    {
        
        public string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseUrl ) 
            : base(manager)
        {
            baseURL = baseUrl;
        }

        public void GoToHomepage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }


        public void GotoGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }

            if (driver != null)
            {
                driver.FindElement(By.LinkText("groups")).Click();
            }
        }
    }
}
