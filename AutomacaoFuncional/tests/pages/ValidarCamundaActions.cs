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
    class ValidarCamundaActions
    {
        private ClassUtilities util = new ClassUtilities();
        private ConsultaDB db = new ConsultaDB();

        public ValidarCamundaActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool InstanciaCriadaComSucesso()
        {
            bool _result = false;
            Thread.Sleep(1500);

            try
            {
               string result = CamundaApi.GetInstance(MassaDeDados.BKey);

                if (result != null)
                {
                    string Id = result;
                    MassaDeDados.Id = Id;

                        _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarProcessosEstudanteFiador()
        {
            bool _result = false;
            string estudante = null;
            string fiador = null;
            Thread.Sleep(1500);

            try
            {
                (estudante, fiador) = CamundaApi.GetProcessActivities(MassaDeDados.BKey);

                if (estudante == "dados-estudante" && fiador == "dados-fiador")
                {
                   _result = true;

                    string status = CamundaApi.DeleteInstance(MassaDeDados.Id);
                    //if (status == "")
                    //{

                    //}
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool validarProcesso(string arg)
        {
            bool _result = false;
            string etapa = null;

            Thread.Sleep(1500);

            try
            {
                (etapa) = CamundaApi.GetProcessState(MassaDeDados.BKey);

                if (etapa == arg)
                {
                    _result = true;

                    //string status = CamundaApi.DeleteInstance(MassaDeDados.Id);
                    //if (status == "")
                    //{

                    //}
                }
            }
            catch
            {

            }
            return _result;
        }
        

        public bool ValidarVariaveisInicializadas()
        {
            bool _result = true;

            try
            {
                string[] variaveis = CamundaApi.GetVariables(MassaDeDados.Id);
                string[] dados = {MassaDeDados.Ctelefone, MassaDeDados.Cpf, MassaDeDados.Cemail, ":289,", ":19,", MassaDeDados.Cnome +" "+ MassaDeDados.Csobrenome };

                for (int cont = 0; cont < 7; cont ++)
                {
                    if (dados[cont].ToUpper() == variaveis[cont])
                    {
                        //OK
                    }
                    else
                    {
                        _result = false;
                    }
                }
                
            }
            catch
            {

            }
            return _result;
        }
        
    }
}
