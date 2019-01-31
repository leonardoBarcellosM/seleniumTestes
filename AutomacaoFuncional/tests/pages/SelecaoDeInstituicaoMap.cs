using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages

{
    class SelecaoDeInstituicaoMap
    {

        [FindsBy(How = How.Id, Using = "listaIES_chosen")]
        [CacheLookup]
        public IWebElement lista { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-6 col-xs-12 checkbox']//input")]
        [CacheLookup]
        public IWebElement CheckAceite { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='chosen-results'][1]//li[72]")]
        [CacheLookup]
        public IWebElement Option_01 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-6 col-xs-12']//button[@class='btn btn-laranja btn-block']")]
        [CacheLookup]
        public IWebElement BtnSubmit { get; set; }

    }
}
