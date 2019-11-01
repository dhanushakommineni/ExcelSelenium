using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Windows.Forms;
using System.Drawing;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Data;
using System.IO;
using Excel;

namespace Assignment726.GenericHelper
{
    public static class WebdriverManage
    {
        public static IWebDriver Webdriver = null;
        public static void GetDrvier()
        {
            try
            {
                string Browser = ConfigurationManager.AppSettings["Browser"].ToString().Trim();
                switch (Browser.Trim().ToLower())
                {
                    case "edge":
                        Webdriver = new EdgeDriver();
                        break;

                    case "ie":
                        Webdriver = new InternetExplorerDriver();
                        break;

                    case "chrome":
                        ChromeOptions options = new ChromeOptions();
                        options.AddArgument("-start-maximized");
                        Webdriver = new ChromeDriver(options);
                        break;

                    default:
                        Webdriver = new FirefoxDriver();
                        Webdriver.Manage().Window.Maximize();
                        break;
                }

                Webdriver.Url = ConfigurationManager.AppSettings["AdminUrl"].ToString().Trim();
                Webdriver.Navigate();
                Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(10);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
