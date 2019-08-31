using System;
using System.Threading;
using Firstautomation.Utilites;
using OpenQA.Selenium;

namespace Firstautomation
{
    internal class SecondValidate
    {
        private IWebDriver driver;

        public SecondValidate(IWebDriver driver)
        {
           this.driver = driver;
        }

        internal void validation()
        {

            //  Thread.Sleep(3000);
            Wait.ElementIsVisible(driver, "//span[@class='k-icon k-i-arrow-e'][contains(.,'Go to the next page')]", "XPath");
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        Console.WriteLine(code.Text);
                        if (code.Text == "vbt")
                        {
                            Console.WriteLine("code found");
                            return;
                        }
                    }
                    driver.FindElement(By.XPath("//span[@class='k-icon k-i-arrow-e'][contains(.,'Go to the next page')]")).Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("not found");
            }
        }
    }
}