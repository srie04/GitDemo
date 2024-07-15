using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.utilities;

namespace TestProject
{
    internal class Login : BaseClass
    {
        //IWebDriver driver;
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;

        [Test]
        public void LoginA()
        {
          //  driver = new ChromeDriver();
          BaseClass c = new BaseClass();
            GetDriver().Manage().Window.Maximize();
           /* driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            PageFactory.InitElements(driver, this);
            username.SendKeys("RahulShetty");*/
        }

        public void LoginAction()
        {
           
        }


    }
}
