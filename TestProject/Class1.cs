using InputSimulatorEx;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputSimulatorEx.Native;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject
{
    internal class Class1
    {
        [Test]
        public void Test()
        {
            //String name = System.Configuration.ConfigurationManager.AppSettings["name"];
            String name = ConfigurationManager.AppSettings["name"];

            TestContext.Progress.WriteLine(name);
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.com/";

            InputSimulator input = new InputSimulator();
            input.Keyboard.TextEntry("Hello");

            input.Keyboard.KeyDown
                (VirtualKeyCode.SHIFT);

            input.Keyboard.KeyPress(VirtualKeyCode.VK_A);
         
            //input.Keyboard.KeyPress(VirtualKeyCode.CONTROL);
            input.Keyboard.KeyUp(VirtualKeyCode.SHIFT);


            //input.Keyboard.KeyDown(VirtualKeyCode.RETURN);
            //input.Keyboard.KeyUp(VirtualKeyCode.RETURN);


        }
              
        }
    }

