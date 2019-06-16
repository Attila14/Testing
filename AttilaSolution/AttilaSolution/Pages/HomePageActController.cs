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

    class HomePageActController
    {
        private IWebDriver driver = DriverFactory.getChromeDriver();
        private WebDriverWait wait = DriverFactory.getWebDriverWait();

        /*   In order to not have many dependencies, I have choosed to not use PageFactory pattern, 
         *   instead I'm using a private class attribute of type IWebElement. 
         */

        /*                                        *****   Web Elements Locators  *****                                               */
        private By homePageButtonElement() { return By.Id("home"); }
        private By uiTestingButtonElement() { return By.Id("site"); }
        




        /*                                         *****  End Elements  *****                                                    */



        /*                                        *****  Methods which build the Logic  *****                                     */
        public HomePageActController navigateToHomePage()
        {
            TestUtils.clickOnClickableElement(homePageButtonElement());
            return this;
        }
        public HomePageActController clickingOnUITestingBtn()
        {
            /* Clicking on UI Testing button, should display the Home Page.  */

            TestUtils.clickOnClickableElement(uiTestingButtonElement());
            return this;
        }
    }
}
