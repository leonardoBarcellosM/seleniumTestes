using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace AutomacaoFuncional.tests.pages
{
    class DadosPessoaisActions : DadosPessoaisMap
    {
        private ClassUtilities util = new ClassUtilities();
        private MassaDeDados massa = new MassaDeDados();

        public DadosPessoaisActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool PreencherDadosPessoais()
        {
            bool _result = false;

            util.ScrollElementoPage(InputRg);
            Thread.Sleep(3000);
            string rg = util.GerarRg();

            try
            {
                util.WaitForElementVisible(InputRg, 30);
                if (InputRg.Displayed)
                {
                    Thread.Sleep(300);
                    InputRg.Click();
                    Thread.Sleep(300);
                    InputRg.SendKeys(rg);
                    Thread.Sleep(300);
                    InputDtaNasc.Click();
                    Thread.Sleep(300);
                    InputDtaNasc.SendKeys(massa.dtaNasc);
                    Thread.Sleep(300);
                    RadioMasc.Click();
                    Thread.Sleep(300);
                    RadioNacio.Click();
                    Thread.Sleep(300);
                    ListEstCivil.Click();
                    Thread.Sleep(300);
                    var selectElement = new SelectElement(ListEstCivil);
                    selectElement.SelectByIndex(1);
                    Thread.Sleep(300);
                    RadioUniao.Click();
                    Thread.Sleep(1000);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool PreencherEndereco()
        {
            bool _result = false;

            Thread.Sleep(2000);
            try
            {
                if (InputCep.Displayed)
                {
                    InputCep.Click();
                    Thread.Sleep(300);
                    InputCep.SendKeys(massa.cep);
                    Thread.Sleep(300);
                    BtnBuscarEnder.Click();
                    Thread.Sleep(3000);

                    InputNumero.Click();
                    Thread.Sleep(300);
                    InputNumero.SendKeys(massa.numero);
                    Thread.Sleep(300);

                    InputComplemento.Click();
                    Thread.Sleep(300);
                    InputComplemento.SendKeys(massa.complemento);
                    Thread.Sleep(300);

                    InputNomePai.Click();
                    Thread.Sleep(300);
                    InputNomePai.SendKeys(massa.nomePai);
                    Thread.Sleep(300);

                    InputCpfPai.Click();
                    Thread.Sleep(300);
                    InputCpfPai.SendKeys(util.GerarCpf());
                    Thread.Sleep(300);

                    util.ScrollPage(1);

                    InputNomeMae.Click();
                    Thread.Sleep(300);
                    InputNomeMae.SendKeys(massa.nomeMae);
                    Thread.Sleep(300);

                    InputCpfMae.Click();
                    Thread.Sleep(300);
                    InputCpfMae.SendKeys(util.GerarCpf());
                    Thread.Sleep(300);

                    InputDdd.Click();
                    Thread.Sleep(300);
                    InputDdd.SendKeys(massa.ddd);
                    Thread.Sleep(300);

                    InputNumeroTel.Click();
                    Thread.Sleep(300);
                    InputNumeroTel.SendKeys(massa.numTel);
                    Thread.Sleep(300);

                    InputRamal.Click();
                    Thread.Sleep(300);
                    InputRamal.SendKeys(massa.ramal);

                    _result = true;
                }
                else
                {

                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ClicarEmProximo()
        {
            bool _result = false;

            try
            {
                if (BtnProximo.Displayed) 
                {
                    BtnProximo.Click();
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "else - Erro Validar direcionamento para dados fiador";
                }
            }
            catch
            {
                ClassInfo.GetInstance().LogMessage = "try - Erro Validar direcionamento para dados fiador";
            }
            return _result;
        }

        public bool ValidarDirecionamentoFiador()
        {
            bool _result = false;
            try
            {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//h2[text()='Dados do Fiador ']"));
                util.WaitForElementVisible(Validar, 5);
                if (Validar.Displayed)
                {
                    util.ScrollElementoPage(Validar);
                    _result = true;
                    Thread.Sleep(5000);
                }
                else
                {
                    //ClassInfo.GetInstance().LogMessage = "else - Erro Validar direcionamento para dados fiador";
                }
            }
            catch
            {
               // ClassInfo.GetInstance().LogMessage = "else - Erro Validar direcionamento para dados fiador";
            }
            return _result;
        }

    }
}
