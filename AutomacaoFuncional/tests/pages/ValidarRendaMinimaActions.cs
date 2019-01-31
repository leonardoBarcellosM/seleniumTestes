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
using System.Windows.Forms;

namespace AutomacaoFuncional.tests.pages
{
    class ValidarRendaMinimaActions : ValidarRendaMinimaMap
    {
        private ClassUtilities util = new ClassUtilities();
        private ConsultaDB db = new ConsultaDB();

        public ValidarRendaMinimaActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ValidarMensagem(string arg)
        {
            bool _result = false;

            try
            {
                Thread.Sleep(1800);
                var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2 and text()=' Seu fiador precisa comprovar renda bruta mínima de R$3.808,14. ']")).Text;
                var text = msg.Split(' ');
                var valor = text[8].Replace("R$", "");

                if (valor == arg)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool InformarRenda(string arg)
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(InputRenda, 30);
                if (InputRenda.Displayed)
                {
                    InputRenda.Click();
                    InputRenda.Clear();
                    InputRenda.SendKeys(arg);
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarMsgRendaInvalida()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(MsgRendaInvalida, 15);
                if (MsgRendaInvalida.Displayed)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarBtnEnviar()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnEnviar, 15);
                if (BtnEnviar.Enabled)
                {
                   //false
                }
                else
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarBtnContinuar()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnContinuar, 15);
                if (BtnContinuar.Displayed)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ClicarBtnContinuar()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnContinuar, 15);
                if (BtnContinuar.Displayed)
                {
                    BtnContinuar.Click();
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarBtnEnviarEnabled()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnEnviar, 15);
                if (BtnEnviar.Enabled)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
                else
                {
                   //false
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarMsgRendaValida()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(MsgConfirma, 15);
                if (MsgConfirma.Displayed)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool AddCpf(string cpf)
        {
            bool _result = false;

            try
            {
                ClassDriver.GetInstance().Driver.Navigate().Refresh();

                util.WaitForElementVisible(InputCpf, 30);
                if (InputCpf.Displayed)
                {
                    InputRenda.Clear();
                    InputCpf.Click();
                    InputCpf.SendKeys(cpf);
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarMensagemFiadorCadastrado(string arg)
        {
            bool _result = false;

            try
            {
                Thread.Sleep(2000);
                var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]")).Text;
                var text = msg.Split(' ');
                var valor = text[8].Replace("R$", "");

                if (valor == arg)
                {
                    _result = true;
                    Thread.Sleep(500);
                }

            }
            catch
            {

            }
            return _result;
        }

        public bool ConsultarRendaMinima()
        {
            bool _result = false;

            try
            {
                string minimo = db.ConsultaRendaMinima();

                var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]")).Text;
                var text = msg.Split(' ');
                var valor = text[8].Replace("R$", "");

                if (valor == minimo+".")
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {
            }
            return _result;
        }
        
    }
}
