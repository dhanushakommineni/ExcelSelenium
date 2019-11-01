/*
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using System.Data;
using System.Configuration;
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment726.UIActions;
using Assignment726.GenericHelper;
using System.Configuration;
using System.Data;

namespace Assignment726
{
    [TestClass]
    public class TestCases
    {
        /// <summary>
        /// Test case for adding a Hotel Details
        /// </summary>
        [TestMethod]
        public void AddHotel()
        {
            try
            {
                //Arranage
                string Email = ConfigurationManager.AppSettings["Email"].ToString().Trim();
                string Password = ConfigurationManager.AppSettings["Password"].ToString().Trim();
                DataTable TestData = ExcelUtilityHelper.ReadExcel("Insert");

                //Act
                //Login to the Application
                LoginHelper.Login(Email, Password);
                //Navigae to the Dashboard Page
                NavigationHelper.Navigate();
                //Click on Add Button to add Hotel
                HotelHelper.ClickAddButton();
                //Perform actions on Genral Tab
                HotelHelper.PerformGeneralTabActions(TestData);
                //Perform actions on Facilities Tab
                HotelHelper.PerformFacilitiesTabActions();
                //Perform actions on Meta Info Tab
                HotelHelper.PerformMetaInfoTabActions();
                //Perform actions on Policy Tab
                HotelHelper.PerformPolicyTabActions();
                //Perform actions on Contact Tab
                HotelHelper.PerformContactTabActions();
                //Perform actions on Translate Tab
                HotelHelper.PerformTranslateTabActions();
                //Perform actions on Submit
                HotelHelper.ClickSubmit();

                //Assert
                //Verify if 
                Assert.IsTrue(HotelHelper.VerifyHotelName(TestData));
            }
            catch
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test case for Updating Hotel Details
        /// </summary>
        [TestMethod]
        public void UpdateHotel()
        {
            try
            {
                //Arranage
                string Email = ConfigurationManager.AppSettings["Email"].ToString().Trim();
                string Password = ConfigurationManager.AppSettings["Password"].ToString().Trim();
                DataTable TestData = ExcelUtilityHelper.ReadExcel("Update");

                //Login to the Application
                LoginHelper.Login(Email, Password);
                //Navigate to Dashboard Page
                NavigationHelper.Navigate();
                //Verify if Hotel Name exists in the Tablenif not return
                if (!HotelHelper.VerifyHotelNameAndClickEditButton(TestData))
                    return;
                //Perform General Tab actions
                HotelHelper.PerformGeneralTabActions(TestData);
                //Perform Facilities Tab actions
                HotelHelper.PerformFacilitiesTabActions();
                //Perform Meta Info Tab Actions
                HotelHelper.PerformMetaInfoTabActions();
                //Perform Policy Tab Actions
                HotelHelper.PerformPolicyTabActions();
                //Perform Contact tab Actions
                HotelHelper.PerformContactTabActions();
                //Perform Translate Tab actions
                HotelHelper.PerformTranslateTabActions();
                //Click on Update
                HotelHelper.ClickUpdate();
                //Verify if Hotel Name is updated in the Grid / Table 
                Assert.IsTrue(HotelHelper.VerifyHotelName(TestData));
            }
            catch
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test case for Delete Hotel Details
        /// </summary>
        [TestMethod]
        public void DeleteHotel()
        {
            try
            {
                //Arranage
                string Email = ConfigurationManager.AppSettings["Email"].ToString().Trim();
                string Password = ConfigurationManager.AppSettings["Password"].ToString().Trim();
                DataTable TestData = ExcelUtilityHelper.ReadExcel("Delete");

                //Login to the Applciation
                LoginHelper.Login(Email, Password);
                //Navigate to Dahsboard Page
                NavigationHelper.Navigate();
                //Delete a Hotel in the Grid
                HotelHelper.VerifyHotelNameAndDeleteHotel(TestData);

                //Verify if hotel name in the Grid / Table
                Assert.IsTrue(!HotelHelper.VerifyHotelName(TestData));
            }
            catch
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Search Hotel Name in the Grid
        /// </summary>
        [TestMethod]
        public void SearchHotel()
        {
            try
            {
                //Arranage
                string Email = ConfigurationManager.AppSettings["Email"].ToString().Trim();
                string Password = ConfigurationManager.AppSettings["Password"].ToString().Trim();
                DataTable TestData = ExcelUtilityHelper.ReadExcel("Delete");

                //Login into the Application
                LoginHelper.Login(Email, Password);
                //Navigate to Dahsboard Page
                NavigationHelper.Navigate();
                
                //Assert
                //Verify Hotel Name in the Grid 
                Assert.IsTrue(HotelHelper.VerifyHotelName(ExcelUtilityHelper.ReadExcel("Search")));
            }
            catch
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test Initialize
        /// </summary>
        [TestInitialize]
        public void MyTestInitialize()
        {
            WebdriverManage.GetDrvier();
        }

        /// <summary>
        /// Perform Clean up activities
        /// </summary>
        [TestCleanup()]
        public void MyTestCleanup()
        {
            WebdriverManage.Webdriver.Quit();
            WebdriverManage.Webdriver.Dispose();
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

        private NavigateToHotelPage_UIActions navigation;
        public NavigateToHotelPage_UIActions NavigationHelper
        {
            get { return navigation ?? (navigation = new NavigateToHotelPage_UIActions()); }
        }

        private Hotel_UIActions Hotel;
        public Hotel_UIActions HotelHelper
        {
            get { return Hotel ?? (Hotel = new Hotel_UIActions()); }
        }

        private Helpers ExcelUtility;
        public Helpers ExcelUtilityHelper
        {
            get { return ExcelUtility ?? (ExcelUtility = new Helpers()); }
        }
        #endregion
    }
}
