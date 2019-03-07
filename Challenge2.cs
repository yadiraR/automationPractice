using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{
    [TestClass]
    public class Challenge2
    {
        IWebDriver driver;
        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void Challengedos()
        {
            driver.Url = "http://automationpractice.com/index.php";
            driver.FindElement(By.ClassName("header_user_info")).Click();
            driver.FindElement(By.Id("email_create")).SendKeys("y4r77o14dr7ig8uez@mailinator.com");
            driver.FindElement(By.Id("SubmitCreate")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //IWebElement gender = wait.Until(driver => driver.FindElement(By.Id("id_gender2")));

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //IWebElement firstName = wait.Until(driver => driver.FindElement(By.Id("customer_firstname")));

            driver.FindElement(By.Id("customer_firstname")).SendKeys("Yadira");
            driver.FindElement(By.Id("customer_lastname")).SendKeys("Rodriguez");
            driver.FindElement(By.Id("passwd")).SendKeys("passwd");
            driver.FindElement(By.Id("address1")).SendKeys("Leopardstown abbey 18");
            driver.FindElement(By.Id("city")).SendKeys("Dublin 18");
            driver.FindElement(By.Id("postcode")).SendKeys("57377");
            new SelectElement(driver.FindElement(By.Id("id_country"))).SelectByValue("21");
            new SelectElement(driver.FindElement(By.Id("id_state"))).SelectByValue("2");
            driver.FindElement(By.Id("phone_mobile")).SendKeys("573737378");
            driver.FindElement(By.Id("submitAccount")).Click();
            string message = driver.FindElement(By.ClassName("info-account")).Text;
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", message);

        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}