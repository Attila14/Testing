
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttilaSolution
/*   @author
 *   Attila Molnar 16 June 2019
 * 
 *   In this class I create the instance of the Webdriver, the rest of the classes use the composition principle to have access to the driver instance.
 */
{

    class DriverFactory
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;

        //We are using Singleton, so we want to prevent instantiation by using a private constructor
        private DriverFactory() { }

        public static IWebDriver getChromeDriver() {
            if (driver == null) {
                 driver = new ChromeDriver();
            }
            return driver;
        }
        public static WebDriverWait getWebDriverWait()
        {
            if (wait == null)
            {
                wait = new WebDriverWait(getChromeDriver(), TimeSpan.FromSeconds(30));
            }
            return wait;
        }
    }
}
