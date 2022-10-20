using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ProjectSpecFlow.StepDefinitions
{
    [Binding]
    public class CreateOrgStepDefinitions
    {
        IWebDriver driver;

        [Given(@"in login page enter the username and password and click on login button")]
        public void GivenInLoginPageEnterTheUsernameAndPasswordAndClickOnLoginButton()
        {
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("admin");
            driver.FindElement(By.Id("submitButton")).Click();
        }

        [When(@"In home page click on organization link")]
        public void WhenInHomePageClickOnOrganizationLink()
        {
            driver.FindElement(By.XPath("(//a[text()='Organizations'])[1]")).Click();
        }

        [When(@"in organization page click on create organization image")]
        public void WhenInOrganizationPageClickOnCreateOrganizationImage()
        {
            driver.FindElement(By.XPath("//img[@title='Create Organization...']")).Click();
        }

        [When(@"In create organization page enyer ""([^""]*)"" and click on save button")]
        public void WhenInCreateOrganizationPageEnyerAndClickOnSaveButton(string orgname)
        {
            driver.FindElement(By.XPath("//input[@name='accountname']")).SendKeys(orgname);
            driver.FindElement(By.XPath("(//input[@class='crmbutton small save'])[1]")).Click();
        }

        [Then(@"Verify ""([^""]*)"" is created or not")]
        public void ThenVerifyIsCreatedOrNot(string orgname)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            String str = driver.FindElement(By.XPath("//td[@id='mouseArea_Organization Name']")).Text;

            Assert.IsTrue(str.Contains(orgname));
        }
    }
}
