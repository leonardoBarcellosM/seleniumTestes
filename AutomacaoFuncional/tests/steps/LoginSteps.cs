using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class LoginSteps
    {
        private LoginActions pageAction = new LoginActions();

        [Given(@"Clico no botao Entrar")]
        public void GivenClicoNoBotaoEntrar()
        {
            bool result = pageAction.AcessarTelaLogin();

                Assert.That(result, Is.True, "Erro ao acessar a tela de login!");
        }

        [When(@"Preencho os campos nome e senha ""(.*)""")]
        public void WhenPreenchoCampoESenha(string arg)
        {
            var items = arg.Split(',');
            bool result = pageAction.PreencherCampos(items);

                Assert.That(result, Is.True, "Erro ao preencher usuário e senha!");
        }

        [When(@"Clico em Entrar")]
        public void WhenClicoEntrar()
        {
            bool result = pageAction.Submit();

                Assert.That(result, Is.True, "Erro ao clicar em entrar!");
        }


        [Then(@"Login deve ser ralizado com sucesso")]
        public void ThenLoginRealizadoComSucesso()
        {
            var result = pageAction.ValidarLogin();

                Assert.That(result, Is.True, "Erro ao realizar login!");
        }

        ///////////////////////
        ///

        [When(@"Preencho o campo usuario ""(.*)""")]
        public void WhenPreenchoCampoUsuario(string arg)
        {
            bool result = pageAction.PreencherUsuario(arg);

                Assert.That(result, Is.True, "Erro ao preencher usuário e senha!");
        }


        [Then(@"Validar mensagem de senha incorreta")]
        public void ThenValidarSenhaIncorreta()
        {
            var result = pageAction.ValidarSenhaIncorreta();

                Assert.That(result, Is.True, "Erro ao realizar login!");
        }

    }
}
