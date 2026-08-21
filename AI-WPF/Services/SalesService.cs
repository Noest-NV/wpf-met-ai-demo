using System;
using System.Collections.ObjectModel;
using AI_WPF.Models;

namespace AI_WPF.Services
{
    public class SalesService : ISalesService
    {
        private readonly IProductionService _productionService;
        private int _nextId = 1;

        public ObservableCollection<SaleOrder> Orders { get; } = new ObservableCollection<SaleOrder>();

        public SalesService(IProductionService productionService)
        {
            _productionService = productionService;
        }

        public SaleOrder CreateFromRobot(Robot robot)
        {
            if (robot == null) throw new ArgumentNullException(nameof(robot));

            var order = new SaleOrder
            {
                Id = _nextId++,
                CreatedOn = DateTime.Now,
                Status = SaleOrderStatus.Pending
            };
            order.Lines.Add(new SaleOrderLine { Robot = robot, Price = robot.Price });
            Orders.Add(order);
            return order;
        }

        public void Approve(SaleOrder order)
        {
            if (order == null) return;
            order.Status = SaleOrderStatus.Approved;
        }

        public void Reject(SaleOrder order)
        {
            if (order == null) return;
            order.Status = SaleOrderStatus.Rejected;
        }
    }
}
