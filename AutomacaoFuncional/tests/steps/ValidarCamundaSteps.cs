using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class ValidarCamundaSteps
    {
        ValidarCamundaActions pageAction = new ValidarCamundaActions();

        [Then(@"Validar instancia criada com sucesso")]
        public void ThenInstanciaCriadaComSucesso()
        {
            var result = pageAction.InstanciaCriadaComSucesso();

            Assert.That(result, Is.True, "Erro!");
        }

        [Then(@"Validar processo de cadastro ""(.*)""")]
        public void ThenValidarCamundaProcessosEstudanteFiador(string arg)
        {
            bool result = false;

            switch (arg)
            {
                case "AnalisarReprovacaoRendaFiador":
                    result = pageAction.validarProcesso("AnalisarReprovacaoRendaFiador");
                    break;
                case "analiseDocumentos":
                    result = pageAction.validarProcesso("");
                    break;
                case "Fiador":
                    result = pageAction.validarProcesso("");
                    break;
               
            }

            Assert.That(result, Is.True, "Erro!");
        }

        [Then(@"Validar variaveis da solicitacao no camunda")]
        public void ThenValidarVariaveisCamunda()
        {
            var result = pageAction.ValidarVariaveisInicializadas();

            Assert.That(result, Is.True, "Erro!");
        } 

    }

}
