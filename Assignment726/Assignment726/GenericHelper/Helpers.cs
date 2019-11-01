using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Assignment726.GenericHelper
{
    public class Helpers
    {
        /// <summary>
        /// Reading Excel Data
        /// </summary>
        /// <param name="SheetName"></param>
        /// <returns></returns>
        public DataTable ReadExcel(string SheetName)
        {
            try
            {
                string FilePath = System.Configuration.ConfigurationManager.AppSettings["ExcelPath"].ToString(); 
                FileStream Stream = File.Open(FilePath, FileMode.Open, FileAccess.Read);
                IExcelDataReader ExcelReader = ExcelReaderFactory.CreateOpenXmlReader(Stream);
                ExcelReader.IsFirstRowAsColumnNames = true;
                DataSet Result = ExcelReader.AsDataSet();
                return Result.Tables[SheetName];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Wait For Element Visible
        /// </summary>
        /// <param name="webelement"></param>
        /// <returns></returns>
        public bool WaitForElementVisible(IWebElement webelement)
        {
            try
            {
                var wait = new WebDriverWait(WebdriverManage.Webdriver, TimeSpan.FromSeconds(150));
                wait.Until(drv => webelement.Displayed);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
