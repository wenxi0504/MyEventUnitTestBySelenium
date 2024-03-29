﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace MyEventTest
{
    class LoginTest
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        }

        [Test]
        //test login in button when user input username and password
        public void Login()
        {
            driver.Navigate().GoToUrl("https://me-myevent.herokuapp.com/login");
            driver.Manage().Window.Maximize();
            IWebElement e1 = driver.FindElement(By.Name("username"));
            e1.SendKeys("egor");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("egor"+ Keys.PageDown);
            // failed case
            // driver.FindElement(By.Name("password")).SendKeys("admin"+ Keys.PageDown);
            Thread.Sleep(1000);
            IWebElement btnSignIn = driver.FindElement(By.Id("btnSignIn"));
            Thread.Sleep(1000);
            Actions actions = new Actions(driver);
            actions.MoveToElement(btnSignIn).Click().Perform();
            Thread.Sleep(1000);
            IWebElement e2 = driver.FindElement(By.XPath("//h1"));
            Assert.AreEqual("Welcome to MyEvent", e2.Text);
            Thread.Sleep(1000);
        }


        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
