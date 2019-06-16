using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttilaSolution.Utils
{
    /*   @author
     *    Attila Molnar 16 June 2019
     * 
     * 
     *   The role of this class is to have all the methods for setup and tear-down of tests.
     *   
     */
    class Setup_TearDown
    {
        private IWebDriver driver = DriverFactory.getChromeDriver();


        /*                                        *****  Method for SetupTests before each method  *****                          */
       public void navigateToHomePageAndMaximizeWindow()
        {
            TestUtils.navigateTo("http://uitest.duodecadits.com/");
            driver.Manage().Window.FullScreen();

        }

        /*                                        *****  Method for TearDown  *****                                               */
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
