using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AI_WPF.Models
{
    public partial class SaleOrder : ObservableObject
    {
        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private DateTime _createdOn;

        [ObservableProperty]
        private SaleOrderStatus _status;

        public ObservableCollection<SaleOrderLine> Lines { get; } = new ObservableCollection<SaleOrderLine>();

        /// <summary>Convenience accessor: for this demo each order has a single line.</summary>
        public SaleOrderLine PrimaryLine => Lines.Count > 0 ? Lines[0] : null;

        public string RobotName => PrimaryLine?.Robot?.Name;
        public decimal TotalPrice => PrimaryLine?.Price ?? 0m;
    }
}
