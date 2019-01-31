using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class ValidarFunilIesSteps
    {
        ValidarFunilIesActions pageAction = new ValidarFunilIesActions();

        [Given(@"Consulto os dados no banco ""(.*)""")]
        public void GivenConsultoOsDadosNoBanco(string arg)
        {
            bool result = pageAction.ConsultarDB(arg);
            
                Assert.That(result, Is.True, "Erro ao consultar o banco de dados!"); 
        }

        [Then(@"Consulto os dados do funil")]
        public void ThenConsultoOsDadosDoFunil()
        {
            bool result = pageAction.ConsultarDadosFunil();

            
                Assert.That(result, Is.True, "Erro ao capturar os dados do funil!");
        }

        [Then(@"Valido solicitacoes iniciadas")]
        public void ThenValidoSolicitacoesIniciadas()
        {
            bool result = false;
            string valores = "";

            (result, valores) = pageAction.ValidarIniciados();

                Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido pendente analise fundacred")]
        public void WhenValidoPendenteFundacred()
        {
            bool result = false;
            string valores = "";

            (result, valores) = pageAction.ValidarPendenteFundacred();

                Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido Pendente analise ies")]
        public void WhenValidoPendenteAnaliseIes()
        {
            bool result = false;
            string valores = "";

            (result, valores) = pageAction.ValidarPendenteIes();

                Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido aprovados")]
        public void WhenValidoAprovados()
        {
            bool result = false;
            string valores = "";

            (result, valores) = pageAction.ValidarAprovados();

                Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido reprovados fundacred")]
        public void WhenValidoReprovados()
        {
            bool result = false;
            string valores = "";

            (result, valores) = pageAction.ValidarReprovadosFundacred();

                Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido reprovados ies")]
        public void WhenValidoReprovadosIes()
        {
            bool result = false;
            string valores = "";

            (result, valores) = pageAction.ValidarReprovadosIes();

                Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }
        
    }
}
