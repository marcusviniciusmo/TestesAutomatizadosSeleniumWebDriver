using TestesAutomatizadosSeleniumWebDriver.PAGES.Common; // Dependencies PAGES.Common
using OpenQA.Selenium.Remote; // Dependencies RemoteWebDriver
using OpenQA.Selenium; // Dependencies IWebElement
using TestesAutomatizadosSeleniumWebDriver.PATHS.Cosmos; // Dependencies PATHS.Cosmos

namespace TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos
{
    public class PAGE_Logoff : PAGE_Common_For_All
    {
        // Construtor que permite ser chamado pela DSL e TEST.
        public PAGE_Logoff(RemoteWebDriver driverFirefox) : base(driverFirefox) { }

        /* ==================================================  HEADER  ==================================================*/
        // Cabeçalho "Server Error" na página "Logoff" no Cosmos.
        public IWebElement HeaderServerError() { return NovoDriverFirefox.FindElement(By.Id(PATH_Logoff.HeaderServerError)); }

        /* ==================================================  LABELS  ==================================================*/
        // Label "404 - File or directory not found" na página "Logoff" no Cosmos
        public IWebElement Label404FileOrDirectoryNotFound() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Logoff.Label404FileOrDirectoryNotFound)); }

        // Label "The resource you are looking for might have been removed, had its name changed, or is temporarily unavailable" na página "Logoff" no Cosmos.
        public IWebElement LabelTheResourceYouAreLookingForMightHaveBeenRemovedHadItsNameChangedOrIsTemporarilyUnavailable() {
            return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Logoff.LabelTheResourceYouAreLookingForMightHaveBeenRemovedHadItsNameChangedOrIsTemporarilyUnavailable)); }
    }
}
