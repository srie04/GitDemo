using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using InputSimulatorEx;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using TestProject.utilities;

namespace TestProject
{
    internal class FileUpload : BaseClass
    {
        IWebDriver driver;
        ChromeOptions option;
        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            //option.AddArgument("--disable-infobars");
            //option.AddArgument("--disable-popup-blocking");


            driver = new ChromeDriver(option);
          //  driver.Manage().Window.Maximize();
            driver.Url = "https://demo.automationtesting.in/FileUpload.html";

        }

        [Test]
        public void Upload()
        {
            var scroll = driver.FindElement(By.XPath("//span[text()='Browse …']"));
            /*IJavaScriptExecutor executor =  (IJavaScriptExecutor) driver;
           executor.ExecuteScript("arguments[0].scrollIntoView(true)", scroll);
           */
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(scroll));
            

            a.MoveToElement(scroll).Click().Perform();
            Thread.Sleep(2000);
            String FileLocation = "C:\\Users\\Sridhar.Elumalai\\OneDrive - VALGENESIS INDIA PRIVATE LIMITED\\Desktop\\PS17 PSTR Execution Attachment\\CCR\\2.png";


            InputSimulator i = new InputSimulator();

            i.Keyboard.TextEntry(FileLocation);

            i.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.RETURN);

           /* String expectedText = "The upload is complete!";

            Thread.Sleep(5000);

           String actualText = driver.FindElement(By.XPath("/html/body/main/astro-island[1]/div/p")).Text;

            Assert.AreEqual(expectedText, actualText);*/
        }

    }
}
