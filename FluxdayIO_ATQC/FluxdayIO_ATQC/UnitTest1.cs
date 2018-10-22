using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;

namespace FluxdayIO_ATQC
{
    public class UnitTest1
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            driver = new ChromeDriver();
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
            //Console.WriteLine("FirstTest1() ThreadID= " + Thread.CurrentThread.ManagedThreadId);
            //
            //IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Navigate().GoToUrl("https://www.google.com.ua/");
            //
            driver.FindElement(By.Id("user_email")).Click();
            driver.FindElement(By.Id("user_email")).Clear();
            //driver.FindElement(By.Id("lst-ib")).SendKeys("selenium ide" + Keys.Enter);
            driver.FindElement(By.Id("user_email")).SendKeys("admin@fluxday.io");
            Thread.Sleep(4000);

            driver.FindElement(By.Id("user_password")).Click();
            driver.FindElement(By.Id("user_password")).Clear();
            driver.FindElement(By.Id("user_password")).SendKeys("password");
            Thread.Sleep(4000);

            driver.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();
            Thread.Sleep(4000);

            Assert.AreEqual("+Task",
                driver.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text);
            //
            //IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            //javaScript.ExecuteScript("alert('Hello!');");
            //Thread.Sleep(4000);
            //driver.SwitchTo().Alert().Accept();
            //
            //driver.FindElement(By.Id("mKlEF")).Click();
            //driver.FindElement(By.LinkText("Selenium IDE")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.LinkText("Download")).Click();
            //Thread.Sleep(2000);
            //
            //IWebElement actual = driver.FindElement(By.CssSelector("a[name=\"selenium_ide\"] > p"));
            //
            // Search By JavaScript
            //IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            //IWebElement actual = (IWebElement)javaScript
            //    .ExecuteScript("return document.getElementsByName('selenium_ide')[0];", new object[1] { "" });
            //
            //Assert.True(actual.Text.Contains("Selenium IDE is a Chrome and Firefox plugin which records and plays back"));
            //
            //Assert.AreEqual("Selenium IDE is a Chrome and Firefox plugin which records and plays back user interactions with the browser. Use this to either create simple scripts or assist in exploratory testing.",
            //    driver.FindElement(By.CssSelector("a[name=\"selenium_ide\"] > p")).Text);
            //
            // Goto Position. Use Actions class
            //Actions action = new Actions(driver);
            //IWebElement position = driver.FindElement(By.CssSelector("a[name=\"selenium_ide\"] > p"));
            //IWebElement position = driver.FindElement(By.XPath("//a[text()='2']"));
            //action.MoveToElement(position).Perform();
            //action.ClickAndHold().MoveToElement(position).Perform();
            //
            // Goto Position By JavaScript.
            //IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            //IWebElement position = driver.FindElement(By.CssSelector("a[name=\"selenium_ide\"] > p"));
            //IWebElement position = driver.FindElement(By.XPath("//a[text()='2']"));
            //javaScript.ExecuteScript("arguments[0].scrollIntoView(true);", position);
            //
            //Thread.Sleep(4000);
            //
            //ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
            // Screenshot screenshot = takesScreenshot.GetScreenshot();
            //screenshot.SaveAsFile("d:/ScreenshotGoogle1.png", ScreenshotImageFormat.Png);
            //
            //driver.Quit();
        }
    }
}
