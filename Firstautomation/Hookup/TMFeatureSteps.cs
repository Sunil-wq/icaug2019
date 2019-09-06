using java.sql;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Firstautomation.Hookup
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

        [Given(@"Navigate to home page")]
        public void GivenNavigateToHomePage()
        {

            FirstValidate fvaliadteinstance = new FirstValidate(driver);
            fvaliadteinstance.validate();
        }


        [Given(@"I should be able to create time and material records")]
        public void GivenIShouldBeAbleToCreateTimeAndMaterialRecords()
    {
           
            EnterValues entervaluesinstance = new EnterValues(driver);
        entervaluesinstance.details();
            driver.Quit();

        }

    [Given(@"I should be able to edit time and material records")]
        public void GivenIShouldBeAbleToEditTimeAndMaterialRecords()
        {
        
        EditData editinstance = new EditData(driver);
        editinstance.editing();
        driver.Quit();


        }

    [Given(@"I should be able to delete time and material records")]
        public void GivenIShouldBeAbleToDeleteTimeAndMaterialRecords()
        {
        
         DeleteData deleteinstance = new DeleteData(driver);
        deleteinstance.DeleteConfirm();
        driver.Quit();

    }
}
}
