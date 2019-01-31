using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class ValidarRendaSteps
    {
        ValidarRendaMinimaActions pageAction = new ValidarRendaMinimaActions();

        //06 Validar Renda Minima
        [Given(@"Verifico a mensagem renda minima ""(.*)""")]
        public void GivenVerificoARendaMinima(string arg)
        {
            bool result = pageAction.ValidarMensagem(arg);

                Assert.That(result, Is.True, "Erro ao apresentar mensagem sobre a renda mínima!");
        }


        [When(@"Informo renda inferior ""(.*)""")]
        public void WhenInformoRendaInferior(string arg)
        {
            bool result = pageAction.InformarRenda(arg);

                Assert.That(result, Is.True, "Erro inserir a renda!");
        }

        [When(@"valido a mensagem apresentada")]
        public void WhenValidoAMensagemApresentada()
        {
            bool result = pageAction.ValidarMsgRendaInvalida();

                Assert.That(result, Is.True, "Erro ao apresentar mensagem sobre a renda mínima insuficiente!");
        }

        [Then(@"Valido botão enviar desabilitado")]
        public void ThenBotaoDesabilitado()
        {
            bool result = pageAction.ValidarBtnEnviar();

                Assert.That(result, Is.True, "Erro validar se o botão enviar fica desabilitado!");
        }

        //06 Validar Botao Continuar
        [Given(@"Verifico o botão apresentado")]
        public void GivenVerificoBotaoApresentado()
        {
            bool result = pageAction.ValidarMsgRendaInvalida();

                Assert.That(result, Is.True, "Erro ao apresentar o botão para prosseguir com a renda inferior ao mínimo!");
        }

        [When(@"clico no botão")]
        public void WhenClicoNoBotao()
        {
            bool result = pageAction.ClicarBtnContinuar();

                Assert.That(result, Is.True, "Erro ao clicar no botão continuar!");
        }

        [Then(@"Valido botao enviar habilitado")]
        public void ThenBotaoHabilitado()
        {
            bool result = pageAction.ValidarBtnEnviarEnabled();

                Assert.That(result, Is.True, "Erro ao validar se o botão Enviar fica habilitado!");
        }

        //06 Validar Renda Superior
        [Given(@"Informo renda superior ""(.*)""")]
        public void GivenInformoRendaSuperior(string arg)
        {
            bool result = pageAction.InformarRenda(arg);

                Assert.That(result, Is.True, "Erro ao inserir a renda!");
        }

        [When(@"Valido a mensagem")]
        public void WhenValidoAMensagem()
        {
            bool result = pageAction.ValidarMsgRendaValida();

                Assert.That(result, Is.True, "Erro ao apresentar a mensagem sobre a renda acima do mínimo informado!");
        }

        [Then(@"Valido botao enviar habilitado renda valida")]
        public void ThenBotaoHabilitadoRendaValida()
        {
            bool result = pageAction.ValidarBtnEnviarEnabled();

                Assert.That(result, Is.True, "Erro ao validar se o botão Enviar fica habilitado!");
        }

        [Given(@"Informo cpf ""(.*)""")]
        public void GivenInformoCpf(string arg)
        {
            bool result = pageAction.AddCpf(arg);

                Assert.That(result, Is.True, "Erro ao inserir CPF!");
        }

        [Then(@"Valido a mensagem ""(.*)""")]
        public void ThenValidoAMensagem(string arg)
        {
            bool result = pageAction.ValidarMensagemFiadorCadastrado(arg);

                Assert.That(result, Is.True, "Erro ao validar a mensagem quando o fiador já possui cadastro!");
        }

    }
}
