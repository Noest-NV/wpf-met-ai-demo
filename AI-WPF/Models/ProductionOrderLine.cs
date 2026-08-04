using CommunityToolkit.Mvvm.ComponentModel;

namespace AI_WPF.Models
{
    public partial class ProductionOrderLine : ObservableObject
    {
        [ObservableProperty]
        private string _componentName;

        [ObservableProperty]
        private int _quantity;
    }
}
