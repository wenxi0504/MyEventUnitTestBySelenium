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
    class FindeventNav
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        }

        [Test]
        // test the click findEvents Nav when the user is not login 
        public void ClickFindEventNav()
        {
            driver.Navigate().GoToUrl("https://me-myevent.herokuapp.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(500);
            IWebElement e1 = driver.FindElement(By.Id("findevents"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(e1).Click().Perform();
            Thread.Sleep(1000);
            IWebElement e2 = driver.FindElement(By.XPath("//h1"));
            Thread.Sleep(1000);
            Assert.AreEqual( "Sign In", e2.Text);
            Thread.Sleep(1000);
        }


        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
