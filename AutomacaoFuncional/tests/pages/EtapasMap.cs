using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class EtapasMap
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='panel main-panel']//div[@class='row'][1]//div[1]//a")]
        [CacheLookup]
        public IWebElement OptionSolicitacao { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-laranja btn-line-wrap btn-destaque btn-block']")]
        [CacheLookup]
        public IWebElement BtnQueroSolicitarCrd { get; set; }
    }


}
