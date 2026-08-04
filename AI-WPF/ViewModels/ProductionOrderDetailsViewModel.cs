using AI_WPF.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AI_WPF.ViewModels
{
    public partial class ProductionOrderDetailsViewModel : ObservableObject
    {
        private readonly MainViewModel _main;

        [ObservableProperty]
        private ProductionOrder _order;

        public ProductionOrderDetailsViewModel(ProductionOrder order, MainViewModel main)
        {
            _order = order;
            _main = main;
        }

        [RelayCommand]
        private void Back()
        {
            _main.ShowProduction();
        }
    }
}
