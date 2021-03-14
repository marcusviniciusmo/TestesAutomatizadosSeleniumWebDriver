using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependencies TestClass
using TestesAutomatizadosSeleniumWebDriver.DSL.Common; // Dependencies DSL.Common
using TestesAutomatizadosSeleniumWebDriver.URLS.Cosmos; // Dependencies URLS.Cosmos
using TestesAutomatizadosSeleniumWebDriver.TESTS.Common; // Dependencies TESTS.Common

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
    }
}
