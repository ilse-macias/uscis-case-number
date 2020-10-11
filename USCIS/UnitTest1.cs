using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace USCIS
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {

        }

        [Test()]
        public void Test1()
        {
            //Assert.Pass();
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://uscis.gov");

            _driver.FindElement(By.LinkText("Check your case status")).Click();

           // string encodedNumberCase = DecodedNumber("QUJDREVGMTIzNDU2");

            //Case Status
            _driver.FindElement(By.Id("receipt_number"))
                .SendKeys(encodedNumberCase);
            _driver.FindElement(By.Name("initCaseSearch"))
                .Click();

           
            _driver.FindElement(By.ClassName("rows text-center"));
           

            _driver.Close();
            _driver.Quit();
            
        }
    }
}