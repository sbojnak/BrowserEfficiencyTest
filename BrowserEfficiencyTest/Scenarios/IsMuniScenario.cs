using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace BrowserEfficiencyTest.Scenarios
{
    class IsMuniScenario : Scenario
    {

        public IsMuniScenario()
        {
            this.Name = "ismuniscenario";
        }

        public override void Run(RemoteWebDriver driver, string browser, CredentialManager credentialManager, ResponsivenessTimer timer)
        {
            driver.NavigateToUrl("https://www.muni.cz/");
            driver.Wait(2);
            
            driver.TypeIntoField(driver.FindElementById("search"), "PV260" + Keys.Enter);
            driver.Wait(2);

            driver.FindElementsByClassName("gs-title").First().Click();
            driver.WaitForPageLoad();
            driver.Wait(2);

        }
    }
}
