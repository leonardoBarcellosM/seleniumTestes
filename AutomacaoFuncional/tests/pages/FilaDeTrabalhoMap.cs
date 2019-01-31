using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class FilaDeTrabalhoMap
    {
        [FindsBy(How = How.XPath, Using = "/html/body/ng-view/autenticacao-entrar/conteudo/direita/botao")]
        [CacheLookup]
        public IWebElement BtnEntrar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/cabecalho/avatar")]
        [CacheLookup]
        public IWebElement loginSuccess { get; set; }
    }
}
