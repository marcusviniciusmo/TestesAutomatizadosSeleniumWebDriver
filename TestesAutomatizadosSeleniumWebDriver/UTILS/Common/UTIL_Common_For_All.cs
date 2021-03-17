using System; // Dependencies DateTime

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

        // Retorna 500 segundos.
        public static int WaitPageOnChange()
        {
            return Convert.ToInt32(TimeSpan.FromSeconds(500).TotalSeconds);
        }
    }
}
