using OpenQA.Selenium; // Dependencies IWebElement
using OpenQA.Selenium.Remote; // Dependencies RemoteWebDriver
using TestesAutomatizadosSeleniumWebDriver.PATHS.Common; // Dependencies PATHS.Cosmos

namespace TestesAutomatizadosSeleniumWebDriver.PAGES.Common
{
    public class PAGE_Common_For_Cosmos : PAGE_Common_For_All
    {
        // Construtor que permite ser chamado pela DSL e TEST.
        public PAGE_Common_For_Cosmos(RemoteWebDriver driverFirefox) : base(driverFirefox) { }

        /* ==================================================  IMAGES  ==================================================*/
        // Imagem CosmosNet comum ao Cosmos.
        public IWebElement ImageCosmosNet() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Common_For_Cosmos.ImageCosmosNet)); }

        // Imagem PagueMenos comum ao Cosmos.
        public IWebElement ImagePagueMenos() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Common_For_Cosmos.ImagePagueMenos)); }

        /* ==================================================  LINK  ==================================================*/
        // Link CosmosNet comum ao Cosmos.
        public IWebElement LinkCosmosNet() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Common_For_Cosmos.LinkCosmosNet)); }

        /* ==================================================  FOOTER  ==================================================*/
        // Rodapé "Empreendimentos Pague Menos" comum ao Cosmos.
        public IWebElement FooterEmpreendimentosPagueMenos() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Common_For_Cosmos.FooterEmpreendimentosPagueMenos)); }
    }
}
