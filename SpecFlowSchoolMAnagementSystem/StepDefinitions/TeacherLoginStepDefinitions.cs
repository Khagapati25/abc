using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSchoolMAnagementSystem.StepDefinitions
{
    [Binding]
    public class TeacherLoginStepDefinitions
    {
        IWebDriver driver;
        private string str;

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver(); 
        }

        [Given(@"Enter the url")]
        public void GivenEnterTheUrl()
        {
            driver.Navigate().GoToUrl("http://rmgtestingserver/domain/Student_Management_System/view/login.php");
        }

        [When(@"In login page enter valid credential")]
        public void WhenInLoginPageEnterValidCredential()
        {
            driver.FindElement(By.Id("email")).SendKeys("t1@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("12345");
        }

        [When(@"Click on login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.Id("btnSubmit")).Click();
        }

        [Then(@"Verify home page is dsplayed or not")]
        public void ThenVerifyHomePageIsDsplayedOrNot()
        {
            string str=driver.Title;
            Assert.IsTrue(str.Equals("Student Management System"));
        }
    }
}
