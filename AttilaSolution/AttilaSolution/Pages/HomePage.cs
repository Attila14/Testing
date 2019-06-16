using AttilaSolution.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttilaSolution.Pages
{
/*   @author
*    Attila Molnar 16 June 2019
* 
*/
    class HomePage
    {
        private HomePageActController act;
        private HomePageVerifyController verify;

        public HomePageActController acting()
        {
            return act;
        }

        public HomePageVerifyController verifyPage() {
            return verify;
        }

        // Hide the constructor of HomePage => you cannot instantiate it without parameters
        private HomePage() { }

        private HomePage(HomePageActController acting, HomePageVerifyController verifyPage) {
            this.act = acting;
            this.verify = verifyPage;
        }

        public static HomePage getHomePage() { return new HomePage(new HomePageActController(), new HomePageVerifyController()); }

    }
}
