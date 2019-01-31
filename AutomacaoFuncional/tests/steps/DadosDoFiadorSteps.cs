using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class DadosDoFiadorSteps
    {
        private const string V = ",";
        private DadosDoFiadorActions pageAction = new DadosDoFiadorActions();

        [Given(@"Inserir nome e cpf ""(.*)""")]
        public void GivenInserirNomeECpf(string arg)
        {
            bool result = pageAction.InserirNomeECpf(arg);

                Assert.That(result, Is.True, "Erro ao inserir os dados!");
        }

        [When(@"Inserir data de nasc e renda ""(.*)""")]
        public void WhenInserirDataDeNascERenda(string arg)
        {
            var items = arg.Split('-');
            bool result = pageAction.InserirDtaERenda(items);

                Assert.That(result, Is.True, "Erro ao inserir os dados!");
        }

        [When(@"Clicar no botao enviar etapa 3")]
        public void WhenClicarNoBotaoEnviar()
        {
            bool result = pageAction.ClicarEnviarEtapa3();

                Assert.That(result, Is.True, "Erro ao enviar!");
        }

        [Then(@"Validar direcionamento para etapa 4")]
        public void ThenValidarDirecionamentoParaEtapa4()
        {
            var result = pageAction.ValidarDirecionamentoEtapa4();

                Assert.That(result, Is.True, "Erro no direcionamento para a etapa 4");
        }
    }
}
