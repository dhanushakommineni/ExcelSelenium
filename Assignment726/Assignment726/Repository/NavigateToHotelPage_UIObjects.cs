using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Assignment726.GenericHelper;

namespace Assignment726.Repository
{
    public class NavigateToHotelPage_UIObjects
    {
        public NavigateToHotelPage_UIObjects()
        {
            PageFactory.InitElements(WebdriverManage.Webdriver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//span[@Innertext='Dashboard']")]
        public IWebElement ui_GetDashboardTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='social-sidebar-menu']/li")]
        public IList<IWebElement> ui_GetNavigationLinks { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='Hotels']/li/a")]
        public IList<IWebElement> ui_GetSubNavigationLinks { get; set; }
    }
}
