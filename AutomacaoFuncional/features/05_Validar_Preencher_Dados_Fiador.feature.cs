﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomacaoFuncional.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("05_Validar_Preencher_Dados_Fiador")]
    public partial class _05_Validar_Preencher_Dados_FiadorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "05_Validar_Preencher_Dados_Fiador.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "05_Validar_Preencher_Dados_Fiador", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Acessar o endereco")]
        [NUnit.Framework.CategoryAttribute("01_AcessarPagina")]
        public virtual void _01AcessarOEndereco()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Acessar o endereco", null, new string[] {
                        "01_AcessarPagina"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
testRunner.Given("Acessar o endereco \"http://homologacao.fundacred.org.br/estudante-web/#/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
testRunner.Then("Validar o carregamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 Iniciar Fluxo Comece Agora")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _02IniciarFluxoComeceAgora()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Iniciar Fluxo Comece Agora", null, new string[] {
                        "02_1Etapa"});
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
testRunner.Given("Preencher os dados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
testRunner.When("Clicar em Comece agora sem compromisso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
testRunner.Then("Validar se o fluxo e iniciado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 Iniciar Solicitacao")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _03IniciarSolicitacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Iniciar Solicitacao", null, new string[] {
                        "02_1Etapa"});
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
testRunner.Given("Acessar a opcao solicitacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
testRunner.When("Clicar em quero solicitar o credito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
testRunner.Then("Validar o direcionamento com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04 Selecionar Instituicao")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _04SelecionarInstituicao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04 Selecionar Instituicao", null, new string[] {
                        "02_1Etapa"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
testRunner.Given("Selecionar instituicao \"CENTRO UNIVERSITARIO IESB (GRADUACAO)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
testRunner.When("Selecionar curso \"CIENCIA DA COMPUTACAO-MATUTINO-EDSON MACHADO (SUL)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.And("Clicar no botao aceito os termos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.Then("Validar solicitacao enviada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05 Preencher Dados Do Estudante")]
        [NUnit.Framework.CategoryAttribute("02_2Etapa")]
        public virtual void _05PreencherDadosDoEstudante()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05 Preencher Dados Do Estudante", null, new string[] {
                        "02_2Etapa"});
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
testRunner.Given("Clicar no botao enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
testRunner.Then("Validar direcionamento para etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06 Preencher Dados Do Fiador")]
        [NUnit.Framework.CategoryAttribute("03_3Etapa")]
        public virtual void _06PreencherDadosDoFiador()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06 Preencher Dados Do Fiador", null, new string[] {
                        "03_3Etapa"});
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 42
testRunner.Given("Inserir nome e cpf \" Leonardo Barcellos Teste \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
testRunner.When("Inserir data de nasc e renda \"800,00-06/08/2000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
testRunner.And("Clicar no botao enviar etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
testRunner.Then("Validar direcionamento para etapa 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("07 Preencher Dados Pessoais")]
        [NUnit.Framework.CategoryAttribute("04_4Etapa")]
        public virtual void _07PreencherDadosPessoais()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07 Preencher Dados Pessoais", null, new string[] {
                        "04_4Etapa"});
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 49
testRunner.Given("Inserir os dados pessoais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
testRunner.When("Inserir endereco e contato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.And("Clicar no botao proximo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
testRunner.Then("Validar direcionamento dados fiador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("08 Preencher Dados Completos Do Fiador")]
        [NUnit.Framework.CategoryAttribute("04_4Etapa")]
        public virtual void _08PreencherDadosCompletosDoFiador()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("08 Preencher Dados Completos Do Fiador", null, new string[] {
                        "04_4Etapa"});
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 56
testRunner.Given("Preencho os dados completos do fiador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
testRunner.When("Preencho contato e endereco", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
testRunner.And("Clico em proximo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
testRunner.Then("Validar direcionamento Dados Curso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("09 Validar DB")]
        [NUnit.Framework.CategoryAttribute("04_4Etapa")]
        public virtual void _09ValidarDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("09 Validar DB", null, new string[] {
                        "04_4Etapa"});
#line 62
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 63
testRunner.Then("Validar status de solicitacao no db \"PosFiador\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion