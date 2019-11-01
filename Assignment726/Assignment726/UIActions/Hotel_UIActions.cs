using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment726.Repository;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Data;
using Assignment726.GenericHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment726.UIActions
{
    public class Hotel_UIActions : Hotel_UIObjects
    {
        Hotel_UIObjects objHomeAddHotel_UIObjects = new Hotel_UIObjects();
        DataTable TestData = null;
        /// <summary>
        /// Add constructor logic here
        /// </summary>
        public Hotel_UIActions()
        {
            PageFactory.InitElements(WebdriverManage.Webdriver, this);
        }

        /// <summary>
        /// Click on Add button while saving hotel details
        /// </summary>
        public void ClickAddButton()
        {
            WebdriverManage.Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(10);
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_AddButton);
            HotelUIobjects.ui_AddButton.Click();
        }

        /// <summary>
        /// Logic to click on each tab
        /// </summary>
        /// <param name="strTab"></param>
        public void ClickTab(string strTab)
        {
            foreach (IWebElement WebElement in objHomeAddHotel_UIObjects.getAllTabs)
            {
                if (WebElement.Text.Trim().ToLower() != strTab.ToLower())
                    continue;
                WaitHelper.WaitForElementVisible(WebElement);
                WebElement.Click();

                break;
            }
        }

        /// <summary>
        /// Add logic here tp perform Gernarl Tab Actions
        /// </summary>
        public void PerformGeneralTabActions(DataTable dt)
        {
            TestData = dt;
            WebdriverManage.Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(10);
            ClickTab("General");
            new SelectElement(HotelUIobjects.ui_gen_Status).SelectByValue(TestData.Rows[0]["Status"].ToString().Trim());
            HotelUIobjects.ui_gen_HotelName.Clear();
            HotelUIobjects.ui_gen_HotelName.SendKeys(TestData.Rows[0]["HotelName"].ToString().Trim());
            WebdriverManage.Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(5);
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_gen_HotelDescription);
            if (TestData.TableName.Contains("Insert"))
            {
                HotelUIobjects.ui_gen_HotelDescription.Click();
                HotelUIobjects.ui_gen_HotelDescription.SendKeys(TestData.Rows[0]["HotelDescription"].ToString().Trim());
            }
            new SelectElement(HotelUIobjects.ui_gen_Stars).SelectByValue(TestData.Rows[0]["Stars"].ToString().Trim());
            new SelectElement(HotelUIobjects.ui_gen_HotelType).SelectByText(TestData.Rows[0]["HotelType"].ToString().Trim());
            new SelectElement(HotelUIobjects.ui_gen_Featured).SelectByValue(TestData.Rows[0]["Featured"].ToString().Trim());
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_gen_Location);
            HotelUIobjects.ui_gen_Location.Click();
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_gen_LocationTxt);
            HotelUIobjects.ui_gen_LocationTxt.SendKeys(TestData.Rows[0]["Location"].ToString().Trim());
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_gen_SelLocation);
            HotelUIobjects.ui_gen_SelLocation.Click();
            new SelectElement(HotelUIobjects.ui_gen_DepositeType).SelectByValue(TestData.Rows[0]["Deposit"].ToString().Trim());
            HotelUIobjects.ui_gen_DepositeValue.SendKeys(TestData.Rows[0]["DepositValue"].ToString().Trim());
            new SelectElement(HotelUIobjects.ui_gen_VatTax).SelectByValue(TestData.Rows[0]["VAT"].ToString().Trim());
            HotelUIobjects.ui_gen_VatTaxValue.SendKeys(TestData.Rows[0]["vatvalue"].ToString().Trim());
            HotelUIobjects.ui_gen_RelatedHotels.Click();
            if (HotelUIobjects.ui_gen_RelatedHotelsSelect != null)
            {
                new SelectElement(HotelUIobjects.ui_gen_RelatedHotelsSelect)
                    .SelectByText(TestData.Rows[0]["RelatedHotels"].ToString().Trim());
            }
            WaitHelper.WaitForElementVisible(objHomeAddHotel_UIObjects.ui_gen_MapAddress);
            HotelUIobjects.ui_gen_MapAddress.Clear();
            HotelUIobjects.ui_gen_MapAddress.SendKeys(TestData.Rows[0]["MapAddress"].ToString().Trim());
            //objBaseClass.waitforelementvisible(BaseClass.webdriver, HotelUIobjects.ui_gen_SelMapAddress);
            //HotelUIobjects.ui_gen_SelMapAddress.Click();
        }

        /// <summary>
        /// Add logic here tp perform Facilities Tab Actions
        /// </summary>
        public void PerformFacilitiesTabActions()
        {
            ClickTab("Facilities");
            HotelUIobjects.ui_fac_SelectAll.Click();
        }

        /// <summary>
        /// Add logic here tp perform Meta Info Tab Actions
        /// </summary>
        public void PerformMetaInfoTabActions()
        {
            ClickTab("Meta Info");
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_meta_EnterMetaTitle);
            HotelUIobjects.ui_meta_EnterMetaTitle.Clear();
            HotelUIobjects.ui_meta_EnterMetaTitle.SendKeys(TestData.Rows[0]["MetaTitle"].ToString().Trim());
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_meta_EnterMetaKeywords);
            HotelUIobjects.ui_meta_EnterMetaKeywords.Clear();
            HotelUIobjects.ui_meta_EnterMetaKeywords.SendKeys(TestData.Rows[0]["MetaKeywords"].ToString().Trim());
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_meta_EnterMetaDesc);
            HotelUIobjects.ui_meta_EnterMetaDesc.Clear();
            HotelUIobjects.ui_meta_EnterMetaDesc.SendKeys(TestData.Rows[0]["MetaDesc"].ToString().Trim());
        }
        
        /// <summary>
        /// Add logic here tp perform Policy Tab Actions
        /// </summary>
        public void PerformPolicyTabActions()
        {
            ClickTab("Policy");
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_pol_EnterCheckInTime);
            HotelUIobjects.ui_pol_EnterCheckInTime.Click();
            HotelUIobjects.ui_pol_EnterCheckInTime.Clear();
            HotelUIobjects.ui_pol_EnterCheckInTime.SendKeys(TestData.Rows[0]["CheckInTime"].ToString().Trim());
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_pol_EnterCheckOutTime);
            HotelUIobjects.ui_pol_EnterCheckOutTime.Click();
            HotelUIobjects.ui_pol_EnterCheckOutTime.Clear();
            HotelUIobjects.ui_pol_EnterCheckOutTime.SendKeys(TestData.Rows[0]["CheckOutTime"].ToString().Trim());
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_pol_ClickLabelPaymentOption);
            HotelUIobjects.ui_pol_ClickLabelPaymentOption.Click();
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_pol_EnterPaymentOption);
            HotelUIobjects.ui_pol_EnterPaymentOption.SendKeys(TestData.Rows[0]["PaymentOption"].ToString().Trim());
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_pol_SelectPaymentOption);
            HotelUIobjects.ui_pol_SelectPaymentOption.Click();
            WaitHelper.WaitForElementVisible(objHomeAddHotel_UIObjects.ui_pol_EnterPolicyTerms);
            HotelUIobjects.ui_pol_EnterPolicyTerms.Clear();
            HotelUIobjects.ui_pol_EnterPolicyTerms.SendKeys(TestData.Rows[0]["PolicyTerms"].ToString().Trim());
        }

        /// <summary>
        /// Add logic here tp perform Contact Tab Actions
        /// </summary>
        public void PerformContactTabActions()
        {
            ClickTab("Contact");
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_con_HotelEmail);
            HotelUIobjects.ui_con_HotelEmail.Clear();
            HotelUIobjects.ui_con_HotelEmail.SendKeys(TestData.Rows[0]["HotelEmail"].ToString().Trim());

            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_con_HotelWebsite);
            HotelUIobjects.ui_con_HotelWebsite.Clear();
            HotelUIobjects.ui_con_HotelWebsite.SendKeys(TestData.Rows[0]["HotelWebsite"].ToString().Trim());

            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_con_HotelPhone);
            HotelUIobjects.ui_con_HotelPhone.Clear();
            HotelUIobjects.ui_con_HotelPhone.SendKeys(TestData.Rows[0]["HotelPhone"].ToString().Trim());
        }

        /// <summary>
        /// Add logic here tp perform Translate Tab Actions
        /// </summary>
        public void PerformTranslateTabActions()
        {
            ClickTab("Translate");
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_Tran_PorHotelName);
            HotelUIobjects.ui_Tran_PorHotelName.Clear();
            HotelUIobjects.ui_Tran_PorHotelName.SendKeys(TestData.Rows[0]["PortHotelName"].ToString().Trim());

            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_Tran_PorHotelDesc);
            HotelUIobjects.ui_Tran_PorHotelDesc.Click();
            HotelUIobjects.ui_Tran_PorHotelDesc.SendKeys(TestData.Rows[0]["PortHotelDesc"].ToString().Trim());
        }

        /// <summary>
        /// Click Submit - Add Hotel Details
        /// </summary>
        public void ClickSubmit()
        {
            ((IJavaScriptExecutor)WebdriverManage.Webdriver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_ClickAddHotel);
            HotelUIobjects.ui_ClickAddHotel.Click();

            WebdriverManage.Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(10);
            Console.WriteLine("{0} - Hotel details are Saved!", TestData.Rows[0]["HotelName"].ToString().Trim());
        }

        /// <summary>
        /// Click Update - Update Hotel Details
        /// </summary>
        public void ClickUpdate()
        {
            ((IJavaScriptExecutor)WebdriverManage.Webdriver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
            WaitHelper.WaitForElementVisible(HotelUIobjects.ui_ClickUpdateHotel);
            HotelUIobjects.ui_ClickUpdateHotel.Click();
            
            Console.WriteLine("{0} - Hotel details are Saved!", TestData.Rows[0]["HotelName"].ToString().Trim());
        }
        
        /// <summary>
        /// Verify hotel name in the table
        /// </summary>
        /// <param name="strHotelName"></param>
        /// <returns></returns>
        public bool VerifyHotelName(object strHotelName)
        {
            if(strHotelName.GetType() == typeof(DataTable))
            {
                strHotelName = ((DataTable)strHotelName).Rows[0]["HotelName"].ToString().Trim();
            }
            bool isHotelExists = false;
            IList<IWebElement> rowTD;
            foreach (IWebElement row in objHomeAddHotel_UIObjects.ui_verifyHotel)
            {
                rowTD = row.FindElements(By.TagName("td"));
                foreach (IWebElement cell in rowTD)
                {
                    if (!cell.Text.Trim().ToLower().Contains(((string)strHotelName).Trim().ToLower()))
                        continue;
                    isHotelExists = true;
                    break;
                }
                if (isHotelExists)
                    break;
            }
            return isHotelExists;
        }

        /// <summary>
        /// Verify Hotel name in the table and click on Edit button in the grid 
        /// </summary>
        /// <param name="strHotelName"></param>
        /// <returns></returns>
        public bool VerifyHotelNameAndClickEditButton(DataTable dt)
        {
            bool isHotelExists = false;
            TestData = dt;
            string strHotelName = TestData.Rows[0]["ExistedHotelName"].ToString().Trim();
            IList<IWebElement> rowTD;
            foreach (IWebElement row in objHomeAddHotel_UIObjects.ui_verifyHotel)
            {
                rowTD = row.FindElements(By.TagName("td"));
                foreach (IWebElement cell in rowTD)
                {
                    if (cell.Text.Trim() != strHotelName.Trim())
                        continue;
                    isHotelExists = true;
                    break;
                }
                if (isHotelExists)
                {
                    row.FindElement(By.XPath(".//a[@title='Edit']")).Click();
                    break;
                }
            }
            if (!isHotelExists)
            {
                Console.WriteLine("{0} - Hotel does not exists in the Grid", strHotelName);
            }
            return isHotelExists;
        }

        /// <summary>
        /// Verify hotel name in the table and click on Delete button
        /// </summary>
        /// <param name="strHotelName"></param>
        /// <returns></returns>
        public void VerifyHotelNameAndDeleteHotel(DataTable dt)
        {
            TestData = dt;
            string strHotelName = TestData.Rows[0]["HotelName"].ToString().Trim();
            bool isHotelExists = false;
            IList<IWebElement> rowTD;
            foreach (IWebElement row in objHomeAddHotel_UIObjects.ui_verifyHotel)
            {
                rowTD = row.FindElements(By.TagName("td"));
                foreach (IWebElement cell in rowTD)
                {
                    if (cell.Text.ToLower().Trim() != strHotelName.ToLower().Trim())
                        continue;
                    isHotelExists = true;
                    break;
                }
                if (isHotelExists)
                {
                    row.FindElement(By.XPath(".//a[@title='DELETE']")).Click();
                    WebdriverManage.Webdriver.SwitchTo().Alert().Accept();
                    WebdriverManage.Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(10);
                    Console.WriteLine("{0} - Hotel details are Deleted!", strHotelName);
                    break;
                }
            }
            if (!isHotelExists)
            {
                Console.WriteLine("{0} - Hotel does not exists in the Grid", strHotelName);
            }
        }
        
        /// <summary>
        /// Object Instantiation
        /// </summary>
        #region Instantiation
        private Login_UIActions _LoginHelper;
        public Login_UIActions LoginHelper
        {
            get { return _LoginHelper ?? (_LoginHelper = new Login_UIActions()); }
        }

        private NavigateToHotelPage_UIActions _NavigationHelper;
        public NavigateToHotelPage_UIActions NavigationHelper
        {
            get { return _NavigationHelper ?? (_NavigationHelper = new NavigateToHotelPage_UIActions()); }
        }

        private Hotel_UIObjects _HotelUIobjects;
        private Hotel_UIObjects HotelUIobjects
        {
            get { return _HotelUIobjects ?? (_HotelUIobjects = new Hotel_UIObjects()); }
        }

        private Helpers _WaitHelper;
        private Helpers WaitHelper
        {
            get { return _WaitHelper ?? (_WaitHelper = new Helpers()); }
        }


        #endregion
    }
}