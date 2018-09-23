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
    public class GroupHelper : HelperBase
    {




        public GroupHelper(ApplicationManager manager) : base(manager)
        {
        }



        public GroupHelper Create(GroupData group)
        {
            manager.NavigationHelper.GotoGroupsPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturntoGroupsPage();

            return this;
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> groups = new List<GroupData>();
            manager.NavigationHelper.GotoGroupsPage();
            ICollection<IWebElement> elements=driver.FindElements(By.CssSelector("span.group"));
            foreach (IWebElement element in elements)
            {
                GroupData group = new GroupData(element.Text);
                groups.Add(group);
            }

            return groups ;
        }

        public GroupHelper Modify(int v, GroupData  newData)
        {
            manager.NavigationHelper.GotoGroupsPage();
            SelectGroup(v);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturntoGroupsPage();

            return this;
        }

       

        public GroupHelper Remove(int v)
        {
            manager.NavigationHelper.GotoGroupsPage();
            SelectGroup(v);
            RemoveGroup();
            ReturntoGroupsPage();
            return this;

        }


        public GroupHelper InitGroupCreation(int index)
        {
            if (IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + index + "]")))
            {
                driver.FindElement((By.XPath("(//input[@name='selected[]'])[" + index + "]")));
            }
            else
            {
                driver.FindElement(By.Name("new")).Click();
            }

            return this;
        }
        public GroupHelper FillGroupForm(GroupData group)
        {
           

            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            
            return this;
        }

       

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public GroupHelper ReturntoGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
           


            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }
    }
}

