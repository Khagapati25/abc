using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSchoolMAnagementSystem.StepDefinitions
{
    [Binding]
    public class CommonLoginStepDefinitions
    {
        IWebDriver driver;

        [Given(@"Launch the browser")]
        public void GivenLaunchTheBrowser()
        {
            driver = new ChromeDriver();
        }

        [Given(@"Enter the url to open the application")]
        public void GivenEnterTheUrlToOpenTheApplication()
        {
            driver.Navigate().GoToUrl("http://rmgtestingserver/domain/Student_Management_System/view/login.php");
           
        }

        [When(@"Enter the valid username ""([^""]*)"" and password ""([^""]*)""")]
        public void WhenEnterTheValidUsernameAndPassword(string uname, string pwd)
        {
            driver.FindElement(By.Id("email")).SendKeys(uname);
            driver.FindElement(By.Id("password")).SendKeys(pwd);
        }



        [When(@"click on submit button")]
        public void WhenClickOnSubmitButton()
        {
            driver.FindElement(By.Id("btnSubmit")).Click();
        }

        [Then(@"Verify the homepage is displayed or not")]
        public void ThenVerifyTheHomepageIsDisplayedOrNot()
        {
            string str = driver.Title;
            Assert.IsTrue(str.Equals("Student Management System"));
            driver.Close();
        }
    }
}
