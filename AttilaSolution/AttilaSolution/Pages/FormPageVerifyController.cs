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

    /* This class have all the verify'ing methods from FormPage
     * Example: If you want to verify if the text is displayed in an element, the implementation will be on this class and etc.
     * 
     */
    class FormPageVerifyController
    {
        private IWebDriver driver = DriverFactory.getChromeDriver();
        private WebDriverWait wait = DriverFactory.getWebDriverWait();

        /*                                        *****   Web Elements Locators  *****                                               */
        private By doclerCompanyLogo() { return By.Id("dh_logo"); }
        private By formInputElement() { return By.Id("hello-input"); }
        private By formGoButton() { return By.Id("hello-submit"); }

        private By formH1Element() { return By.CssSelector("body > div > div.ui-test > h1"); }

        private By formPageButtonActiveTag() { return By.XPath("//*[@id=\"navbar\"]/ul/li[2]"); }

        private By formResponseElement() { return By.Id("hello-text"); }

        


        /*                                         *****  End Elements  *****                                                    */

        /*                                        *****  Methods which build the Logic  *****                                     */
        public String getTitleOfFormPage()
        {
            return driver.Title;
        }
        public Boolean logoIsPresent()
        {

            return TestUtils.isPresentElement(doclerCompanyLogo());
        }

        public Boolean inputIsPresent()
        {

            return TestUtils.isPresentElement(formInputElement());
        }
        public String theH1ElementOfFormPageIs()
        {
            return driver.FindElement(formH1Element()).Text;
        }
        public Boolean formButtonIsActive()
        {
            return TestUtils.isActiveElement(formPageButtonActiveTag());
        }

        public Boolean formPageInputIsDisplayed()
        {
            return TestUtils.isPresentElement(formInputElement());
        }

        public Boolean formPagSubmitButtonIsDisplayed()
        {
            return TestUtils.isPresentElement(formGoButton());
        }

        public String getTextOfSubmitMessage()
        {
            return driver.FindElement(formResponseElement()).Text;
        }



        



    }
}
