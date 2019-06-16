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

    /* This class have all the verify'ing methods from HomePage
     * Example: If you want to verify if the text is displayed in an element, the implementation will be on this class and etc.
     * 
     */
    class HomePageVerifyController
    {
        private IWebDriver driver = DriverFactory.getChromeDriver();
        private WebDriverWait wait = DriverFactory.getWebDriverWait();

        /*   In order to not have many dependencies, I have choosed to not use PageFactory pattern, 
         *   instead I'm using a private class attribute of type IWebElement. 
         */

        /*                                        *****   Web Elements Locators  *****                                               */
        private By doclerCompanyLogo() { return By.Id("dh_logo"); }
        private By homePageH1Element() { return By.CssSelector("body > div > div.ui-test > h1"); }
        private By homePageButtonElement() { return By.Id("home"); }

        private By homePageButtonActiveTag() { return By.XPath("//*[@id=\"navbar\"]/ul/li[1]"); }

        private By pTagFromHomePageElement() { return By.XPath("/html/body/div/div[1]/p"); }
        






        /*                                         *****  End Elements  *****                                                    */


        /*                                        *****  Methods which build the Logic  *****                                     */
        public String getTitleOfHomePage()
        {
            return driver.Title;      
        }
        public Boolean logoIsPresent()
        {
            return TestUtils.isPresentElement(doclerCompanyLogo());
        }

        public String h1ElementOfHomePageIs()
        {
            return TestUtils.getTextOfElement(homePageH1Element());
        }

        public Boolean homeButtonIsActive()
        {
            return TestUtils.isActiveElement(homePageButtonActiveTag());
        }

        public String p_ElementOfHomePageIs()
        {
            return TestUtils.getTextOfElement(pTagFromHomePageElement());
        }
    }
}



