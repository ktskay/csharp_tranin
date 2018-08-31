

namespace WebAddressbookTests
{
   public class TestBase
    {      

        protected ApplicationManager app;
        
        
      
        public void SetupTest()
        {
            app = new ApplicationManager();
        }

        public void TeardownTest()
        {
            app.Stop();
        }
     
       

     
        



    }


}
