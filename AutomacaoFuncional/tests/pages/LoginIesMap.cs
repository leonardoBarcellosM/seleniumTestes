using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class LoginIesMap
    {
        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        public IWebElement InputEmail { get; set; }

        [FindsBy(How = How.Id, Using = "senha")]
        [CacheLookup]
        public IWebElement InputSenha { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='formLogin']//div/../button[1]")]
        [CacheLookup]
        public IWebElement BtnEntrar { get; set; }
    }
}
