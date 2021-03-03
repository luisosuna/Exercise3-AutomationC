﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3_AutomationC.Base
{
    public class AmazonPage
    {
        protected AmazonBrowser browser;
        protected IWebDriver driver;
        
        public AmazonPage()
        {
            browser = new AmazonBrowser();
            driver = browser.CreateBrowser(AmazonBrowser.Browser.Chrome);
            PageFactory.InitElements(driver, this);
        }


    }
}