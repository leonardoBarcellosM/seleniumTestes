using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages

{
    class IniciarFluxoComeceAgoraMap
    {
        [FindsBy(How = How.XPath, Using = "//INPUT[@id='campoNome']/self::INPUT")]
        [CacheLookup]
        public IWebElement campoNome { get; set; }

        [FindsBy(How = How.XPath, Using = "//INPUT[@id='campoCpf']/self::INPUT")]
        [CacheLookup]
        public IWebElement campoCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "//INPUT[@id='campoTelefone']/self::INPUT")]
        [CacheLookup]
        public IWebElement campoTelefone { get; set; }

        [FindsBy(How = How.Id, Using = "campoEmail")]
        [CacheLookup]
        public IWebElement campoEmail { get; set; }

        [FindsBy(How = How.Id, Using = "campoEmailConf")]
        [CacheLookup]
        public IWebElement campoEmailConf { get; set; }

        [FindsBy(How = How.Id, Using = "campoSenha")]
        [CacheLookup]
        public IWebElement campoSenha { get; set; }

        [FindsBy(How = How.Id, Using = "senhaConf")]
        [CacheLookup]
        public IWebElement senhaConf { get; set; }

        [FindsBy(How = How.XPath, Using = "//BUTTON[@id='btnCadastro']/self::BUTTON")]
        [CacheLookup]
        public IWebElement btnCadastro { get; set; }

    }
}
