using System;
using NUnit.Framework;
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
               
            //Aseert Statement
            Assert.That(Code.Text, Is.EqualTo("Hello hari!"));
            // if (Code.Text == "Hello hari!")
            // {
            //     Console.WriteLine("test passed");
            //  }
            //  else
            //  {
            //     Console.WriteLine("test failed");
            //  }


        }
    }
}