

namespace WebAddressbookTests
{
   public class TestBase
    {      

        protected ApplicationManager app;
        
        
      
        public void SetupTest()
        {
            app = new ApplicationManager();
            app.NavigationHelper.OpenHomepage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        public void TeardownTest()
        {
            app.Stop();
        }
     
       

     
        



    }


}
