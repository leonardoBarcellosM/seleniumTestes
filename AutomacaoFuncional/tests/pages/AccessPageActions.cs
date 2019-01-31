using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class AcessPageActions : AccessElementsMap
    {
        private ClassUtilities util = new ClassUtilities();

        public void AccessPage()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool AccessPage(string url)
        {
            bool _result = false;
            try
            {
                ClassDriver.GetInstance().Driver.Navigate().GoToUrl(url);
                _result = true;
            }
            catch (Exception)
            {

            }
            return _result;
        }

        public bool ValidAccessPage()
        {
            bool _result = false;
            try
            {
                IWebElement LogoHome = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div//a[@class='logo']"));
                util.WaitForElementVisible(LogoHome, 25);
                if (LogoHome.Displayed)
                {
                    _result = true;
                }
                else
                {

                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error";
            }
            return _result;
        }

        public bool ValidarAcessoIes()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(10000);
                IWebElement formLogin = ClassDriver.GetInstance().Driver.FindElement(By.Id("formLogin"));
                util.WaitForElementVisible(formLogin, 15);
                if (formLogin.Displayed)
                {
                    _result = true;
                }
                else
                {

                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error";
            }
            return _result;
        }
    }
}
