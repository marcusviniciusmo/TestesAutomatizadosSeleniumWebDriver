using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependencies TestClass
using TestesAutomatizadosSeleniumWebDriver.DSL.Common; // Dependencies DSL.Common
using TestesAutomatizadosSeleniumWebDriver.URLS.Cosmos; // Dependencies URLS.Cosmos
using TestesAutomatizadosSeleniumWebDriver.TESTS.Common; // Dependencies TESTS.Common
using TestesAutomatizadosSeleniumWebDriver.PAGES.Common; // Dependencies PAGES.Common
using TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos; // Dependencies PAGES.Cosmos

namespace TestesAutomatizadosSeleniumWebDriver.TESTS.Cosmos
{
    [TestClass]
    public class TEST_Autenticacao_Do_Usuario : TEST_Common_For_All
    {
        /* ==================================================  ASSERT URL  ==================================================*/
        // Afirma que a URL da página "Autenticação do Usuário" está correta.
        [TestMethod]
        public void AssertUrlPageAutenticacaoDoUsuario()
        {
            DSL_Common_For_All.AssertUrlPage(URL_Autenticacao_Do_Usuario.UrlAutenticacaoDoUsuario);
        }

        /* ==================================================  ELEMENTS DISPLAYED  ==================================================*/
        // Verifica a visibilidade das imagens na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CheckImagesDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Common_For_Cosmos(DriverFirefox).ImageCosmosNet());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Common_For_Cosmos(DriverFirefox).ImagePagueMenos());
        }

        // Verifica a visibilidade do link CosmosNet na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CheckLinkCosmosNetDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Common_For_Cosmos(DriverFirefox).LinkCosmosNet());
        }

        // Verifica a visibilidade dos labels na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CheckLabelsDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).LabelAutenticacaoDoUsuario());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).LabelUsuario());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).LabelSenha());
        }

        // Verifica a visibilidade dos campos na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CheckInputsDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputUsuario());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputSenha());
        }

        // Verifica a visibilidade do botão "Efetuar Login" na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CheckButtonDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin());
        }

        // Verifica a visibilidade do rodapé "Empreendimentos Pague Menos" na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CheckFooterDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Common_For_Cosmos(DriverFirefox).FooterEmpreendimentosPagueMenos());
        }
    }
}
