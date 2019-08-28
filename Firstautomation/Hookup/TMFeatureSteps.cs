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
        
        [Given(@"I have navigate to time and material page")]
        public void GivenIHaveNavigateToTimeAndMaterialPage()
        {
            EnterValues entervaluesinstance = new EnterValues(driver);
            entervaluesinstance.details();
        }
        
        [Then(@"I should be able to create time and material records")]
        public void ThenIShouldBeAbleToCreateTimeAndMaterialRecords()
        {
            driver.Quit();
        }
    }
}
