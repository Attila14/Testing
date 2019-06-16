using AttilaSolution.Pages;
using AttilaSolution.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttilaSolution.Tests
/*   @author
 *   Attila Molnar 16 June 2019
 * 
 */
{
    [TestFixture]
    class Tests
    {
        private HomePage homePage   = HomePage.getHomePage();
        private FormPage formPage   = FormPage.getFormPage();
        private ErrorPage errorPage = ErrorPage.getFormPage();
        private Setup_TearDown prerequisitesObj = new Setup_TearDown();


        [SetUp]
        public void beforeEachTestRunThis() {

            prerequisitesObj.navigateToHomePageAndMaximizeWindow();
        }

        /* REQ-UI-01 - The Title should be "UI Testing Site" on every site  */

        [Test]
        public void Test_titleShouldBe_UiTestingSite_OnEveryPage()
        {

            /* Verify Home Page title  */
            String actualTitle = homePage.verifyPage().getTitleOfHomePage();
            Assert.AreEqual("UI Testing Site", actualTitle);

            /* Verify Form Page title  */
            formPage.acting().navigateToFormPage();

            actualTitle = formPage.verifyPage().getTitleOfFormPage();
            Assert.AreEqual("UI Testing Site", actualTitle);

            /* Verify the site title from the Hello page */
            formPage.acting().introduceValueInFormInputAndSubmit("Attila");

            actualTitle = formPage.verifyPage().getTitleOfFormPage();
            Assert.AreEqual("UI Testing Site", actualTitle);

        }

        /* REQ-UI-02 - The Company Logo should be visible on every site */

        [Test]
        public void Test_companyLogoShould_BePresent_OnEveryPage()
        {

            /* Verify if the company logo is displayed on Home Page.  */
            Assert.IsTrue(homePage.verifyPage().logoIsPresent());

            /* Verify if the company logo is displayed on Form Page.  */
            formPage.acting().navigateToFormPage();
            Assert.IsTrue(formPage.verifyPage().logoIsPresent());

            /* Verify if the company logo is displayed on Hello Page.  */
            formPage.acting().introduceValueInFormInputAndSubmit("Attila");
            Assert.IsTrue(formPage.verifyPage().logoIsPresent());

        }

        /* REQ-UI-03 - When I click on the Home button, I should get navigated to the Home page   */
        [Test]
        public void Test_homeButton_ShouldDisplay_HomePage()
        {
            /* Since the default page displayed is Home Page , we should make sure that the HomePage button is working by first navigate to Form page
             * and after by pressing the Home button from the menu, the Home Page will be displayed  */

            formPage.acting().navigateToFormPage();
            homePage.acting().navigateToHomePage();
            Assert.AreEqual("Welcome to the Docler Holding QA Department", homePage.verifyPage().h1ElementOfHomePageIs());
        }

        
        /* REQ-UI-04 - When I click on the Home button, it should turn to active status   */
        [Test]
        public void Test_ifHomeBtnIsActive_whenIsClicked()
        {
            /* Since the default page displayed is Home Page, we should verify if the Home button is displayed even if we didn't clicked 
             * the Home button.
             * */
            Assert.IsTrue(homePage.verifyPage().homeButtonIsActive());

            formPage.acting().navigateToFormPage();
            Assert.IsFalse(homePage.verifyPage().homeButtonIsActive());

            homePage.acting().navigateToHomePage();
            Assert.IsTrue(homePage.verifyPage().homeButtonIsActive());

        }

        /* REQ-UI-05 - When I click on the Form button, I should get navigated to the Form page   */
        [Test]
        public void Test_formButton_ShouldDisplay_FormPage()
        {

            formPage.acting().navigateToFormPage();
            Assert.IsTrue(formPage.verifyPage().inputIsPresent());
            Assert.AreEqual("Simple Form Submission", formPage.verifyPage().theH1ElementOfFormPageIs());

        }

        /* REQ-UI-06 - When I click on the Home button, it should turn to active status   */
        [Test]
        public void Test_ifFormBtnIsActive_whenIsClicked()
        {

            formPage.acting().navigateToFormPage();
            Assert.IsTrue(formPage.verifyPage().formButtonIsActive());

            homePage.acting().navigateToHomePage();
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(formPage.verifyPage().formButtonIsActive());

        }

        /* REQ-UI-07 - When I click on the Error button, I should get a 404 HTTP response code   */
        [Test]
        public void Test_errorPageShouldReturn404Error()
        {

            errorPage.acting().navigateToErrorPage();
            Assert.IsTrue(errorPage.verifyPage().errorIsPresent());
            Assert.AreEqual("404 Error: File not found :-)", errorPage.verifyPage().getErrorPageTitle());

        }

        /* REQ-UI-08 - When I click on the UI Testing button, I should get navigated to the Home page   */
        [Test]
        public void Test_ClickingOn_UITestingBtn_ShouldGoToHomePage()
        {
            homePage.acting().clickingOnUITestingBtn();
            Assert.AreEqual("Welcome to the Docler Holding QA Department", homePage.verifyPage().h1ElementOfHomePageIs());

        }

        /* REQ-UI-09 - The following text should be visible on the Home page in <h1> tag:
         *             "Welcome to the Docler Holding QA Department"   */
        [Test]
        public void Test_h1TagOnHomePage()
        {
            Assert.AreEqual("Welcome to the Docler Holding QA Department", homePage.verifyPage().h1ElementOfHomePageIs());
            formPage.acting().navigateToFormPage();
            Assert.AreNotEqual("Welcome to the Docler Holding QA Department", homePage.verifyPage().h1ElementOfHomePageIs());

        }
        /* REQ-UI-10 - Feature: The following text should be visible on the Home page in <p> tag: 
         *             "This site is dedicated to perform some exercises and demonstrate automated web testing."
         */
        [Test]
        public void Test_pTagOnHomePage()
        {
            Assert.AreEqual("This site is dedicated to perform some exercises and demonstrate automated web testing.", 
                            homePage.verifyPage().p_ElementOfHomePageIs());
        }

        /* REQ-UI-11 - Feature: On the Form page, a form should be visible with one input box and one submit button"
        */
        [Test]
        public void Test_formPageInputAndSubmitButton_Presence()
        {
            formPage.acting().navigateToFormPage();

            Assert.IsTrue(formPage.verifyPage().formPageInputIsDisplayed());
            Assert.IsTrue(formPage.verifyPage().formPagSubmitButtonIsDisplayed());

        }

        /* REQ-UI-12 - Feature: On the Form page, if you type <value> the input field and submit 
         *             the form, you should get redirect to the Hello page, and the following text should appear: <value> <result> 
         */
        [Test]
        public void Test_inputFunctionalityOnFormPage()
        {
            formPage.acting().navigateToFormPage();
            formPage.acting().introduceValueInFormInputAndSubmit("Attila");
            Assert.AreEqual("Hello Attila!", formPage.verifyPage().getTextOfSubmitMessage());

            formPage.acting().navigateToFormPage();
            formPage.acting().introduceValueInFormInputAndSubmit("53124236");
            Assert.AreEqual("Hello 53124236!", formPage.verifyPage().getTextOfSubmitMessage());

        }



        [TearDown]
        public void cleanUp() {
            prerequisitesObj.closeBrowser();
        }
    }
}
