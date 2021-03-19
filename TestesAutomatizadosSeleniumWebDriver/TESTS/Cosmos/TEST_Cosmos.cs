using Microsoft.VisualStudio.TestTools.UnitTesting; // Dependencies TestClass
using TestesAutomatizadosSeleniumWebDriver.TESTS.Common; // Dependencies TESTS.Common
using TestesAutomatizadosSeleniumWebDriver.DSL.Cosmos; // Dependencies DSL.Cosmos
using TestesAutomatizadosSeleniumWebDriver.DSL.Common; // Dependencies DSL.Common
using TestesAutomatizadosSeleniumWebDriver.URLS.Cosmos; // Dependencies URLS.Cosmos
using TestesAutomatizadosSeleniumWebDriver.UTILS.Common; // Dependencies UTILS.Common
using TestesAutomatizadosSeleniumWebDriver.PAGES.Common; // Dependencies PAGES.Common
using TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos; // Dependencies PAGES.Cosmos

namespace TestesAutomatizadosSeleniumWebDriver.TESTS.Cosmos
{
    [TestClass]
    public class TEST_Cosmos : TEST_Common_For_All
    {
        [TestInitialize]
        public void Setup()
        {
            DSL_Autenticacao_Do_Usuario.LogIntoCosmos(UTIL_Common_For_All.DefaultEntry());
            DSL_Common_For_All.WaitPageOnChange(URL_Cosmos.UrlCosmos);
            DSL_Common_For_All.SimpleWait(UTIL_Common_For_All.ThreeSeconds());
        }

        /* ==================================================  ASSERT URL  ==================================================*/
        // Afirma que a URL da página do Cosmos está correta.
        [TestMethod]
        public void AssertUrlPageAutenticacaoDoUsuario()
        {
            DSL_Common_For_All.WaitPageOnChange(URL_Cosmos.UrlCosmos);
        }

        /* ==================================================  ELEMENTS DISPLAYED  ==================================================*/
        // Verifica a visibilidade das imagens comuns ao Cosmos.
        [TestMethod]
        public void CheckCommonImagesDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Common_For_Cosmos(DriverFirefox).ImageCosmosNet());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Common_For_Cosmos(DriverFirefox).ImagePagueMenos());
        }

        // Verifica a visibilidade do link CosmosNet na página do Cosmos.
        [TestMethod]
        public void CheckLinkCosmosNetDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Common_For_Cosmos(DriverFirefox).LinkCosmosNet());
            DSL_Common_For_All.SimpleWait(5000);
        }

        // Verifica a visibilidade das imagens dos módulos na página do Cosmos.
        [TestMethod]
        public void CheckModuleImagesDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageRecall5Module());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageAdministracaoPessoalModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImagePainelDeGestaoCRMModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageManutencaoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageCancelarInutilizarNFeModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageAdministracaoPessoal2Module());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageManutencao2Module());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageCancelarInutilizarNFe2Module());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImagePrecosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageNFeModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageClinicFarmaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageImportacaoExportacaoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageDocumentosSanitariosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageCartaoSempreModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageAnotacaoDeDadosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageRelatoriosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImagePDGModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageControleDeDespesasModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageFrenteDeLojaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImagePainelDesenvolvimentoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageUltimaChanceNovoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageInventarioParcialModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageGestaoTelefoniaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImagePadroesInternosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageAIOModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageClienteSempreModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageBeneficiosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageSistemaDeFeriasModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageEncurtadorDeUrlsModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageEstoqueClinicFarmaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageControleAdiantamentoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageEntradaDiretaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageMonitoramentoSupplyChainModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImagePlanejamentoSupplyChainModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageProcessosBPMModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageDevolucoesDeProdutosParaOFornecedorModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageFarmaciaPopularPagueMenosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageIndisponivelModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageGestaoDeSuprimentosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageCartaoCorporativoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).ImageSuporteDePedidosEcommerceModule());
        }

        // Verifica a visibilidade dos links dos módulos na página do Cosmos.
        [TestMethod]
        public void CheckModuleLinksDisplayed()
        {
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkRecall5Module());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkAdministracaoPessoalModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkPainelDeGestaoCRMModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkManutencaoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkCancelarInutilizarNFeModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkAdministracaoPessoal2Module());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkManutencao2Module());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkCancelarInutilizarNFe2Module());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkPrecosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkNFeModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkClinicFarmaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkImportacaoExportacaoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkDocumentosSanitariosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkCartaoSempreModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkAnotacaoDeDadosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkRelatoriosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkPDGModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkControleDeDespesasModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkFrenteDeLojaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkPainelDesenvolvimentoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkUltimaChanceNovoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkInventarioParcialModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkGestaoTelefoniaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkPadroesInternosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkAIOModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkClienteSempreModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkBeneficiosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkSistemaDeFeriasModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkEncurtadorDeUrlsModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkEstoqueClinicFarmaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkControleAdiantamentoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkEntradaDiretaModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkMonitoramentoSupplyChainModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkPlanejamentoSupplyChainModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkProcessosBPMModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkDevolucoesDeProdutosParaOFornecedorModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkFarmaciaPopularPagueMenosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkIndisponivelModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkGestaoDeSuprimentosModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkCartaoCorporativoModule());
            DSL_Common_For_All.CheckElementDisplayed(new PAGE_Cosmos(DriverFirefox).LinkSuportePedidosEcommerceModule());
        }
    }
}
