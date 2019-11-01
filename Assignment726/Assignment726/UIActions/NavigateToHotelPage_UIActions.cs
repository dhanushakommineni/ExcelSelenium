using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Assignment726.Repository;
using System.Threading;

namespace Assignment726.UIActions
{
    public class NavigateToHotelPage_UIActions : NavigateToHotelPage_UIObjects
    {
        /// <summary>
        /// Add Logic to navigate to Hotels webpage
        /// </summary>
        public void Navigate()
        {
            act_ClickNavigation("Hotels");
            act_ClickSubNavigation("Hotels");
        }

        /// <summary>
        /// Navigate to Nav - Hotels
        /// </summary>
        /// <param name="strNav"></param>
        private void act_ClickNavigation(string strNav)
        {
            foreach (IWebElement WebElement in PageUIObjects.ui_GetNavigationLinks)
            {
                if (WebElement.Text.Trim().ToLower() != strNav.ToLower())
                    continue;
                WebElement.Click();
                break;
            }
        }

        /// <summary>
        /// Navigate to Sub Nav - Hotels
        /// </summary>
        /// <param name="strSubNav"></param>
        private void act_ClickSubNavigation(string strSubNav)
        {
            foreach (IWebElement WebElement in PageUIObjects.ui_GetSubNavigationLinks)
            {
                if (WebElement.Text.Trim().ToLower() != strSubNav.ToLower())
                    continue;
                WebElement.Click();
                break;
            }
        }

        /// <summary>
        /// Class Instantiation
        /// </summary>
        #region Instantiation
        private NavigateToHotelPage_UIObjects _PageUIObjects;
        public NavigateToHotelPage_UIObjects PageUIObjects
        {
            get { return _PageUIObjects ?? (_PageUIObjects = new NavigateToHotelPage_UIObjects()); }
        }
        #endregion
    }
}
