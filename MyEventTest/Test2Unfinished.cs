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
    class Test2Unfinished
    {
        /*
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        }

        [Test]
        public void Login()
        {
            driver.Navigate().GoToUrl("https://me-myevent.herokuapp.com/login");
            driver.Manage().Window.Maximize();
            IWebElement e1 = driver.FindElement(By.Name("username"));
            e1.SendKeys("admin");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("egor"+ Keys.PageDown);
            Thread.Sleep(1000);
            IWebElement btnSignIn = driver.FindElement(By.Id("btnSignIn"));
            Thread.Sleep(1000);
            //btnSignIn.Click();
            Actions actions = new Actions(driver);
            actions.MoveToElement(btnSignIn).Click().Perform();
            Thread.Sleep(1000);
            IWebElement e2 = driver.FindElement(By.XPath("//h1"));
            Assert.AreEqual(e2.Text, "Welcome to MyEvent");
        }


        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
        */
    }
}
