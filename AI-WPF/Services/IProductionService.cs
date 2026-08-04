using System.Collections.ObjectModel;
using AI_WPF.Models;

namespace AI_WPF.Services
{
    public interface IProductionService
    {
        ObservableCollection<ProductionOrder> Orders { get; }
        ProductionOrder CreateFromSaleOrder(SaleOrder saleOrder);
    }
}
