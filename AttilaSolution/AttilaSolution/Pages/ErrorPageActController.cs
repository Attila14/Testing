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
     * The role of this class is to create the prerequisites for HomePage.
     * Example: All the navigation, clicking etc.
     * 
     */
    class ErrorPageActController
    {
        private IWebDriver driver = DriverFactory.getChromeDriver();

        public ErrorPageActController navigateToErrorPage()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/error");
            return this;
        }
    }
}

