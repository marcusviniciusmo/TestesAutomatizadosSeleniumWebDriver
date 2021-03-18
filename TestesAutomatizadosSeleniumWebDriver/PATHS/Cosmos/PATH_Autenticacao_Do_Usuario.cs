namespace TestesAutomatizadosSeleniumWebDriver.PATHS.Cosmos
{
    public class PATH_Autenticacao_Do_Usuario
    {
        /* ==================================================  CSS SELECTOR  ==================================================*/

        public static string LabelAutenticacaoDoUsuario = ".title>h2:nth-child(1)";
        public static string LabelUsuario = ".content-wrapper>form:nth-child(4)>fieldset:nth-child(1)>div:nth-child(1)>label:nth-child(1)";
        public static string LabelSenha = ".content-wrapper>form:nth-child(4)>fieldset:nth-child(1)>div:nth-child(1)>label:nth-child(5)";
        public static string ButtonEfetuarLogin = ".btAzul";

        /* ==================================================  ID  ==================================================*/

        public static string InputUsuario = "Usuario";
        public static string InputSenha = "Senha";

        /* ==================================================  X PATH  ==================================================*/

        public static string MessageRequiredUser = "/html/body/div/div/div[2]/div[2]/div[2]/div[1]/div[2]/div/div/form/fieldset/div/span[1]/span";
        public static string MessageRequiredPassword = "/html/body/div/div/div[2]/div[2]/div[2]/div[1]/div[2]/div/div/form/fieldset/div/span[2]/span";
    }
}
