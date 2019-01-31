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
    class FilaDeTrabalhoActions : FilaDeTrabalhoMap
    {
        private ClassUtilities util = new ClassUtilities();

        public FilaDeTrabalhoActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ValidarAcessoFilaDeTrabalho()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(loginSuccess, 120);

                if (loginSuccess.Displayed)
                {
                    _result = true;
                }
            }
            catch
            {

            }

            return _result;
        }

        public bool Entrar()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnEntrar, 60);

                if (BtnEntrar.Displayed && BtnEntrar.Displayed)
                {
                    BtnEntrar.Click();
                    Thread.Sleep(4500);
                    ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@id='identifierId']")).SendKeys("leonardo.barcellos@gmail.com");
                    Thread.Sleep(350);
                    ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@id='identifierNext']")).Click();
                    Thread.Sleep(700);
                    ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input")).SendKeys("982701Ll01");
                    Thread.Sleep(350);
                    ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@id='passwordNext']")).Click();
                    
                    _result = true;
                }
            }
            catch
            {

            }

            return _result;
        }
        
    }
}
