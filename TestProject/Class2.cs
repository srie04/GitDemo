using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using InputSimulatorEx;
using InputSimulatorEx.Native;

namespace TestProject
{
    internal class Class2
    {
        IWebDriver driver;
        ChromeOptions option;
        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";

        }

        [Test]
        public void Input()
        {
            InputSimulator i = new InputSimulator();
            //Virtual Keyboard

          //  i.Keyboard.TextEntry("A R Rahman");

          //  i.Keyboard.KeyPress(VirtualKeyCode.RETURN);


            i.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
            i.Keyboard.KeyPress(VirtualKeyCode.VK_A);
            i.Keyboard.KeyPress(VirtualKeyCode.VK_B);
            i.Keyboard.KeyUp(VirtualKeyCode.SHIFT);

            i.Keyboard.KeyPress(VirtualKeyCode.VK_C);
            i.Keyboard.KeyPress(VirtualKeyCode.RETURN);


        }
    }
}
