using AI_WPF.Models;
using AI_WPF.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AI_WPF.ViewModels
{
    public partial class CatalogueViewModel : ObservableObject
    {
        private readonly ICatalogueService _catalogueService;
        private readonly ISalesService _salesService;
        private readonly MainViewModel _main;

        public System.Collections.ObjectModel.ObservableCollection<Robot> Robots => _catalogueService.Robots;

        public CatalogueViewModel(ICatalogueService catalogueService, ISalesService salesService, MainViewModel main)
        {
            _catalogueService = catalogueService;
            _salesService = salesService;
            _main = main;
        }

        [RelayCommand]
        private void BuyNow(Robot robot)
        {
            if (robot == null) return;
            _salesService.CreateFromRobot(robot);
            _main.ShowSales();
        }
    }
}
