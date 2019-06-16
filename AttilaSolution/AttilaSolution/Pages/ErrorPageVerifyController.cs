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

    /* This class have all the verify'ing methods from ErrorPage
     * Example: If you want to verify if the text is displayed in an element, the implementation will be on this class and etc.
     * 
     */
    class ErrorPageVerifyController
    {
        private IWebDriver driver = DriverFactory.getChromeDriver();

        /*   In order to not have many dependencies, I have choosed to not use PageFactory pattern, 
         *   instead I'm using a private class attribute of type IWebElement. 
         */

        /*                                        *****   Web Elements Locators  *****                                               */

        private By errorPage404ErrorElement() { return By.XPath("/html/body/h1"); }


        /*                                         *****  End Elements  *****                                                    */


        /*                                        *****  Methods which build the Logic  *****                                     */
        public String getErrorPageTitle()
        {
            return driver.Title;
        }
        public Boolean errorIsPresent()
        {
            return TestUtils.isPresentElement(errorPage404ErrorElement());
        }
    }
}