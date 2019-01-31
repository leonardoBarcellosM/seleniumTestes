using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class ValidarFunilIesMap
    {
        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[1]/*[text()][2]")]
        [CacheLookup]
        public IWebElement SolicitacoesIniciadas { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[2]/*[text()][3]")]
        [CacheLookup]
        public IWebElement ReproFundacred { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[4]/*[text()][3]")]
        [CacheLookup]
        public IWebElement PendFundacred { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[6]/*[text()][3]")]
        [CacheLookup]
        public IWebElement ReproIes { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[5]/*[text()][2]")]
        [CacheLookup]
        public IWebElement PendIes { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @class='funnel-chart']/*/*[8]/*[text()][2]")]
        [CacheLookup]
        public IWebElement Aprovados { get; set; }
        
    }
}
