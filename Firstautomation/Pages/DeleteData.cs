using System;
using System.Threading;
using Firstautomation.Utilites;
using OpenQA.Selenium;

namespace Firstautomation
{
    internal class DeleteData
    {
        private IWebDriver driver;

        public DeleteData(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void DeleteConfirm()
        {
            driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]")).Click();
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();
            Thread.Sleep(3000);
            //Explicit Wait
            Wait.ElementIsVisible(driver, "//span[@class='k-icon k-i-arrow-e'][contains(.,'Go to the next page')]", "XPath");
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));


                        if (code.Text == "MIT")
                        {

                            Thread.Sleep(3000);
                            driver.FindElement(By.XPath("(//a[@class='k-button k-button-icontext k-grid-Delete'])[8]")).Click();

                            Thread.Sleep(3000);
                            driver.SwitchTo().Alert().Accept();
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