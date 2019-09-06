using Firstautomation.Utilites;
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
        //Lambda Expression
        IWebElement firstname => driver.FindElement(By.Id("UserName"));

        IWebElement password => driver.FindElement(By.Id("Password"));

        IWebElement login => driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        internal void LoginSucess()
        {
            //ExcelSheetReader
            // ExcelLibHelpers.PopulateInCollection(@"C:\Users\Owner\source\repos\Firstautomation\Firstautomation\TestData\TestData.xls","Mysheet");
            //  firstname.SendKeys(ExcelLibHelpers.ReadData(2, "Fname"));

            //JavaScriEtExecutor
            String usernameJS = "document.getElementById('UserName').value='hari'";
            JsExecutor.Script(driver, usernameJS);
            String password = "document.getElementById('Password').value='123123'";
            JsExecutor.Script(driver, password);

            //firstname.SendKeys("hari");
            //  password.SendKeys("123123");
            login.Click();


        }
    }
}
