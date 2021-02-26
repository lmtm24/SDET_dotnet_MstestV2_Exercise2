using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;

namespace SDET_dotnet_MstestV2.Base
{
    public class UnoBrowser
    {
        private Size total;

        public enum Browser
        {
            Chrome
        }

        public IWebDriver CreateBrowser(Browser browser)
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            driver.Navigate().GoToUrl("https://www.unosquare.com");
            return driver;
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public string getText(IWebElement element)
        {
            string text = element.Text;
            return text;
        }

        public Size count(IWebElement element)
        {
            Size size = element.Size;
            Console.WriteLine(size);
            return size;
        }

        

    }


}

