using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;



namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsRemovalTests : TestBase

    {
     
      
        

        [Test]
        public void ContactsRemovalTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            SelectContacts();
            RemoveContact();
            ConfirmationWindow();
            ReturnToHomePage();
        }

     
       
        }

     
        }

        
    

