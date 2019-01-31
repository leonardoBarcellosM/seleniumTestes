using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class PreencherDadosDoCursoSteps
    {
        private PreencherDadosDoCursoActions pageAction = new PreencherDadosDoCursoActions();

        [Given(@"Preencho matricula e percentual")]
        public void GivenPreenchoMatriculaEPercentual()
        {
            bool result = pageAction.PreencherMatricula();

                Assert.That(result, Is.True, "Erro ao preencher os dados!");
        }

        [When(@"Preencho ano e semestre")]
        public void WhenPreenchoAnoESemestre()
        {
            bool result = pageAction.PreencherAnoSemestre();

                Assert.That(result, Is.True, "Erro ao preencher os dados!");
        }

        [When(@"Clico em documentos")]
        public void WhenClicoEmDocumentos()
        {
            bool result = pageAction.AcessarDocumentos();

                Assert.That(result, Is.True, "Erro ao clicar em documentos!");
        }


        [Then(@"Validar direcionamento documentos")]
        public void ThenValidarDirecionamentoDocumentos()
        {
            var result = pageAction.ValidarDirecionamentoDocumentos();

                Assert.That(result, Is.True, "Erro durante o direcionamento para a tela de documentos!");
        }
    }

}
