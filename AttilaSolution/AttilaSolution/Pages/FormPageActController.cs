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

    class FormPageActController
    {
        private IWebDriver driver = DriverFactory.getChromeDriver();
        private WebDriverWait wait = DriverFactory.getWebDriverWait();

        /*                                        *****   Web Elements Locators  *****                                               */
        private By formInputElement() { return By.Id("hello-input"); }
        private By formGoButton()     { return By.Id("hello-submit"); }



        /*                                         *****  End Elements  *****                                                        */

        public FormPageActController navigateToFormPage()
        {
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
            return this;
        }

        /* This method will introduce some text in the input field and will press the Go button which will navigate to Hello ! page   */
        public FormPageActController introduceValueInFormInputAndSubmit(String text)
        {
            TestUtils.sendTextToAnElementBy(formInputElement(), text);
            TestUtils.clickOnClickableElement(formGoButton());

            return this;
        }


    }
}
