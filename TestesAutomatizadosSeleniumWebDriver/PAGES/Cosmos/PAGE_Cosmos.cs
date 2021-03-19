using TestesAutomatizadosSeleniumWebDriver.PAGES.Common; // Dependencies PAGES.Common
using OpenQA.Selenium.Remote; // Dependencies RemoteWebDriver
using OpenQA.Selenium; // Dependencies IWebElement
using TestesAutomatizadosSeleniumWebDriver.PATHS.Cosmos; // Dependencies PATHS.Cosmos

namespace TestesAutomatizadosSeleniumWebDriver.PAGES.Cosmos
{
    public class PAGE_Cosmos : PAGE_Common_For_All
    {
        // Construtor que permite ser chamado pela DSL e TEST.
        public PAGE_Cosmos(RemoteWebDriver driverFirefox) : base(driverFirefox) { }

        /* ==================================================  IMAGES  ==================================================*/
        // Imagem do módulo Recall.
        public IWebElement ImageRecall5Module() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageRecall5Module)); }

        // Imagem do módulo Administração Pessoal.
        public IWebElement ImageAdministracaoPessoalModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageAdministracaoPessoalModule)); }

        // Imagem do módulo Painel de Gestão CRM.
        public IWebElement ImagePainelDeGestaoCRMModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImagePainelDeGestaoCRMModule)); }

        // Imagem do módulo Manutenção.
        public IWebElement ImageManutencaoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageManutencaoModule)); }

        // Imagem do módulo Cancelar/Inutilizar NFe.
        public IWebElement ImageCancelarInutilizarNFeModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageCancelarInutilizarNFeModule)); }

        // Imagem do módulo Administração Pessoal 2.
        public IWebElement ImageAdministracaoPessoal2Module() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageAdministracaoPessoal2Module)); }

        // Imagem do módulo Manutenção 2.
        public IWebElement ImageManutencao2Module() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageManutencao2Module)); }

        // Imagem do módulo Cancelar/Inutilizar NFe2.
        public IWebElement ImageCancelarInutilizarNFe2Module() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageCancelarInutilizarNFe2Module)); }

        // Imagem do módulo Preços.
        public IWebElement ImagePrecosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImagePrecosModule)); }

        // Imagem do módulo NFe.
        public IWebElement ImageNFeModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageNFeModule)); }

        // Imagem do módulo Clinic Farma.
        public IWebElement ImageClinicFarmaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageClinicFarmaModule)); }

        // Imagem do módulo Importação Exportação.
        public IWebElement ImageImportacaoExportacaoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageImportacaoExportacaoModule)); }

        // Imagem do módulo Documentos Sanitários.
        public IWebElement ImageDocumentosSanitariosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageDocumentosSanitariosModule)); }

        // Imagem do módulo Cartão Sempre.
        public IWebElement ImageCartaoSempreModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageCartaoSempreModule)); }

        // Imagem do módulo Anotação de Dados.
        public IWebElement ImageAnotacaoDeDadosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageAnotacaoDeDadosModule)); }

        // Imagem do módulo Relatorios.
        public IWebElement ImageRelatoriosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageRelatoriosModule)); }

        // Imagem do módulo PDG.
        public IWebElement ImagePDGModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImagePDGModule)); }

        // Imagem do módulo Controle de Despesas.
        public IWebElement ImageControleDeDespesasModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageControleDeDespesasModule)); }

        // Imagem do módulo Frente de Loja.
        public IWebElement ImageFrenteDeLojaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageFrenteDeLojaModule)); }

        // Imagem do módulo Painel Desenvolvimento.
        public IWebElement ImagePainelDesenvolvimentoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImagePainelDesenvolvimentoModule)); }

        // Imagem do módulo Última Chance (Novo).
        public IWebElement ImageUltimaChanceNovoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageUltimaChanceNovoModule)); }

        // Imagem do módulo Inventário Parcial.
        public IWebElement ImageInventarioParcialModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageInventarioParcialModule)); }

        // Imagem do módulo Gestão Telefonia.
        public IWebElement ImageGestaoTelefoniaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageGestaoTelefoniaModule)); }

        // Imagem do módulo Padrões Internos.
        public IWebElement ImagePadroesInternosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImagePadroesInternosModule)); }

        // Imagem do módulo AIO.
        public IWebElement ImageAIOModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageAIOModule)); }

        // Imagem do módulo Cliente Sempre.
        public IWebElement ImageClienteSempreModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageClienteSempreModule)); }

        // Imagem do módulo Benefícios.
        public IWebElement ImageBeneficiosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageBeneficiosModule)); }

        // Imagem do módulo Sistema de Férias.
        public IWebElement ImageSistemaDeFeriasModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageSistemaDeFeriasModule)); }

        // Imagem do módulo Encurtador de Urls.
        public IWebElement ImageEncurtadorDeUrlsModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageEncurtadorDeUrlsModule)); }

        // Imagem do módulo Estoque Clinic Farma.
        public IWebElement ImageEstoqueClinicFarmaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageEstoqueClinicFarmaModule)); }

        // Imagem do módulo Controle Adiantamento.
        public IWebElement ImageControleAdiantamentoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageControleAdiantamentoModule)); }

        // Imagem do módulo Entrada Direta.
        public IWebElement ImageEntradaDiretaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageEntradaDiretaModule)); }

        // Imagem do módulo Monitoramento Supply Chain.
        public IWebElement ImageMonitoramentoSupplyChainModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageMonitoramentoSupplyChainModule)); }

        // Imagem do módulo Planejamento Supply Chain.
        public IWebElement ImagePlanejamentoSupplyChainModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImagePlanejamentoSupplyChainModule)); }

        // Imagem do módulo Processos BPM.
        public IWebElement ImageProcessosBPMModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageProcessosBPMModule)); }

        // Imagem do módulo Devoluções de Produtos para o Fornecedor.
        
        public IWebElement ImageDevolucoesDeProdutosParaOFornecedorModule() { return NovoDriverFirefox
                .FindElement(By.CssSelector(PATH_Cosmos.ImageDevolucoesDeProdutosParaOFornecedorModule)); }

        // Imagem do módulo Farmácia Popular Pague Menos.
        public IWebElement ImageFarmaciaPopularPagueMenosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageFarmaciaPopularPagueMenosModule)); }

        // Imagem do módulo Indisponível.
        public IWebElement ImageIndisponivelModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageIndisponivelModule)); }

        // Imagem do módulo Gestão de Suprimentos.
        public IWebElement ImageGestaoDeSuprimentosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageGestaoDeSuprimentosModule)); }

        // Imagem do módulo Cartão Corporativo.
        public IWebElement ImageCartaoCorporativoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageCartaoCorporativoModule)); }

        // Imagem do módulo Suporte de pedidos ecommerce.
        public IWebElement ImageSuporteDePedidosEcommerceModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.ImageSuporteDePedidosEcommerce)); }

        /* ==================================================  LINKS  ==================================================*/
        // Link do módulo Recall.
        public IWebElement LinkRecall5Module() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkRecall5Module)); }

        // Link do módulo Administração Pessoal.
        public IWebElement LinkAdministracaoPessoalModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkAdministracaoPessoalModule)); }

        // Link do módulo Painel de Gestão CRM.
        public IWebElement LinkPainelDeGestaoCRMModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkPainelDeGestaoCRMModule)); }

        // Link do módulo Manutenção.
        public IWebElement LinkManutencaoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkManutencaoModule)); }

        // Link do módulo Cancelar/Inutilizar NFe.
        public IWebElement LinkCancelarInutilizarNFeModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkCancelarInutilizarNFeModule)); }

        // Link do módulo Administração Pessoal 2.
        public IWebElement LinkAdministracaoPessoal2Module() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkAdministracaoPessoal2Module)); }

        // Link do módulo Manutenção 2.
        public IWebElement LinkManutencao2Module() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkManutencao2Module)); }

        // Link do módulo Cancelar/Inutilizar NFe 2.
        public IWebElement LinkCancelarInutilizarNFe2Module() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkCancelarInutilizarNFe2Module)); }

        // Link do módulo Preços.
        public IWebElement LinkPrecosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkPrecosModule)); }

        // Link do módulo NFe.
        public IWebElement LinkNFeModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkNFeModule)); }

        // Link do módulo Clinic Farma.
        public IWebElement LinkClinicFarmaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkClinicFarmaModule)); }

        // Link do módulo Importacação Exportação.
        public IWebElement LinkImportacaoExportacaoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkImportacaoExportacaoModule)); }

        // Link do módulo Documentos Sanitários.
        public IWebElement LinkDocumentosSanitariosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkDocumentosSanitariosModule)); }

        // Link do módulo Cartão Sempre.
        public IWebElement LinkCartaoSempreModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkCartaoSempreModule)); }

        // Link do módulo Anotação de Dados.
        public IWebElement LinkAnotacaoDeDadosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkAnotacaoDeDadosModule)); }

        // Link do módulo Relatorios.
        public IWebElement LinkRelatoriosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkRelatoriosModule)); }

        // Link do módulo PDG.
        public IWebElement LinkPDGModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkPDGModule)); }

        // Link do módulo Controle de Despesas.
        public IWebElement LinkControleDeDespesasModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkControleDeDespesasModule)); }

        // Link do módulo Frente de Loja.
        public IWebElement LinkFrenteDeLojaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkFrenteDeLojaModule)); }

        // Link do módulo Painel Desenvolvimento.
        public IWebElement LinkPainelDesenvolvimentoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkFrenteDeLojaModule)); }

        // Link do módulo Última Chance (Novo).
        public IWebElement LinkUltimaChanceNovoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkUltimaChanceNovoModule)); }

        // Link do módulo Inventário Parcial.
        public IWebElement LinkInventarioParcialModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkInventarioParcialModule)); }

        // Link do módulo Gestão Telefonia.
        public IWebElement LinkGestaoTelefoniaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkGestaoTelefoniaModule)); }

        // Link do módulo Padrões Internos.
        public IWebElement LinkPadroesInternosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkPadroesInternosModule)); }

        // Link do módulo AIO.
        public IWebElement LinkAIOModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkAIOModule)); }

        // Link do módulo Cliente Sempre.
        public IWebElement LinkClienteSempreModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkClienteSempreModule)); }

        // Link do módulo Benefícios.
        public IWebElement LinkBeneficiosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkBeneficiosModule)); }

        // Link do módulo Sistema de Férias.
        public IWebElement LinkSistemaDeFeriasModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkSistemaDeFeriasModule)); }

        // Link do módulo Encurtador de Urls.
        public IWebElement LinkEncurtadorDeUrlsModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkEncurtadorDeUrlsModule)); }

        // Link do módulo Estoque Clinic Farma.
        public IWebElement LinkEstoqueClinicFarmaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkEstoqueClinicFarmaModule)); }

        // Link do módulo Controle Adiantamento.
        public IWebElement LinkControleAdiantamentoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkControleAdiantamentoModule)); }

        // Link do módulo Entrada Direta.
        public IWebElement LinkEntradaDiretaModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkEntradaDiretaModule)); }

        // Link do módulo Monitoramento Supply Chain.
        public IWebElement LinkMonitoramentoSupplyChainModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkMonitoramentoSupplyChainModule)); }

        // Link do módulo Planejamento Supply Chain.
        public IWebElement LinkPlanejamentoSupplyChainModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkPlanejamentoSupplyChainModule)); }

        // Link do módulo Processos BPM.
        public IWebElement LinkProcessosBPMModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkProcessosBPMModule)); }

        // Link do módulo Devoluções de Produtos para o Fornecedor.
        public IWebElement LinkDevolucoesDeProdutosParaOFornecedorModule() { return NovoDriverFirefox
                .FindElement(By.CssSelector(PATH_Cosmos.LinkDevolucoesDeProdutosParaOFornecedorModule)); }

        // Link do módulo Farmácia Popular Pague Menos.
        public IWebElement LinkFarmaciaPopularPagueMenosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkFarmaciaPopularPagueMenosModule)); }

        // Link do módulo Indisponível.
        public IWebElement LinkIndisponivelModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkIndisponivelModule)); }

        // Link do módulo Gestão de Suprimentos.
        public IWebElement LinkGestaoDeSuprimentosModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkGestaoDeSuprimentosModule)); }

        // Link do módulo Cartão Corporativo.
        public IWebElement LinkCartaoCorporativoModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkCartaoCorporativoModule)); }

        // Link do módulo Suporte de pedidos ecommerce.
        public IWebElement LinkSuportePedidosEcommerceModule() { return NovoDriverFirefox.FindElement(By.CssSelector(PATH_Cosmos.LinkSuporteDePedidosEcommerceModule)); }
    }
}
