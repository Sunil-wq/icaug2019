using Firstautomation.Utilites;
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
            Thread.Sleep(3000);
            //Drop Down
            // SelectElement s = new SelectElement(driver.FindElement(By.XPath("(//span[@unselectable='on'])[3]")));
            // s.SelectByText("Time");
            //ExcelData Reader
            ExcelLibHelpers.PopulateInCollection(@"C:\Users\Owner\source\repos\Firstautomation\Firstautomation\TestData\TestData.xls", "Mysheet");
            sun.SendKeys(ExcelLibHelpers.ReadData(2, "Code"));
            driver.FindElement(By.XPath("//input[@id='Description']")).SendKeys(ExcelLibHelpers.ReadData(2, "Description"));
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys(ExcelLibHelpers.ReadData(2, "Price"));
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]")).Click();
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