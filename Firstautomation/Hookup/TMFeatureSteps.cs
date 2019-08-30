using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Firstautomation
{
    [Binding]
    public class TMFeatureSteps
    {
        IWebDriver driver;
        


        [Given(@"I have loggedin to the turn up portal")]
        public void GivenIHaveLoggedinToTheTurnUpPortal()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            LoginPage logininstance = new LoginPage(driver);
            logininstance.LoginSucess();
        }
        [Given(@"I should be able to create time and material records")]
        public void GivenIShouldBeAbleToCreateTimeAndMaterialRecords()
        {

            EnterValues entervaluesinstance = new EnterValues(driver);
            entervaluesinstance.details();
        }

        [Given(@"I should be able to edit values")]
        public void GivenIShouldBeAbleToEditValues()
        {
            EditData editinstance = new EditData(driver);
            editinstance.editing();
           // editinstance.EditConfirm();
        }
        
        [Then(@"i should be able to delete records")]
        public void ThenIShouldBeAbleToDeleteRecords()
        {
            DeleteData deleteinstance = new DeleteData(driver);
            Thread.Sleep(3000);
            deleteinstance.DeleteConfirm();
            driver.Quit();
        }
    }
}
