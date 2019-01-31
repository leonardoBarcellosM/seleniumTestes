using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class ValidarRendaMinimaMap
    {

        [FindsBy(How = How.XPath, Using = "//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2 and text()=' Seu fiador precisa comprovar renda bruta mínima de R$3.808,14. ']")]
        [CacheLookup]
        public IWebElement MsgRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div[3]/div[2]/div/div/div/div[2]/div/div/label/input")]
        [CacheLookup]
        public IWebElement BtnContinuar { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2 and text()=' Seu fiador possui a renda necessária! ']")]
        [CacheLookup]
        public IWebElement MsgConfirma { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2 and text()=' A renda informada não é suficiente. O valor mínimo precisa ser de R$3.808,14. ']")]
        [CacheLookup]
        public IWebElement MsgRendaInvalida { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][3]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-laranja btn-block']")]
        [CacheLookup]
        public IWebElement BtnEnviar { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][2]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

    }
}
