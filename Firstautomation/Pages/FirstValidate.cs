using System;
using OpenQA.Selenium;

namespace Firstautomation
{
    internal class FirstValidate
    {
         IWebDriver driver;

        public FirstValidate(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void validate()
        {
            
            IWebElement Code = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Hello hari!')]"));
            Console.WriteLine("Code" + Code.Text);
            if (Code.Text == "Hello hari!")
            {
                Console.WriteLine("test passed");
            }
            else
            {
                Console.WriteLine("test failed");
            }
        }
    }
}