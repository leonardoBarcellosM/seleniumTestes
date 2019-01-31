using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class SelecionarInstituicaoSteps
    {
        private SelecaoDeInstituicaoActions pageAction = new SelecaoDeInstituicaoActions();

        [Given(@"Selecionar instituicao ""(.*)""")]
        public void GivenSelecionarInstituicao(string arg)
        {
            bool result = pageAction.SelecionarInstituicao(arg);

                Assert.That(result, Is.True, "Erro ao selecionar a instituição!");
        }

        [When(@"Selecionar curso ""(.*)""")]
        public void WhenSelecionarCurso(string arg)
        {
            bool result = pageAction.SelecionarCurso(arg);

                Assert.That(result, Is.True, "Erro ao selecionar o curso!");
        }

        [When(@"Clicar no botao aceito os termos")]
        public void WhenClicarNoBotaoAceitoOsTermos()
        {
            bool result = pageAction.AceitarTermoDeUso();

                Assert.That(result, Is.True, "Erro ao aceitar o termo!");
        }

        [Then(@"Validar solicitacao enviada")]
        public void ThenValidarSolicitacaoEnviada()
        {
            var result = pageAction.ValidarSolicitacao();

                Assert.That(result, Is.True, "Erro ao enviar solicitação!");
        }

    }
}
