using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectSpecFlow.Configure;
using ProjectSpecFlow.Hooks;
using System;
using TechTalk.SpecFlow;

namespace ProjectSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginVTigerStepDefinitions : Hooks1
    {

        

        [When(@"In login page enter valid credential")]
        public void WhenInLoginPageEnterValidCredential()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine(ConfigureManager.url);
            Console.WriteLine(ConfigureManager.username);
            Console.WriteLine(ConfigureManager.password);
            driver.FindElement(By.Name("user_name")).SendKeys(ConfigureManager.username);
            driver.FindElement(By.Name("user_password")).SendKeys(ConfigureManager.password);
        }

        //[When(@"In login page enter valid username ""([^""]*)"" and password ""([^""]*)""")]
        //public void WhenInLoginPageEnterValidUsernameAndPassword(string username, string password)
        //{
        //    driver.FindElement(By.Name("user_name")).SendKeys(username);
        //    driver.FindElement(By.Name("user_password")).SendKeys(password);
        //}


        [When(@"Click on login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.Id("submitButton")).Click();
        }

        [Then(@"Verify home page is dsplayed or not")]
        public void ThenVerifyHomePageIsDsplayedOrNot()
        {
            string actualtitle = driver.Title.Trim();
            Assert.IsTrue(actualtitle.Equals("Administrator - Home - vtiger CRM 5 - Commercial Open Source CRM"));
        }
    }
}
