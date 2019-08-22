using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstautomation
{
   
    class LoginPage
    {
        IWebDriver driver;

        IWebElement firstname => driver.FindElement(By.Id("UserName"));
        
        IWebElement password => driver.FindElement(By.Id("Password"));

        IWebElement login => driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

       
        internal void LoginSucess()
        {
            
          
            firstname.SendKeys("hari");
          
            password.SendKeys("123123");
         
            login.Click();
          
            
        }
    }
}
