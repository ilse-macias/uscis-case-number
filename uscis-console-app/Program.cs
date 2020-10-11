using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace uscis_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://egov.uscis.gov/casestatus/landing.do");

            //TODO: Read case number from environment variable.

            var caseNumber = Environment.GetEnvironmentVariable("USCIS_CASE_NUMBER");
            //Case Status
            _driver.FindElement(By.Id("receipt_number"))
                .SendKeys(caseNumber);
            _driver.FindElement(By.Name("initCaseSearch"))
                .Click();


            //_driver.FindElement(By.ClassName("rows text-center"));


            _driver.Close();
            _driver.Quit();
        }
    }
}
