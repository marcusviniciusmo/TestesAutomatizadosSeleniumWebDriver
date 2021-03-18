using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependencies TestClass
using TestesAutomatizadosSeleniumWebDriver.DSL.Common; // Dependencies DSL.Common
using TestesAutomatizadosSeleniumWebDriver.URLS.Cosmos; // Dependencies URLS.Cosmos
using TestesAutomatizadosSeleniumWebDriver.TESTS.Common; // Dependencies TESTS.Common
using TestesAutomatizadosSeleniumWebDriver.PAGES.Common; // Dependencies PAGES.Common
using TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos; // Dependencies PAGES.Cosmos
using TestesAutomatizadosSeleniumWebDriver.VALUES.Common; // Dependencies VALUES.Common
using TestesAutomatizadosSeleniumWebDriver.VALUES.Cosmos; // Dependencies VALUES.Cosmos
using TestesAutomatizadosSeleniumWebDriver.UTILS.Common; // Dependencies UTILS.Common

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
            DSL_Common_For_All.WaitPageOnChange(URL_Autenticacao_Do_Usuario.UrlAutenticacaoDoUsuario);
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

        /* ==================================================  ORTHOGRAPHY  ==================================================*/
        // Verifica a ortografia do link CosmosNet na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CompareLinkCosmosNetOrthography()
        {
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Common_For_Cosmos.LinkCosmosNet,
                new PAGE_Common_For_Cosmos(DriverFirefox).LinkCosmosNet());
        }

        // Verifica a ortografia dos labels na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CompareLabelsOrthography()
        {
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Autenticacao_Do_Usuario.LabelAutenticacaoDoUsuario,
                new PAGE_Autenticacao_Do_Usuario(DriverFirefox).LabelAutenticacaoDoUsuario());
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Autenticacao_Do_Usuario.LabelUsuario,
                new PAGE_Autenticacao_Do_Usuario(DriverFirefox).LabelUsuario());
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Autenticacao_Do_Usuario.LabelSenha,
                new PAGE_Autenticacao_Do_Usuario(DriverFirefox).LabelSenha());
        }

        // Verifica a ortografia do botão "Efetuar Login" na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CompareButtonOrthography()
        {
            DSL.Cosmos.DSL_Autenticacao_Do_Usuario.CompareButtonOrthography(VALUE_Autenticacao_Do_Usuario.ButtonEfetuarLogin);
        }

        // Verifica a ortografia do rodapé "Empreendimentos Pague Menos" na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void CompareFooterOrthography()
        {
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Common_For_Cosmos.FooterEmpreendimentosPagueMenos,
                new PAGE_Common_For_Cosmos(DriverFirefox).FooterEmpreendimentosPagueMenos());
        }

        /* ==================================================  CLICK LINK  ==================================================*/
        // Clica no link "CosmosNet" na página "Autenticação do Usuário" no Cosmos.
        [TestMethod]
        public void ClickLinkCosmosNet()
        {
            DSL_Common_For_All.ClickElement(new PAGE_Common_For_Cosmos(DriverFirefox).LinkCosmosNet());
        }

        // Clica no link "CosmosNet" na página "Autenticação do Usuário" no Cosmos, validando a URL Logout.
        [TestMethod]
        public void ClickLinkCosmosNetValidatingUrl()
        {
            DSL_Common_For_All.ClickElement(new PAGE_Common_For_Cosmos(DriverFirefox).LinkCosmosNet(), UTIL_Common_For_All.OneSecond());
            DSL_Common_For_All.WaitPageOnChange(URL_Logoff.UrlLogoff);
        }

        /* ==================================================  TYPE  ==================================================*/
        // Digita um valor qualquer nos campos da página.
        [TestMethod]
        public void TypeTextInInputs()
        {
            DSL_Common_For_All.ToType(VALUE_Common_For_All.DefaultUser, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputUsuario());
            DSL_Common_For_All.ToType(VALUE_Common_For_All.DefaultPassword, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputSenha());
        }

        // Digita letras no campo usuário.
        [TestMethod]
        public void TypeTextInUserInput()
        {
            DSL_Common_For_All.ToType(VALUE_Common_For_All.StringUser, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputUsuario());
        }

        /* ==================================================  LOGIN  ==================================================*/
        // Logar sem digigar uma matrícula.
        [TestMethod]
        public void LogIntoWithoutUser()
        {
            DSL_Common_For_All.ToType(VALUE_Common_For_All.DefaultPassword, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputSenha());
            DSL_Common_For_All.ClickElement(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin(), UTIL_Common_For_All.OneSecond());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).MessageRequiredUser());
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Autenticacao_Do_Usuario.MessageRequired,
                new PAGE_Autenticacao_Do_Usuario(DriverFirefox).MessageRequiredUser());
        }

        // Logar sem digitar uma senha.
        [TestMethod]
        public void LogIntoWithoutPassword()
        {
            DSL_Common_For_All.ToType(VALUE_Common_For_All.DefaultUser, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputUsuario());
            DSL_Common_For_All.ClickElement(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin(), UTIL_Common_For_All.OneSecond());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).MessageRequiredPassword());
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Autenticacao_Do_Usuario.MessageRequired,
                new PAGE_Autenticacao_Do_Usuario(DriverFirefox).MessageRequiredPassword());
        }

        // Logar sem digitar matrícula e senha.
        [TestMethod]
        public void LogIntoWithoutEntry()
        {
            DSL_Common_For_All.ClickElement(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin(), UTIL_Common_For_All.OneSecond());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).MessageRequiredUser());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).MessageRequiredPassword());
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Autenticacao_Do_Usuario.MessageRequired,
                new PAGE_Autenticacao_Do_Usuario(DriverFirefox).MessageRequiredUser());
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Autenticacao_Do_Usuario.MessageRequired,
                new PAGE_Autenticacao_Do_Usuario(DriverFirefox).MessageRequiredPassword());
        }

        // Logar com uma matrícula inválida.
        [TestMethod]
        public void LogIntoWthAnInvalidUser()
        {
            DSL_Common_For_All.ToType(VALUE_Common_For_All.InvalidUser, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputUsuario());
            DSL_Common_For_All.ToType(VALUE_Common_For_All.DefaultPassword, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputSenha());
            DSL_Common_For_All.ClickElement(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin(), UTIL_Common_For_All.OneSecond());
            DSL_Common_For_All.WaitPageOnChange(URL_Cosmos.UrlCosmos);
            DSL_Common_For_All.CheckPageSource(VALUE_Cosmos.ErrorLoginCosmos);
        }

        // Logar no Cosmos.
        [TestMethod]
        public void LoginSuccess()
        {
            DSL_Common_For_All.ToType(VALUE_Common_For_All.DefaultUser, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputUsuario());
            DSL_Common_For_All.ToType(VALUE_Common_For_All.DefaultPassword, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputSenha());
            DSL_Common_For_All.ClickElement(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin(), UTIL_Common_For_All.OneSecond());
            DSL_Common_For_All.WaitPageOnChange(URL_Cosmos.UrlCosmos);
        }
    }
}
