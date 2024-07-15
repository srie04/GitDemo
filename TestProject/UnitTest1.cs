using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Configuration;
using WebDriverManager.DriverConfigs.Impl;
using AngleSharp.Io;
using InputSimulatorEx;

namespace TestProject
{
    public class Tests
    {
        IWebDriver driver;
        ChromeOptions option;
        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            option = new ChromeOptions();
            option.AddUserProfilePreference("download.default_directory","C:\\Users\\Sridhar.Elumalai\\OneDrive - VALGENESIS INDIA PRIVATE LIMITED\\Desktop\\Downloads");
             driver = new ChromeDriver(option);
            driver.Manage().Window.Maximize();

            //driver.Url = "https://www.google.com/";

        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://demo.automationtesting.in/FileDownload.html";

            driver.FindElement(By.LinkText("Download")).Click();
     /*      var uploadBtn = driver.FindElement(By.XPath("/html/body/section/div[1]/div/div/div[1]/div[3]"));

            // uploadBtn.SendKeys("C:\\Users\\Sridhar.Elumalai\\OneDrive - VALGENESIS INDIA PRIVATE LIMITED\\Pictures\\Screenshots\\Screenshot(1).png");
            Thread.Sleep(2000);
            uploadBtn.Click();
            Thread.Sleep(2000);
            InputSimulator i = new InputSimulator();
            i.Keyboard.TextEntry("C:\\Users\\Sridhar.Elumalai\\OneDrive - VALGENESIS INDIA PRIVATE LIMITED\\Pictures\\Screenshots\\Screenshot(1).png");

            i.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.RETURN);*/
        }
    }
}

