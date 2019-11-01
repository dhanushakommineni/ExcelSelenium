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
    public class Hotel_UIObjects
    {
        public Hotel_UIObjects()
        {
            PageFactory.InitElements(WebdriverManage.Webdriver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div/form/button[@class='btn btn-success']")]
        public IWebElement ui_AddButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/h3")]
        public IWebElement ui_HotelTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/form/div/ul/li/a")]
        public IList<IWebElement> getAllTabs { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='GENERAL']/div/div/select[@name='hotelstatus']")]
        public IWebElement ui_gen_Status { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='GENERAL']/div/div/input[@name='hotelname']")]
        public IWebElement ui_gen_HotelName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='cke_1_contents']/iframe[@class='cke_wysiwyg_frame cke_reset']")]
        public IWebElement ui_gen_HotelDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='GENERAL']/div/div/select[@name='hotelstars']")]
        public IWebElement ui_gen_Stars { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='GENERAL']/div/div/select[@name='hoteltype']")]
        public IWebElement ui_gen_HotelType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='GENERAL']/div/div/select[@name='isfeatured']")]
        public IWebElement ui_gen_Featured { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='s2id_searching']/a/span/b")]
        public IWebElement ui_gen_Location { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//input[@id='s2id_autogen1']")]
        public IWebElement ui_gen_LocationTxt { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//*[@id='select2-drop']/ul/li/div[@class='select2-result-label']")]
        public IWebElement ui_gen_SelLocation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@name='deposittype']")]
        public IWebElement ui_gen_DepositeType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='depositvalue']")]
        public IWebElement ui_gen_DepositeValue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@name='taxtype']")]
        public IWebElement ui_gen_VatTax { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='taxvalue']")]
        public IWebElement ui_gen_VatTaxValue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='s2id_autogen2']")]
        public IWebElement ui_gen_RelatedHotels { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='GENERAL']/div/div/select[@name='relatedhotels[]']")]
        public IWebElement ui_gen_RelatedHotelsSelect { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='mapaddress']")]
        public IWebElement ui_gen_MapAddress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "html/body/div/div/span/span[@class='pac-matched']")]
        public IWebElement ui_gen_SelMapAddress { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='select_all']")]
        public IWebElement ui_fac_SelectAll { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='hotelmetatitle']")]
        public IWebElement ui_meta_EnterMetaTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@name='hotelkeywords']")]
        public IWebElement ui_meta_EnterMetaKeywords { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@name='hotelmetadesc']")]
        public IWebElement ui_meta_EnterMetaDesc { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='checkintime']")]
        public IWebElement ui_pol_EnterCheckInTime { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='checkouttime']")]
        public IWebElement ui_pol_EnterCheckOutTime { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[.='Payment Options']")]
        public IWebElement ui_pol_ClickLabelPaymentOption { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='s2id_autogen5']")]
        public IWebElement ui_pol_EnterPaymentOption { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='select2-drop']/ul/li/div/span")]
        public IWebElement ui_pol_SelectPaymentOption { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@name='hotelpolicy']")]
        public IWebElement ui_pol_EnterPolicyTerms { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='hotelemail']")]
        public IWebElement ui_con_HotelEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='hotelwebsite']")]
        public IWebElement ui_con_HotelWebsite { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='hotelphone']")]
        public IWebElement ui_con_HotelPhone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='translated[pt][title]']")]
        public IWebElement ui_Tran_PorHotelName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='cke_2_contents']/iframe")]
        public IWebElement ui_Tran_PorHotelDesc { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='add']")]
        public IWebElement ui_ClickAddHotel { get; set; }
        
        [FindsBy(How =How.XPath, Using = ".//table[@class='xcrud-list table table-striped table-hover']/tbody/tr")]
        public IList<IWebElement> ui_verifyHotel { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//*[@id='update']")]
        public IWebElement ui_ClickUpdateHotel { get; set; }
    }
}
