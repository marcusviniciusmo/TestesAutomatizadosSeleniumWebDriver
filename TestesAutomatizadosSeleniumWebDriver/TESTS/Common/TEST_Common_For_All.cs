using TestesAutomatizadosSeleniumWebDriver.DSL.Common; // Dependencies DSL.Common
using OpenQA.Selenium.Remote; // Dependencies RemoteWebDriver
using TestesAutomatizadosSeleniumWebDriver.URLS.Cosmos; // Dependencies URLS.Cosmos
using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependencies TestClass

namespace TestesAutomatizadosSeleniumWebDriver.TESTS.Common
{
    public class TEST_Common_For_All
    {
        private static DSL_Common_For_All driver = new DSL_Common_For_All();
        protected RemoteWebDriver DriverFirefox = driver.GoToCosmosNet(URL_Autenticacao_Do_Usuario.UrlAutenticacaoDoUsuario); // Acessa o CosmosNet

        /* ==================================================  CLOSE FIREFOX  ==================================================*/
        [TestCleanup]
        public void CloseFirefox()
        {
            DriverFirefox.Quit();
        }
    }
}
