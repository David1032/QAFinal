using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTests
{
    [TestClass]
    public class LoginTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void Test_Successful_Login()
        {
            driver.Navigate().GoToUrl("https://letsusedata.com");
            driver.FindElement(By.Id("username")).SendKeys("test1");
            driver.FindElement(By.Id("password")).SendKeys("Test12456");
            driver.FindElement(By.Id("loginButton")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("welcomeMessage")).Displayed);
        }

        [TestMethod]
        public void Test_Unsuccessful_Login()
        {
            driver.Navigate().GoToUrl("https://letsusedata.com");
            driver.FindElement(By.Id("username")).SendKeys("test1");
            driver.FindElement(By.Id("password")).SendKeys("test1234");
            driver.FindElement(By.Id("loginButton")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("errorMessage")).Displayed);
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}