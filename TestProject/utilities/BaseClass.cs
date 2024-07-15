using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace TestProject.utilities
{
    internal class BaseClass
    {
       private static IWebDriver driver;
        
        //This method is used to get the driver. This call will get inherited in the 
        //Child class to acess the properties. This is the Base Class of the project
        public static IWebDriver GetDriver()
        {
            driver = new ChromeDriver();
            return driver;
        }

        private static Action action;

        public static Action GetAction()
        {
            action = new Action(GetDriver());
            return action;
        }
    }
}
