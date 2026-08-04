using System.Collections.ObjectModel;
using AI_WPF.Models;

namespace AI_WPF.Services
{
    public interface ISalesService
    {
        ObservableCollection<SaleOrder> Orders { get; }
        SaleOrder CreateFromRobot(Robot robot);
        void Approve(SaleOrder order);
        void Reject(SaleOrder order);
    }
}
