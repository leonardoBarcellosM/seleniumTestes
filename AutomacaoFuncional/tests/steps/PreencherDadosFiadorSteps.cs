using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class PreencherDadosFiadorSteps
    {
        private PreencherDadosFiadorActions pageAction = new PreencherDadosFiadorActions();

        [Given(@"Preencho os dados completos do fiador")]
        public void GivenPreenchoDadosCompletosFiador()
        {
            bool result = pageAction.PreencherDadosFiador();

                Assert.That(result, Is.True, "Erro ao preencher os dados!");
        }

        [When(@"Preencho contato e endereco")]
        public void WhenPreenchoContatoEEndereco()
        {
            bool result = pageAction.PreencherContatoEndereco();

                Assert.That(result, Is.True, "Erro ao preencher os dados!");
        }

        [When(@"Clico em proximo")]
        public void WhenClicoEmProximo()
        {
            bool result = pageAction.Prosseguir();

                Assert.That(result, Is.True, "Erro ao prosseguir!");
        }


        [Then(@"Validar direcionamento Dados Curso")]
        public void ThenDirecionamentoDadosCurso()
        {
            var result = pageAction.ValidarDirecionamentoDadosCurso();

                Assert.That(result, Is.True, "Erro durante o direcionamento para a tela de Dados do Curso/ Erro preenchimento de dados do fiador!");
        }
    }
}
