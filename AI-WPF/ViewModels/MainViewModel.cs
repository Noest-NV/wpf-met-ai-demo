using AI_WPF.Models;
using AI_WPF.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AI_WPF.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ICatalogueService _catalogueService;
        private readonly ISalesService _salesService;
        private readonly IProductionService _productionService;

        [ObservableProperty]
        private ObservableObject _currentViewModel;

        public MainViewModel(
            ICatalogueService catalogueService,
            ISalesService salesService,
            IProductionService productionService)
        {
            _catalogueService = catalogueService;
            _salesService = salesService;
            _productionService = productionService;

            ShowCatalogue();
        }

        [RelayCommand]
        public void ShowCatalogue()
        {
            CurrentViewModel = new CatalogueViewModel(_catalogueService, _salesService, this);
        }

        [RelayCommand]
        public void ShowSales()
        {
            CurrentViewModel = new SalesViewModel(_salesService, this);
        }

        [RelayCommand]
        public void ShowProduction()
        {
            CurrentViewModel = new ProductionViewModel(_productionService, this);
        }

        public void ShowSaleDetails(SaleOrder order)
        {
            CurrentViewModel = new SaleOrderDetailsViewModel(order, _salesService, this);
        }

        public void ShowProductionDetails(ProductionOrder order)
        {
            CurrentViewModel = new ProductionOrderDetailsViewModel(order, this);
        }
    }
}
