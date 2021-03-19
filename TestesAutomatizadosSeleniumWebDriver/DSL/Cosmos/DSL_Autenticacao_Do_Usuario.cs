using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependencies Assert
using TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos; // Dependencies PAGES.Cosmos
using TestesAutomatizadosSeleniumWebDriver.DSL.Common; // Dependencies DSL.Common
using TestesAutomatizadosSeleniumWebDriver.MODELS.Cosmos; // Dependencies MODELS.Cosmos

namespace TestesAutomatizadosSeleniumWebDriver.DSL.Cosmos
{
    public class DSL_Autenticacao_Do_Usuario : DSL_Common_For_All
    {
        /* ==================================================  ORTHOGRAPHY BUTTON  ==================================================*/
        // Compara a ortografia do botão "Efetuar Login" na página.
        public static void CompareButtonOrthography(string expectedText)
        {
            Assert.AreEqual(expectedText, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin().GetAttribute("value"));
        }

        /* ==================================================  LOG INTO COSMOS  ==================================================*/
        // Faz login no Cosmos.
        public static void LogIntoCosmos(MODEL_Cosmos_Entry entry)
        {
            ToType(entry.User, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputUsuario());
            ToType(entry.Password, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).InputSenha());
            ClickElement(new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin());
        }
    }
}
