using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;

namespace SDET_dotnet_MstestV2.POM
{
    class ServicesPage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'Services' and @class = 'nav-link']")]
        private IWebElement ServicesMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='col-12']//h3[@class='subtitle']")]
        private IWebElement IndustryText { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='logos col-12 row']/div")]
        private IWebElement industriesSize { get; set; }

        public ServicesPage() : base()
        {

        }

        public ServicesPage getServices()
        {
            browser.Click(ServicesMenu);            
            return this;
        }

        public String validateElement()
        {
            String title = browser.getText(IndustryText);
            Console.WriteLine(browser.getText(IndustryText));
            return title;
        }

        public ServicesPage countIndustries()
        {
            browser.count(industriesSize);
            Console.WriteLine("2: "+browser.count(industriesSize));
            return this;

        }
    }
}
