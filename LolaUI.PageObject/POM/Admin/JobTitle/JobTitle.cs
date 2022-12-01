using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaUI.PageObject.POM.Admin.JobTitle
{
    public class JobTitle : BasePage
    {
        public JobTitle(IWebDriver driver) : base(driver) { }
            By Admin = By.XPath("//span[text()='Admin']");
            By Job = By.XPath("//span[normalize-space()='Job']");
            By Job_Titles = By.XPath("//a[normalize-space()='Job Titles']");
            By Add = By.XPath("//button[normalize-space()='Add']");
            By JobTitle_Description = By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space']//div//input[@class='oxd-input oxd-input--active']");
            By Type_description_here = By.XPath("//textarea[@placeholder='Type description here']");
            By Add_note = By.XPath("//textarea[@placeholder='Add note']");
            By Save = By.XPath("//button[normalize-space()='Save']");
            By valid_sms = By.XPath("//p[@class='oxd-text oxd-text--p oxd-text--toast-message oxd-toast-content-text']");


        public IWebElement Select_Admin => driver.FindElement(Admin);
        public IWebElement Click_Job => driver.FindElement(Job);
        public IWebElement Select_JobTitles => driver.FindElement(Job_Titles);
        public IWebElement Click_Add => driver.FindElement(Add);
        public IWebElement Input_JobTitle_Description => driver.FindElement(JobTitle_Description);
        public IWebElement Input_Type_description_here => driver.FindElement(Type_description_here);
        public IWebElement Input_Add_note => driver.FindElement(Add_note);
        public IWebElement Btn_Save => driver.FindElement(Save);
        public IWebElement Valid_sms => driver.FindElement(valid_sms);

    }

    }

