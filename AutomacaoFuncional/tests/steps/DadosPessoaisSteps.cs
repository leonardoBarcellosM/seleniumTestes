using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class DadosPessoaisSteps
    {
        private DadosPessoaisActions pageAction = new DadosPessoaisActions();

        [Given(@"Inserir os dados pessoais")]
        public void GivenInserirOsDadosPessoais()
        {
            bool result = pageAction.PreencherDadosPessoais();

                Assert.That(result, Is.True, "Erro ao inserir os dados!");
        }

        [When(@"Inserir endereco e contato")]
        public void WhenInserirEnderecoEContato()
        {
            bool result = pageAction.PreencherEndereco();

                Assert.That(result, Is.True, "Erro ao inserir os dados!");
        }

        [When(@"Clicar no botao proximo")]
        public void WhenClicarNoBotaoProximo()
        {
            bool result = ClassInfo.GetInstance().ResultScenario = pageAction.ClicarEmProximo();

                Assert.That(result, Is.True, "Erro ao avançar!");
        }

        [Then(@"Validar direcionamento dados fiador")]
        public void ThenValidarDirecionamentoDadosFiador()
        {
            var result = pageAction.ValidarDirecionamentoFiador();

                Assert.That(result, Is.True, "Erro no direcionamento para o formulário de Dados Do Fiador!");
        }
    }
}
