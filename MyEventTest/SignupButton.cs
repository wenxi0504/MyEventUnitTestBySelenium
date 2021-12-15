using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace MyEventTest
{
    class SignupButton
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://me-myevent.herokuapp.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(500);
            IWebElement e1 = driver.FindElement(By.Id("findevents"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(e1).Click().Perform();
            Thread.Sleep(1000);
            IWebElement e2 = driver.FindElement(By.XPath("//h1"));
            Thread.Sleep(1000);
            Assert.AreEqual(e2.Text, "Sign In");
            Thread.Sleep(1000);
        }

        [Test]
        // test click signup button at login page
        public void ClickSignupButton()
        {
            driver.Manage().Window.Maximize();
            IWebElement psw = driver.FindElement(By.Id("password"));
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(1000);
            IWebElement signupBtn = driver.FindElement(By.Id("btnSignUp"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", signupBtn);
            Actions actions = new Actions(driver);
            actions.MoveToElement(signupBtn).Click().Perform();
            Thread.Sleep(1000);
            IWebElement e3 = driver.FindElement(By.XPath("//h3"));
            Assert.AreEqual(e3.Text, "Create Your Account");
        }


        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
