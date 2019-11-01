using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Assignment726.GenericHelper;

namespace Assignment726.Repository
{
    public class Login_UIObjects
    {
        public Login_UIObjects()
        {
            PageFactory.InitElements(WebdriverManage.Webdriver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//form[1]/div/input[@name='email']")]
        public IWebElement ui_Username { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='password']")]
        public IWebElement ui_Password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='btn btn-primary btn-block ladda-button fadeIn animated']")]
        public IWebElement ui_Login { get; set; }
    }
}
