using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class DadosDoEstudanteSteps
    {
        private DadosDoEstudanteActions pageAction = new DadosDoEstudanteActions();

        [Given(@"Inserir o numero de integrantes da familia ""(.*)""")]
        public void GivenInserirONumeroDeIntegrantesDaFamilia(string arg)
        {
            bool result = pageAction.InserirIntegrantes(arg);

                Assert.That(result, Is.True, "Erro ao inserir o número de inetegrantes!");
        }

        [When(@"Inserir a renda bruta mensal ""(.*)""")]
        public void WhenInserirARendaMensal(string arg)
        {
            bool result = pageAction.InserirRenda(arg);

                Assert.That(result, Is.True, "Erro ao inserir a renda bruta mensal!");
        }

        [Given(@"Preencher os dados do estudante")]
        public void GivenPreencherOsDadosDoEstudante()
        {
            bool result = pageAction.PreencherDados();

                Assert.That(result, Is.True, "Erro ao inserir o número de inetegrantes!");
        }

        [Given(@"Clicar no botao enviar")]
        public void GivenClicarNoBotaoEnviar()
        {
            bool result = pageAction.ClicarEnviar();

                Assert.That(result, Is.True, "Erro ao enviar!");
        }

        [Then(@"Validar direcionamento para etapa 3")]
        public void ThenValidarDirecionamentoParaEtapa3()
        {
            var result = pageAction.ValidarDirecionamentoEtapa3();

                Assert.That(result, Is.True, "Erro no direcionamento para a etapa 3");
        }

    }
}
