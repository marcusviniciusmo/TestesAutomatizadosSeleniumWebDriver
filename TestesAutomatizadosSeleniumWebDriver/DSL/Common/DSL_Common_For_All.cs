using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependecies Assert
using OpenQA.Selenium.Remote; // Dependencies RemoteWebDriver
using OpenQA.Selenium.Firefox; // Dependencies Firefox
using OpenQA.Selenium; // Dependencies IWebElement

namespace TestesAutomatizadosSeleniumWebDriver.DSL.Common
{
    public class DSL_Common_For_All
    {
        public static RemoteWebDriver DriverFirefox;

        /* ==================================================  OPEN FIREFOX  ==================================================*/
        // Abre o navegador Firefox.
        public void OpenBrowserFirefox()
        {
            DriverFirefox = new FirefoxDriver();
        }

        /* ==================================================  GO TO COSMOSNET  ==================================================*/
        // Acessa o endereço do CosmosNet.
        public RemoteWebDriver GoToCosmosNet(string urlCosmos)
        {
            OpenBrowserFirefox();

            DriverFirefox.Navigate().GoToUrl(urlCosmos);

            return DriverFirefox;
        }

        /* ==================================================  ASSERT URL  ==================================================*/
        // Afirma que a URL da página está correta.
        public static void AssertUrlPage(string urlPage)
        {
            Assert.IsTrue(DriverFirefox.PageSource.Contains(urlPage));
        }

        /* ==================================================  ELEMENT DISPLAYED  ==================================================*/
        // Verifica a visibilidade de um elemento na página.
        public static void CheckElementDisplayed(IWebElement elementDisplayed)
        {
            Assert.IsTrue(elementDisplayed.Displayed);
        }
    }
}
