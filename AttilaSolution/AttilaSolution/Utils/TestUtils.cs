using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
 *   In this class, will find all the helper methods, in order to have consistency through code we should re-use the methods.
 */
    class TestUtils
    {
        private static IWebDriver driver = DriverFactory.getChromeDriver();
        private static WebDriverWait wait = DriverFactory.getWebDriverWait();

        public static void clickOnClickableElement(By by)
        {
            /* Wait until the element is visible and afterwards click on it  */
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(by));         
            element.Click();
        }
        public static void navigateTo(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static String getTextOfElement(By by)
        {
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(by));
            return element.Text;
        }
        public static void sendTextToAnElementBy(By by,String textToSend)
        {
            IWebElement elem = wait.Until(ExpectedConditions.ElementToBeClickable(by));
            elem.SendKeys(textToSend);
        }

        public static Boolean isPresentElement(By by) {
            IWebElement elem = wait.Until(ExpectedConditions.ElementIsVisible(by));
            return driver.FindElement(by).Displayed;
        }

        public static Boolean isActiveElement(By by) {
            IWebElement elem = wait.Until(ExpectedConditions.ElementIsVisible(by));
            return driver.FindElement(by).GetAttribute("class").Contains("active");
        }



    }
}
