using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectSpecFlow.Configure;
using TechTalk.SpecFlow;

namespace ProjectSpecFlow.Hooks
{
    [Binding]
    public class Hooks1
    {
        public IWebDriver driver;

        [Before]
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Console.WriteLine(ConfigureManager.url);
            driver.Navigate().GoToUrl("http://localhost:8888");
        }

        [After]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}