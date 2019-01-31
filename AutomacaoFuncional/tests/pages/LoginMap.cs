using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class LoginMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-6 col-xs-6']//a[@class='btn btn-laranja pull-right']")]
        [CacheLookup]
        public IWebElement BtnEntrar { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='cpf']")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='senha']")]
        [CacheLookup]
        public IWebElement InputSenha { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-block btn-laranja btn-entrar']")]
        [CacheLookup]
        public IWebElement BtnSubmit { get; set; }

    }
}
