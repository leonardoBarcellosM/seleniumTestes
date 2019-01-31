using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.utils
{
    class ClassDriver
    {
        private static ClassDriver classDriver;
        private IWebDriver driver;


        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }

        private ClassDriver()
        {

        }

        public static ClassDriver GetInstance()
        {
            if (classDriver == null)
            {
                classDriver = new ClassDriver();
            }
            return classDriver;
        }

        public void StartDriver(string typeBrowser)
        {
            
            switch (typeBrowser)
            {
                case "C":
                    Driver = new ChromeDriver();
                    break;

                case "I":
                    Driver = new InternetExplorerDriver();
                    break;

                case "F":                                     
                    Driver = new FirefoxDriver();
                    break;

                case "E":
                    Driver = new EdgeDriver();
                    break;

                case "H":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--window-size=1800,2000", "--headless", "--disable-gpu", "--no-sandbox");
                    driver = new ChromeDriver(options);
                    break;

                default:
                    //Driver = new ChromeDriver();
                    ChromeOptions options2 = new ChromeOptions();
                    // options2.AddArgument("--incognito");
                    driver = new ChromeDriver(options2);
                    break;
            }

            Driver.Manage().Window.Maximize();
        }

        public void QuitDriver()
        {
            Driver.Quit();
        }
    }
}
