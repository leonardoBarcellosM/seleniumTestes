using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class AccessSteps
    {
        private AcessPageActions pageAction = new AcessPageActions();
        private FilaDeTrabalhoActions Fila = new FilaDeTrabalhoActions();

        [Given(@"Acessar o endereco ""(.*)""")]
        public void GivenAcessarOEndereco(string url)
        {
            var result = pageAction.AccessPage(url);

                Assert.That(result, Is.True, "Erro ao acessar a URL!");
        }
        
        [Then(@"Validar o carregamento")]
        public void ThenValidarOCarregamentoComSucesso()
        {
            var result = pageAction.ValidAccessPage();
            
                Assert.That(result, Is.True, "Erro ao acessar o endereço solicitado!");
        }

        [Then(@"Validar Acesso ao portal")]
        public void ThenValidarAcessoAoPortalIes()
        {
            var result = pageAction.ValidarAcessoIes();

                Assert.That(result, Is.True, "Erro ao acessar o endereço solicitado!");
        }

        [Then(@"Validar Acesso Fila De Trabalho")]
        public void ThenValidarAcessoFilaDeTrabalho()
        {
            var result = Fila.ValidarAcessoFilaDeTrabalho();

            Assert.That(result, Is.True, "Validar Acesso Fila De Trabalho!");
        }

        [When(@"Clico no botao Entrar da fila de trabalho")]
        public void WhenClicoNoBotaoEntrarDaFilaDeTrabalho()
        {
            var result = Fila.Entrar();

            Assert.That(result, Is.True, "Clico no botao Entrar da fila de trabalho!");
        }
    }
}
