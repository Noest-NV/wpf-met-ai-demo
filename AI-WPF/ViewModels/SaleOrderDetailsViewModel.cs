using AI_WPF.Models;
using AI_WPF.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AI_WPF.ViewModels
{
    public partial class SaleOrderDetailsViewModel : ObservableObject
    {
        private readonly ISalesService _salesService;
        private readonly MainViewModel _main;

        [ObservableProperty]
        private SaleOrder _order;

        public SaleOrderDetailsViewModel(SaleOrder order, ISalesService salesService, MainViewModel main)
        {
            _order = order;
            _salesService = salesService;
            _main = main;
        }

        [RelayCommand]
        private void Approve()
        {
            _salesService.Approve(Order);
        }

        [RelayCommand]
        private void Reject()
        {
            _salesService.Reject(Order);
        }

        [RelayCommand]
        private void Back()
        {
            _main.ShowSales();
        }
    }
}
