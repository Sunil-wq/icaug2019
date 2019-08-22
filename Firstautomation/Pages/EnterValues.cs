using OpenQA.Selenium;
using System;
using System.Threading;

namespace Firstautomation
{
    internal class EnterValues
    {
        private IWebDriver driver;
        IWebElement sun => driver.FindElement(By.XPath("//input[@id='Code']"));

        public EnterValues(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void details()
        {

            driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]")).Click();
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
            
            sun.SendKeys("SUB");
            driver.FindElement(By.XPath("//input[@id='Description']")).SendKeys("WREXY");
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("40000");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]")).Click();
        }
    }
}