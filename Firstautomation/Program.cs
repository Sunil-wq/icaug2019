using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Firstautomation
{
    class TmTest
    {
        static void Main(string[] args)
        {


        }

        IWebDriver driver;

        [SetUp]
        public void BeforeTestCase()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            LoginPage logininstance = new LoginPage(driver);
            logininstance.LoginSucess();
        }

        [TearDown]
        public void AfterEachTestCase()
        {
            driver.Quit();
        }

        [Test]
        public void CreatenValidate()
        {

            FirstValidate fvalidate = new FirstValidate(driver);
            fvalidate.validate();
            EnterValues entervaluesinstance = new EnterValues(driver);
            entervaluesinstance.details();
           // SecondValidate svalidate = new SecondValidate(driver);
           // svalidate.validation();
        }


        [Test]
        public void EditnValidate()
        {
           // FirstValidate fvalidate = new FirstValidate(driver);
           // fvalidate.validate();
           // EnterValues entervaluesinstance = new EnterValues(driver);
           // entervaluesinstance.details();
            EditData editinstance = new EditData(driver);
            editinstance.editing();
            editinstance.EditConfirm();



        }
        [Test]
        public void DeletenValidate()
        {
            
            DeleteData deleteinstance = new DeleteData(driver);
            deleteinstance.DeleteConfirm();


        }
    }
}









