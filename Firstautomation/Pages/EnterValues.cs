using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
           // Thread.Sleep(30000);
           // SelectElement s = new SelectElement(driver.FindElement(By.XPath("(//span[@unselectable='on'])[3]")));
           // s.SelectByText("Time");
            
            sun.SendKeys("SUB");
            driver.FindElement(By.XPath("//input[@id='Description']")).SendKeys("WREXY");
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("40000");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]")).Click();
        }
    }
}