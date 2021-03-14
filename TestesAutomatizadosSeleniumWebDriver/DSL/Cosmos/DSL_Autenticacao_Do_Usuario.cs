using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependencies Assert
using TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos; // Dependencies PAGES.Cosmos
using TestesAutomatizadosSeleniumWebDriver.DSL.Common; // Dependencies DSL.Common

namespace TestesAutomatizadosSeleniumWebDriver.DSL.Cosmos
{
    public class DSL_Autenticacao_Do_Usuario : DSL_Common_For_All
    {
        /* ==================================================  ORTHOGRAPHY BUTTON ==================================================*/
        // Compara a ortografia do botão "Efetuar Login" na página.
        public static void CompareButtonOrthography(string expectedText)
        {
            Assert.AreEqual(expectedText, new PAGE_Autenticacao_Do_Usuario(DriverFirefox).ButtonEfetuarLogin().GetAttribute("value"));
        }
    }
}
