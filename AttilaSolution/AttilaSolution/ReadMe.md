/*   @author
 *   Attila Molnar 16 June 2019
 */

The automation solution use the following design patterns - Fluent Object Model, Page Object Model,Singleton.

The test framwork used is NUnit, I have runned the test with VS.

Each page is divided through 3 classes(main,acting and verying controllers). 
- in the acting class, only the prerequisites methods are available. EX- navigation, click on X on Y etc.
- in verify class, only the verification methods will be available.  EX- return the pageTitle, return a boolean(element exists or not?).
- in "main"(FormPage,HomePage,ErrorPage), it's making all the instantiation in order to achieve the benefits for acting and verifying.

The tests, are runned from only 1 class since I could not separate the tests(in order to achieve negative tests,in one tests maybe we should access other page as well)
- By the book, it should be HomePage vs HomeTest , and in the HomePage would be all the logic + locators  and in the HomeTests should be all the tests implied
 for the HomePage. I have considered our small application to be a better fit for what I have did, but of course there are many options, not only this.

 - In order to obtain Single Responsability Principle, I have moved all the methods responsabile for setup and teardown in a different class.

- TestUtils is responsabile with all the helper methods, in order to achieve code reusability and readability.

Why I have choosed Fluent Object Model ? Because the user understand much easier the solution even if it's not a technical person.
  The downside is, it's more difficult to implement the framework.

Why I have choosed Singleton for webdriver instance ? Because I wanted to make sure that on entire solution at any point, I will have only one instance of
driver, so no conflicts will occur.

The solution is created on  - .NETFramework,Version=v4.5
                            - VS 2019 Community Edition
							- Selenium 3.141.0
							- NUnit 3.12
							- Chrome browser version 75.0.3770.90
