using System.Collections.ObjectModel;
using AI_WPF.Models;
using AI_WPF.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AI_WPF.ViewModels
{
    public partial class ProductionViewModel : ObservableObject
    {
        private readonly IProductionService _productionService;
        private readonly MainViewModel _main;

        public ObservableCollection<ProductionOrder> Orders => _productionService.Orders;

        [ObservableProperty]
        private ProductionOrder _selectedOrder;

        public ProductionViewModel(IProductionService productionService, MainViewModel main)
        {
            _productionService = productionService;
            _main = main;
        }

        // NOTE (debug agent demo): same bug pattern as SalesViewModel - no null guard.
        [RelayCommand]
        private void ViewDetails()
        {
            var robotName = SelectedOrder.Robot.Name; // intentional NRE risk when list is empty
            _main.ShowProductionDetails(SelectedOrder);
        }
    }
}
