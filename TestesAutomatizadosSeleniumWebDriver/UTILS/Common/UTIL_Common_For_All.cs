using System; // Dependencies DateTime
using TestesAutomatizadosSeleniumWebDriver.MODELS.Cosmos; // Dependencies MODELS.Cosmos
using TestesAutomatizadosSeleniumWebDriver.VALUES.Common; // Dependencies VALUES.Common

namespace TestesAutomatizadosSeleniumWebDriver.UTILS.Common
{
    public class UTIL_Common_For_All
    {
        /* ==================================================  ACTUAL YEAR  ==================================================*/
        // Retorna o ano atual.
        public static int GetActualYear()
        {
            return DateTime.Now.Year;
        }

        /* ==================================================  WAIT  ==================================================*/
        // Retorna 1 segundo (em milisegundos).
        public static int OneSecond()
        {
            return Convert.ToInt32(TimeSpan.FromMilliseconds(1000).TotalMilliseconds);
        }

        public static int ThreeSeconds()
        {
            return Convert.ToInt32(TimeSpan.FromMilliseconds(3000).TotalMilliseconds);
        }

        // Retorna 500 segundos.
        public static int WaitPageOnChange()
        {
            return Convert.ToInt32(TimeSpan.FromSeconds(500).TotalSeconds);
        }

        /* ==================================================  ENTRY  ==================================================*/
        // Retorna um objeto de login.
        public static MODEL_Cosmos_Entry DefaultEntry(string user = null)
        {
            MODEL_Cosmos_Entry defaultEntry = new MODEL_Cosmos_Entry();

            defaultEntry.User = user != null ? user : VALUE_Common_For_All.DefaultUser;
            defaultEntry.Password = VALUE_Common_For_All.DefaultPassword;

            return defaultEntry;
        }
    }
}
