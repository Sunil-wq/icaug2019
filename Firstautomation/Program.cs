using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstautomation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            IWebElement firstname = driver.FindElement(By.Id("UserName"));
            firstname.SendKeys("hari");
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            IWebElement login = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            login.Click();
            _ = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Hello hari!')]")).Displayed;
         

            driver.Quit();

        }
    }
}
