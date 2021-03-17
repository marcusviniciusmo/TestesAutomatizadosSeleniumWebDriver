using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependecies Assert
using OpenQA.Selenium.Remote; // Dependencies RemoteWebDriver
using OpenQA.Selenium.Firefox; // Dependencies Firefox
using OpenQA.Selenium; // Dependencies IWebElement
using System.Threading; // Dependencies Thread
using OpenQA.Selenium.Support.UI; // Dependencies WebDriverWait
using System; // Dependencies TimeSpan
using TestesAutomatizadosSeleniumWebDriver.UTILS.Common; // Dependencies UTILS.Common
using TestesAutomatizadosSeleniumWebDriver.URLS.Cosmos; // Dependencies URLS.Cosmos

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

        /* ==================================================  WAITS  ==================================================*/
        // Cria um tempo de espera para executar uma ação.
        public static void SimpleWait(int wait)
        {
            Thread.Sleep(wait);
        }

        // Cria um tempo de espera até que a página contenha uma url.
        public static void WaitPageOnChange(string urlPage)
        {
            WebDriverWait wait = new WebDriverWait(DriverFirefox, TimeSpan.FromSeconds(UTIL_Common_For_All.WaitPageOnChange()));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(urlPage));
        }

        /* ==================================================  ELEMENT DISPLAYED  ==================================================*/
        // Verifica a visibilidade de um elemento na página.
        public static void CheckElementDisplayed(IWebElement elementDisplayed)
        {
            Assert.IsTrue(elementDisplayed.Displayed);
        }

        /* ==================================================  COMPARE ORTHOGRAPHY  ==================================================*/
        // Compara a ortografia do texto do elemento com um valor esperado.
        public static void CompareOrthographyTextElement(string expectedText, IWebElement actualElement)
        {
            Assert.AreEqual(expectedText, actualElement.Text);
        }

        /* ==================================================  CLICK ELEMENT  ==================================================*/
        // Clica em um elemento na página.
        public static void ClickElement(IWebElement elementToClick, int wait = 0)
        {
            if (wait > 0)
                SimpleWait(wait);

            elementToClick.Click();
        }
    }
}
