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
    class ReadMoreButton
    {
        
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://me-myevent.herokuapp.com/login");
            driver.Manage().Window.Maximize();
            IWebElement e1 = driver.FindElement(By.Name("username"));
            e1.SendKeys("egor");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("egor" + Keys.PageDown);
            Thread.Sleep(1000);
            IWebElement btnSignIn = driver.FindElement(By.Id("btnSignIn"));
            Thread.Sleep(1000);
            Actions actions = new Actions(driver);
            actions.MoveToElement(btnSignIn).Click().Perform();
            Thread.Sleep(500);
           // ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            //Thread.Sleep(1000);
           

    }
       

        [Test]
      
        public void ClickReadMoreButton()
        {
            IReadOnlyCollection<IWebElement> readmorelist =driver.FindElements(By.Id("readmore"));
            Thread.Sleep(500);
            List<IWebElement> btnReadMore = new List<IWebElement>(readmorelist);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", btnReadMore[3]);
            Thread.Sleep(5000);
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(btnReadMore[1]).Click().Perform();
            Thread.Sleep(1000);
            IWebElement e2 = driver.FindElement(By.XPath("//h1"));
            Assert.AreEqual(e2.Text, "Find Event detail");

           
        }


        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
        
    }
}
