using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependencies TestClass
using TestesAutomatizadosSeleniumWebDriver.DSL.Common; // Dependencies DSL.Common
using TestesAutomatizadosSeleniumWebDriver.URLS.Cosmos; // Dependencies URLS.Cosmos
using TestesAutomatizadosSeleniumWebDriver.TESTS.Common; // Dependencies TESTS.Common
using TestesAutomatizadosSeleniumWebDriver.PAGES.Common; // Dependencies PAGES.Common
using TestesAutomatizadosSeleniumWebDriver.UTILS.Common; // Dependencies UTILS.Common
using TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos; // Dependencies PAGES.Cosmos
using TestesAutomatizadosSeleniumWebDriver.VALUES.Cosmos; // Dependencies VALUES.Cosmos

namespace TestesAutomatizadosSeleniumWebDriver.TESTS.Cosmos
{
    [TestClass]
    public class TEST_Logoff : TEST_Common_For_All
    {
        [TestInitialize]
        public void Setup()
        {
            DSL_Common_For_All.ClickElement(new PAGE_Common_For_Cosmos(DriverFirefox).LinkCosmosNet(), UTIL_Common_For_All.OneSecond());
        }

        /* ==================================================  ASSERT URL  ==================================================*/
        // Afirma que a URL da página de "Logoff" está correta.
        [TestMethod]
        public void AssertUrlPageLogoff()
        {
            DSL_Common_For_All.WaitPageOnChange(URL_Logoff.UrlLogoff);
        }

        /* ==================================================  ELEMENTS DISPLAYED  ==================================================*/
        // Verifica a visibilidade do cabeçalho na página "Logoff" no Cosmos.
        [TestMethod]
        public void CheckHeaderDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Logoff(DriverFirefox).HeaderServerError());
        }

        // Verifica a visibilidade dos labels na página "Logoff" no Cosmos.
        [TestMethod]
        public void CheckLabelsDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Logoff(DriverFirefox).Label404FileOrDirectoryNotFound());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Logoff(DriverFirefox).
                LabelTheResourceYouAreLookingForMightHaveBeenRemovedHadItsNameChangedOrIsTemporarilyUnavailable());
        }

        /* ==================================================  ORTHOGRAPHY  ==================================================*/
        // Verifica a ortografia do cabeçalho "Server Error" na página "Logoff" no Cosmos.
        [TestMethod]
        public void CompareHeaderServerErrorOrthography()
        {
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Logoff.HeaderServerError, new PAGE_Logoff(DriverFirefox).HeaderServerError());
        }

        // Verifica a ortografia dos labels na página "Logoff" no Cosmos.
        [TestMethod]
        public void CompareLabelsOrthography()
        {
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Logoff.Label404FileOrDirectoryNotFound,
                new PAGE_Logoff(DriverFirefox).Label404FileOrDirectoryNotFound());
            DSL_Common_For_All.CompareOrthographyTextElement(VALUE_Logoff.LabelTheResourceYouAreLookingForMightHaveBeenRemovedHadItsNameChangedOrIsTemporarilyUnavailable,
                new PAGE_Logoff(DriverFirefox).LabelTheResourceYouAreLookingForMightHaveBeenRemovedHadItsNameChangedOrIsTemporarilyUnavailable());
        }
    }
}
