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

		public string BaseUrl;

		public NavigationHelper(ApplicationManager manager, string baseUrl)
			: base(manager)
		{
			BaseUrl = baseUrl;
		}

		public void GoToHomepage()
		{
			if (driver.Url == BaseUrl + "/addressbook/")
			{
				return;
			}
			driver.Navigate().GoToUrl(BaseUrl + "/addressbook/");
		}


		public void GotoGroupsPage()
		{
			if (driver.Url == BaseUrl + "/addressbook/group.php"
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
