using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSchoolMAnagementSystem.StepDefinitions
{
    [Binding]
    public class AdminEndToEndStepDefinitions
    {

        IWebDriver driver;

        [Given(@"Open Browser")]
        public void GivenOpenBrowser()
        {
            driver = new ChromeDriver();
        }

        [Given(@"Enter the url to launch the application")]
        public void GivenEnterTheUrlToLaunchTheApplication()
        {
            driver.Navigate().GoToUrl("http://rmgtestingserver/domain/Student_Management_System/view/login.php");
        }

        [When(@"In login page enter valid email ""([^""]*)"" and password ""([^""]*)""")]
        public void WhenInLoginPageEnterValidEmailAndPassword(string un, string pw)
        {
            driver.FindElement(By.Id("email")).SendKeys(un);
            driver.FindElement(By.Id("password")).SendKeys(pw);
        }

        [When(@"Click on submit button to sucessfully login")]
        public void WhenClickOnSubmitButtonToSucessfullyLogin()
        {
            driver.FindElement(By.Id("btnSubmit")).Click();
        }

        [Then(@"Veryify homepage is displayed or not")]
        public void ThenVeryifyHomepageIsDisplayedOrNot()
        {
            string str = driver.Title;
            Assert.IsTrue(str.Equals("Student Management System"));
            driver.Close();
        }

        [Given(@"Click on Classroom module")]
        public void GivenClickOnClassroomModule()
        {
            driver.FindElement(By.XPath("//i[@class='fa fa-list-ul']")).Click();
        }

        [When(@"Enter name and student count")]
        public void WhenEnterNameAndStudentCount()
        {
            driver.FindElement(By.Id("name")).SendKeys("ClassC#");
            driver.FindElement(By.Id("student_count")).SendKeys("9");
        }

        [When(@"Click on Submit Button to sucessfully create a new Classroom")]
        public void WhenClickOnSubmitButtonToSucessfullyCreateANewClassroom()
        {
            driver.FindElement(By.Id("btnSubmit")).Click();
        }

        [Then(@"Verify Classroom is created or not")]
        public void ThenVerifyClassroomIsCreatedOrNot()
        {

            
        }
        //----------------------------------------------------------------------------------------------

        [Given(@"Click on Grade module")]
        public void GivenClickOnGradeModule()
        {
            driver.FindElement(By.XPath("//i[@class='fa fa-database']")).Click();   
        }

        [When(@"Enter the necessery details about grade")]
        public void WhenEnterTheNecesseryDetailsAboutGrade()
        {
            driver.FindElement(By.Id("name")).SendKeys("GradeC#");
            driver.FindElement(By.Id("admission_fee")).SendKeys("1000");
            driver.FindElement(By.Id("hall_charge")).SendKeys("25");
        }

        [When(@"Click on next button to sucessfully create a new Grade")]
        public void WhenClickOnNextButtonToSucessfullyCreateANewGrade()
        {
            driver.FindElement(By.Id("btn btn-primary")).Click();
        }

        [Then(@"Verify Grade is created or not")]
        public void ThenVerifyGradeIsCreatedOrNot()
        {
            
        }
        //------------------------------------------------------------------------------------------------


        [Given(@"Click on subject module")]
        public void GivenClickOnSubjectModule()
        {
            driver.FindElement(By.XPath("//i[@class='fa fa-book']")).Click();
        }

        [When(@"Enter the subject name")]
        public void WhenEnterTheSubjectName()
        {
            driver.FindElement(By.Id("name")).SendKeys("C#");
           
        }

        [When(@"Click on Submit button to sucessfully create a new Student")]
        public void WhenClickOnSubmitButtonToSucessfullyCreateANewStudent()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"Verify Subject is Create or not")]
        public void ThenVerifySubjectIsCreateOrNot()
        {
           
        }
        //----------------------------------------------------------------------------------


        [Given(@"Click on Teachers module")]
        public void GivenClickOnTeachersModule()
        {
            driver.FindElement(By.XPath("//i[@class='fa fa-user']")).Click();
        }

        [Given(@"Click on Add Teacher feature")]
        public void GivenClickOnAddTeacherFeature()
        {
            driver.FindElement(By.XPath("//a[text()=' Add Teacher']")).Click();
        }

        [When(@"Enter the necessary details about teacher")]
        public void WhenEnterTheNecessaryDetailsAboutTeacher()
        {
            driver.FindElement(By.Id("index_number")).SendKeys("001");
            driver.FindElement(By.Id("full_name")).SendKeys("SpiderMan");
            driver.FindElement(By.Id("i_name")).SendKeys("WS");
            driver.FindElement(By.Id("address")).SendKeys("New York");

            IWebElement gender=driver.FindElement(By.Id("gender"));
            SelectElement s = new SelectElement(gender);
            s.SelectByText("Male");

            driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
            driver.FindElement(By.Id("email")).SendKeys("spiderman@avengers.com");
            driver.FindElement(By.Id("fileToUpload")).SendKeys($"C:\\Users\\JAI\\Downloads\\spiderman.jpg");
        }

        [When(@"Click onsubmit button to sucessfully create a new Teacher")]
        public void WhenClickOnsubmitButtonToSucessfullyCreateANewTeacher()
        {
            driver.FindElement(By.Id("btnSubmit")).Click();
        }

        [Then(@"Verify Teacher is created or not")]
        public void ThenVerifyTeacherIsCreatedOrNot()
        {
           
        }

        //-----------------------------------------------------------------------------
        [Given(@"Click on Subject routing module")]
        public void GivenClickOnSubjectRoutingModule()
        {
            driver.FindElement(By.XPath("//i[@class='fa fa-th']")).Click();
        }

        [Given(@"Click on add button")]
        public void GivenClickOnAddButton()
        {
            driver.FindElement(By.XPath("//a[text()='Add ']")).Click(); 
        }

        [When(@"Select the option from each drop down")]
        public void WhenSelectTheOptionFromEachDropDown()
        //{
        //    IWebElement gradelist;
        //    SelectElement s1 = new SelectElement(gradelist);

        //    IWebElement subjectlist;
        //    SelectElement s2 = new SelectElement(subjectlist);


        //    IWebElement teacherlist;
        //    SelectElement s3 = new SelectElement(teacherlist);
        }

        [When(@"Click on submit button to sucessfully create a subject routing")]
        public void WhenClickOnSubmitButtonToSucessfullyCreateASubjectRouting()
        {
           
        }

        [Then(@"Verify subject routing is created or not")]
        public void ThenVerifySubjectRoutingIsCreatedOrNot()
        {
            
        }

        [Given(@"Clcik on Students module")]
        public void GivenClcikOnStudentsModule()
        {
            
        }

        [Given(@"Click oon Add Student feature")]
        public void GivenClickOonAddStudentFeature()
        {
            
        }

        [When(@"Enter the necessary details of student and guardian")]
        public void WhenEnterTheNecessaryDetailsOfStudentAndGuardian()
        {
           
        }

        [When(@"Click on next button to sucessfully create a student and guardian")]
        public void WhenClickOnNextButtonToSucessfullyCreateAStudentAndGuardian()
        {
           
        }

        [Given(@"Click on your name in top right corner of the application")]
        public void GivenClickOnYourNameInTopRightCornerOfTheApplication()
        {
            
        }

        [Given(@"Click on Signout button")]
        public void GivenClickOnSignoutButton()
        {
           
        }

        [Then(@"Verify login page is displayed or not")]
        public void ThenVerifyLoginPageIsDisplayedOrNot()
        {
            
        }
    }
}
