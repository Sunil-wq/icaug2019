using OpenQA.Selenium;
using System;
using System.Threading;

namespace Firstautomation
{

    internal class EditData
    {
        private IWebDriver driver;
        


        public EditData(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void editing()
        {
            driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]")).Click();
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();
            
            Thread.Sleep(3000);
            try
            {
                while(true)
                {
                    for(int i=1;i<=10;i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));


                        if (code.Text == "SUB") 
                        {
                            driver.FindElement(By.XPath("(//a[contains(.,'Edit')])[8]")).Click();
                            driver.FindElement(By.XPath("//input[@id='Code']")).Clear();
                            driver.FindElement(By.XPath("//input[@id='Code']")).SendKeys("HYU");

                            driver.FindElement(By.XPath("//input[@id='Description']")).Clear();

                            driver.FindElement(By.XPath("//input[@id='Description']")).SendKeys("NLIN");

                            //  driver.FindElement(By.Id("Price")).Clear();


                            //  driver.FindElement(By.XPath("//*[@id=\"Price\"]")).SendKeys("50000");
                            Thread.Sleep(3000);
                            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();

                        }


                    }

                    driver.FindElement(By.XPath("//span[@class='k-icon k-i-arrow-e'][contains(.,'Go to the next page')]")).Click();
                }
            }
            
            
              
            catch(Exception)
            {
                Console.WriteLine("code not found");
            }
        }
        internal void EditConfirm()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                    if (code.Text == "HYU")
                    {
                        Console.WriteLine("Updated");
                    }
                }
            
            driver.FindElement(By.XPath("//span[@class='k-icon k-i-arrow-e'][contains(.,'Go to the next page')]")).Click();
        }
            catch(Exception)
            {
                Console.WriteLine("No Yet");
            }
        }
    }
}
