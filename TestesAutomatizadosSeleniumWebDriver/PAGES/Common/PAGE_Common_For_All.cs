using OpenQA.Selenium.Remote; // Dependencies RemoteWebDriver

namespace TestesAutomatizadosSeleniumWebDriver.PAGES.Common
{
    public class PAGE_Common_For_All
    {
        protected RemoteWebDriver NovoDriverFirefox; // Atributo que as PAGEs irão herdar.

        // Construtor que as PAGEs irão chamar através da herança ": base(driverFirefox)"
        public PAGE_Common_For_All(RemoteWebDriver driverFirefox)
        {
            this.NovoDriverFirefox = driverFirefox;
        }
    }
}
