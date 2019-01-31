﻿using AutomacaoFuncional.tests.utils;
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
    class ValidarFunilIesActions : ValidarFunilIesMap
    {
        private ClassUtilities util = new ClassUtilities();
        private ConsultaDB db = new ConsultaDB();

        public ValidarFunilIesActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ConsultarDB(string bol_id)
        {
            bool _result = false;
            try
            {
               _result = db.Consulta(bol_id);
            }
            catch
            {

            }
            return _result;
        }

        public bool ConsultarDadosFunil()
        {
            bool _result = false;
            string total = "";
            try
            {
                IWebElement[] Element = 
                    {
                    SolicitacoesIniciadas,
                    ReproFundacred,
                    PendFundacred,
                    PendIes,
                    ReproIes,
                    Aprovados
                    };

                string[] dadosList =
             {
                DadosDB.Funil_SolicitacoesIniciadas,
                DadosDB.Funil_ReprovadosFundacred,
                DadosDB.Funil_PendenteAnaliseFundacred,
                DadosDB.Funil_PendenteAnaliseIes,
                DadosDB.Funil_ReprovadosIes,
                DadosDB.Funil_Aprovados
                };

                for (int cont = 0; cont < 6; cont ++)
                {
                    total = Element[cont].Text;
                    dadosList[cont] = total;

                    if (cont == 5)
                    {
                        _result = true;
                    }
                }
                DadosDB.Funil_SolicitacoesIniciadas = dadosList[0];
                DadosDB.Funil_ReprovadosFundacred = dadosList[1];
                DadosDB.Funil_PendenteAnaliseFundacred = dadosList[2];
                DadosDB.Funil_PendenteAnaliseIes = dadosList[3];
                DadosDB.Funil_ReprovadosIes = dadosList[4];
                DadosDB.Funil_Aprovados = dadosList[5];
            }
            catch
            {

            }
            return _result;
        }

        public (bool, string) ValidarIniciados()
        {
            bool _result = false;
            string valores = "Funil: " + DadosDB.Funil_SolicitacoesIniciadas + " | " + "DB: " + DadosDB.SolicitacoesIniciadas;
            try
            {
                if (DadosDB.Funil_SolicitacoesIniciadas == DadosDB.SolicitacoesIniciadas)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return (_result, valores);
        }

        public (bool, string) ValidarPendenteFundacred()
        {
            bool _result = false;
            string valores = "Funil: " + DadosDB.Funil_PendenteAnaliseFundacred + " | " + "DB: " + DadosDB.PendenteAnaliseFundacred;

            try
            {
                if (DadosDB.Funil_PendenteAnaliseFundacred == DadosDB.PendenteAnaliseFundacred)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return (_result, valores);
        }

        public (bool, string) ValidarPendenteIes()
        {
            bool _result = false;
            string valores = "Funil: " + DadosDB.Funil_PendenteAnaliseIes + " | " + "DB: " + DadosDB.PendenteAnaliseIes;

            try
            {
                if (DadosDB.Funil_PendenteAnaliseIes == DadosDB.PendenteAnaliseIes)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return (_result, valores);
        }

        public (bool, string) ValidarAprovados()
        {
            bool _result = false;
            string valores = "Funil: " + DadosDB.Funil_Aprovados + " | " + "DB: " + DadosDB.Aprovados;

            try
            {
                if (DadosDB.Funil_Aprovados == DadosDB.Aprovados)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return (_result, valores);
        }

        public (bool, string) ValidarReprovadosFundacred()
        {
            bool _result = false;
            string valores = "Funil: " + DadosDB.Funil_ReprovadosFundacred + " | " + "DB: " + DadosDB.ReprovadosFundacred;

            try
            {
                if (DadosDB.Funil_ReprovadosFundacred == DadosDB.ReprovadosFundacred)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return (_result, valores);
        }

        public (bool, string) ValidarReprovadosIes()
        {
            bool _result = false;
            string valores = "Funil: " + DadosDB.Funil_ReprovadosIes + " | " + "DB: " + DadosDB.ReprovadosIes;

            try
            {
                if (DadosDB.Funil_ReprovadosIes == DadosDB.ReprovadosIes)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return (_result, valores);
        }
    }
}
