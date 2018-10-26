using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FluxdayIO_ATQC
{
    [TestFixture]
    public class TaskUI
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Quit();
        }

        [Test]
        public void FirstTest1()
        {
            // NUnit.Framework.Internal.Logger logger = new NUnit.Framework.Internal.Logger("first",InternalTraceLevel.Info,System.IO.TextWriter.Null);
            // logger.Info("test log");
            Console.WriteLine("Start test");
            driver.FindElement(By.Id("user_email")).Click();
            driver.FindElement(By.Id("user_email")).Clear();
            driver.FindElement(By.Id("user_email")).SendKeys("lead@fluxday.io");
            Console.WriteLine("Field user name fill [ok]");

            driver.FindElement(By.Id("user_password")).Click();
            driver.FindElement(By.Id("user_password")).Clear();
            driver.FindElement(By.Id("user_password")).SendKeys("password");
            Console.WriteLine("Field user password fill [ok]");


            driver.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();

            Assert.AreEqual("+Task",
                driver.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text,"[OK]");
            Console.WriteLine("Assert [ok]");

        }
    }
}
