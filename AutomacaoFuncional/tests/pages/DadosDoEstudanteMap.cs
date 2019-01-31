using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class DadosDoEstudanteMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group']//input[@id='integrantes']")]
        [CacheLookup]
        public IWebElement InputIntegrantes { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group']//input[@id='renda']")]
        [CacheLookup]
        public IWebElement InputRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='m-t-30']//button[@class='btn btn-laranja btn-block']")]
        [CacheLookup]
        public IWebElement BtnSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "//form//div[2]//*[@id='nomecompleto']")]
        [CacheLookup]
        public IWebElement InputNome { get; set; }

        [FindsBy(How = How.XPath, Using = "//form//div[2]//div[2]//*[@id='cpf']")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div[2]/div[2]/div[1]/div/input")]
        [CacheLookup]
        public IWebElement InputRg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='dataNascimentoEstudante']")]
        [CacheLookup]
        public IWebElement InputDtaNasc { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div[2]/div[3]/div/div/input")]
        [CacheLookup]
        public IWebElement InputNMatric { get; set; }

    }
}
