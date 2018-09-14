using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace WebAddressbookTests

{
    [TestFixture]
    public class LoginTest :TestBase 
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            //preparetion
            app.Auth.Logout();

            //action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login (account);

            // verification
            Assert.IsTrue(app.Auth.IsLoggedIn());
        }

        public void LoginWithInValidCredentials()
        {
            //preparetion
            app.Auth.Logout();

            //action
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);

            // verification
            Assert.IsFalse( app.Auth.IsLoggedIn());
        }


    }
}
