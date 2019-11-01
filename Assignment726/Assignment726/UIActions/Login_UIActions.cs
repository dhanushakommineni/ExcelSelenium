using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Assignment726.Repository;
using Assignment726.GenericHelper;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace Assignment726.UIActions
{
    public class Login_UIActions : Login_UIObjects
    {
        /// <summary>
        /// Add Constructor logic here
        /// </summary>
        public Login_UIActions()
        {
            PageFactory.InitElements(WebdriverManage.Webdriver, this);
        }

        /// <summary>
        /// Add Logic too perform Login actions
        /// </summary>
        public void Login(string Email, string Password)
        {
            Login_UIObjects.ui_Username.SendKeys(Email);
            Login_UIObjects.ui_Password.SendKeys(Password);
            Login_UIObjects.ui_Login.Click();
        }

        /// <summary>
        /// Object Instantiation
        /// </summary>
        #region Instantiation
        private Login_UIObjects _Login_UIObjects;
        public Login_UIObjects Login_UIObjects
        {
            get { return _Login_UIObjects ?? (_Login_UIObjects = new Login_UIObjects()); }
        }
        #endregion
    }
}
