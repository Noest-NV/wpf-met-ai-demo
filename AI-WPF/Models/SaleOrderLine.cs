using CommunityToolkit.Mvvm.ComponentModel;

namespace AI_WPF.Models
{
    public partial class SaleOrderLine : ObservableObject
    {
        [ObservableProperty]
        private Robot _robot;

        [ObservableProperty]
        private decimal _price;
    }
}
