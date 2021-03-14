using TestesAutomatizadosSeleniumWebDriver.PAGES.Common; // Dependencies PAGES.Common
using OpenQA.Selenium.Remote; // Dependencies RemoteWebDriver
using OpenQA.Selenium; // Dependencies IWebElement
using TestesAutomatizadosSeleniumWebDriver.PATHS.Cosmos; // Dependencies PATHS.Cosmos

namespace TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos
{
    public class PAGE_Autenticacao_Do_Usuario : PAGE_Common_For_All
    {
        // Construtor que permite ser chamado pela DSL e TEST.
        public PAGE_Autenticacao_Do_Usuario(RemoteWebDriver driverFirefox) : base(driverFirefox) { }

        /* ==================================================  LABELS  ==================================================*/
        // Label "Autenticação do Usuário" na página.
        public IWebElement LabelAutenticacaoDoUsuario() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Autenticacao_Do_Usuario.LabelAutenticacaoDoUsuario)); }

        // Label Usuário na página.
        public IWebElement LabelUsuario() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Autenticacao_Do_Usuario.LabelUsuario)); }

        // Label Senha na página.
        public IWebElement LabelSenha() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Autenticacao_Do_Usuario.LabelSenha)); }

        /* ==================================================  INPUTS  ==================================================*/
        // Campo Usuário na página.
        public IWebElement InputUsuario() { return NovoDriverFirefox.FindElement(By.Id(PATH_Autenticacao_Do_Usuario.InputUsuario)); }

        // Campo Senha na página.
        public IWebElement InputSenha() { return NovoDriverFirefox.FindElement(By.Id(PATH_Autenticacao_Do_Usuario.InputSenha)); }

        /* ==================================================  BUTTON  ==================================================*/
        // Botão "Efetuar Login" na página.
        public IWebElement ButtonEfetuarLogin() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Autenticacao_Do_Usuario.ButtonEfetuarLogin)); }
    }
}
