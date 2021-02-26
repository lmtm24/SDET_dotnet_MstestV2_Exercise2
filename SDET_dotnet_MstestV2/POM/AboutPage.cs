using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;

namespace SDET_dotnet_MstestV2.POM
{
    class AboutPage : UnoPages
    {


        [FindsBy(How = How.XPath, Using = "//a[.= 'About' and @class = 'nav-link']")]
        private IWebElement aboutMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='case row']")]
        private IWebElement MissionText { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='gray-section']//div[@class='container content-home']//h3[@class='subtitle my-5']")]
        private IWebElement leadershipText { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='leads']")]
        private IWebElement nameAndRol { get; set; }


        public AboutPage() : base() {

    }


        public AboutPage getAboutMenu()
        {
            browser.Click(aboutMenu);
            return this;
        }

        public String validateLeaderElement()
        {
            String text = browser.getText(MissionText);
           // Console.WriteLine(browser.getText(Mission));
            return text;
        }

        public String validateleadershipText()
        {
            String text = browser.getText(leadershipText);
            // Console.WriteLine(browser.getText(Mission));
            return text;
        }

        public String getNameAndRol()
        {
            String text = browser.getText(nameAndRol);
            Console.WriteLine(browser.getText(nameAndRol));            
            return text;
        }

    }


}
