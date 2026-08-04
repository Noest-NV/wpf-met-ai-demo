using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AI_WPF.Models
{
    public partial class ProductionOrder : ObservableObject
    {
        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private int _saleOrderId;

        [ObservableProperty]
        private Robot _robot;

        [ObservableProperty]
        private ProductionOrderStatus _status;

        [ObservableProperty]
        private DateTime _estimatedCompletion;

        public ObservableCollection<ProductionOrderLine> Lines { get; } = new ObservableCollection<ProductionOrderLine>();
    }
}
