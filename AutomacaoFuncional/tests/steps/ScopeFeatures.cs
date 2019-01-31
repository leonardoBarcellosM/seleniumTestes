using AutomacaoFuncional.tests.utils;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    class ScopeFeatures
    {
        private ClassUtilities util = new ClassUtilities();
        //private static ExtentTest featureName;
        //private static ExtentTest scenario;
        //private static ExtentReports extent;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            string dataHora = ClassUtilities.PegarDataHora();

            //var htmlReporter = new ExtentHtmlReporter(@"C:\Users\leonardo.barcellos\Desktop\Fundacred\AutomacaoFuncional\Reports\" + dataHora + " Report.html");
            //htmlReporter.Configuration().DocumentTitle = "Leonardo - Teste Extent Report";
            //htmlReporter.Configuration().Theme = Theme.Dark;
            //extent.AttachReporter(htmlReporter);
            //extent.AddSystemInfo("Automação", "Leonardo Barcellos");
            //extent.AddSystemInfo("SO", "win10");

            //extent = new ExtentReports();

            //////Klov reporter
            //KlovReporter klov = new KlovReporter();

            ////// specify mongoDb connection
            ////klov.InitMongoDbConnection("app.fundacred.org.br", 27017);

            ////// specify project ! you must specify a project, other a "Default project will be used"
            //klov.ProjectName = "Fundacred - Testes Automatizados";

            ////// you must specify a reportName otherwise a default timestamp will be used
            //klov.ReportName = "Build " + DateTime.Now.ToString();

            ////// URL of the KLOV server
            //klov.KlovUrl = "http://app.fundacred.org.br:9090";

            ////// finally, attach the reporter:
            //extent.AttachReporter(klov);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureInfo featureInfo)
        {
            //featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

            string typeBrowser = featureInfo.Title.Contains("-") ? featureInfo.Title.Split('-')[0] : null;
            ClassDriver.GetInstance().StartDriver(typeBrowser);
        }

        [BeforeScenario]
        public static void BeforeScenario(FeatureInfo featureInfo)
        {
            //scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [BeforeStep]
        public static void BeforeStep()
        {

        }


        [AfterStep]
        public static void AfterStep()
        {
            //string errorImage = ClassUtilities.PegarDataHora();
            //var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            //if (ScenarioContext.Current.ScenarioExecutionStatus.ToString() == "StepDefinitionPending")
            //{
            //    if (stepType == "Given")
            //        scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step pendente");
            //    else if (stepType == "When")
            //        scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step pendente");
            //    else if (stepType == "Then")
            //        scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step pendente");
            //}
            //else
            //{
            //    if (ScenarioContext.Current.TestError == null)
            //    {
            //        if (stepType == "Given")
            //            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            //        else if (stepType == "When")
            //            scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
            //        else if (stepType == "Then")
            //            scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            //        else if (stepType == "And")
            //            scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            //    }
            //    else if (ScenarioContext.Current.TestError != null)
            //    {
            //        if (stepType == "Given")
            //        {
            //            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message)
            //               .Fail("<br/>Screenshot <br/><br/>", MediaEntityBuilder.CreateScreenCaptureFromPath(GetScreenShot.Capture(ClassDriver.GetInstance().Driver, errorImage)).Build());
            //        }
            //        else if (stepType == "When")
            //        {
            //            scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message)
            //               .Fail("<br/>Screenshot <br/><br/>", MediaEntityBuilder.CreateScreenCaptureFromPath(GetScreenShot.Capture(ClassDriver.GetInstance().Driver, errorImage)).Build());
            //        }
            //        else if (stepType == "Then")
            //        {
            //            scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message)
            //                .Fail("<br/>Screenshot <br/><br/>", MediaEntityBuilder.CreateScreenCaptureFromPath(GetScreenShot.Capture(ClassDriver.GetInstance().Driver, errorImage)).Build());
            //        }
            //    }
            //}
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            //Assert.True(ClassInfo.GetInstance().ResultScenario, ClassInfo.GetInstance().LogMessage, null);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            ClassDriver.GetInstance().QuitDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            //extent.Flush();
        }           
    }
}
