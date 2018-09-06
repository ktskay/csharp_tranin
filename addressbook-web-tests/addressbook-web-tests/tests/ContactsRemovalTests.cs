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
           app.NavigationHelper.GoToHomepage() ;
           app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.SelectContacts(1);
            app.Contacts.RemoveContact();
           app.Contacts.ConfirmationWindow();
          
        }

     
       
        }

     
        }

        
    

