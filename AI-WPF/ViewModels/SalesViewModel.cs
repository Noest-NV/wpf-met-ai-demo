using System.Collections.ObjectModel;
using AI_WPF.Models;
using AI_WPF.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AI_WPF.ViewModels
{
    public partial class SalesViewModel : ObservableObject
    {
        private readonly ISalesService _salesService;
        private readonly MainViewModel _main;

        public ObservableCollection<SaleOrder> Orders => _salesService.Orders;

        [ObservableProperty]
        private SaleOrder _selectedOrder;

        public SalesViewModel(ISalesService salesService, MainViewModel main)
        {
            _salesService = salesService;
            _main = main;
        }

        // NOTE (debug agent demo): No CanExecute guard and no null-check on SelectedOrder.
        // When the sales list is empty and the user clicks "View details", this throws
        // NullReferenceException on SelectedOrder.PrimaryLine.Robot.Name.
        [RelayCommand]
        private void ViewDetails()
        {
            var robotName = SelectedOrder.PrimaryLine.Robot.Name; // intentional NRE risk
            _main.ShowSaleDetails(SelectedOrder);
        }
    }
}
