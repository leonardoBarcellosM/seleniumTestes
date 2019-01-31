using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class LoginSIesteps
    {
        private LoginIesActions pageAction = new LoginIesActions();

        [Given(@"Informo o email ""(.*)""")]
        public void GivenInformoOEmail(string arg)
        {
            bool result = pageAction.InformarEmail(arg);

                Assert.That(result, Is.True, "Erro ao preencher o campo e-mail!");
        }

        [When(@"Informo a senha ""(.*)""")]
        public void WhenInformoASenha (string arg)
        {
            bool result = pageAction.InformarSenha(arg);

                Assert.That(result, Is.True, "Erro ao preencher o campo senha!");
        }

        [When(@"Clico no botao Entrar")]
        public void WhenClicoNoBotaoEntrar()
        {
            bool result = pageAction.ClicarEmEntrar();

                Assert.That(result, Is.True, "Erro ao clicar em entrar!");
        }


        [Then(@"Validar login com sucesso")]
        public void ThenValidarLoginComSucesso()
        {
            var result = pageAction.ValidarLogin();

                Assert.That(result, Is.True, "Erro ao realizar login!");
        }
    }
}
