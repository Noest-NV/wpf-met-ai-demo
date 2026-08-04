using System;
using System.Collections.ObjectModel;
using AI_WPF.Models;

namespace AI_WPF.Services
{
    public class ProductionService : IProductionService
    {
        private int _nextId = 1;

        public ObservableCollection<ProductionOrder> Orders { get; } = new ObservableCollection<ProductionOrder>();

        public ProductionOrder CreateFromSaleOrder(SaleOrder saleOrder)
        {
            if (saleOrder == null) throw new ArgumentNullException(nameof(saleOrder));

            var robot = saleOrder.PrimaryLine?.Robot;
            var order = new ProductionOrder
            {
                Id = _nextId++,
                SaleOrderId = saleOrder.Id,
                Robot = robot,
                Status = ProductionOrderStatus.InProgress,
                EstimatedCompletion = DateTime.Now.AddDays(7)
            };

            // Seed with a few generic components so the details screen has something to show.
            order.Lines.Add(new ProductionOrderLine { ComponentName = "Chassis frame",       Quantity = 1 });
            order.Lines.Add(new ProductionOrderLine { ComponentName = "Servo motor",         Quantity = 6 });
            order.Lines.Add(new ProductionOrderLine { ComponentName = "Control board",      Quantity = 1 });
            order.Lines.Add(new ProductionOrderLine { ComponentName = "Battery pack",       Quantity = 2 });
            order.Lines.Add(new ProductionOrderLine { ComponentName = "Outer shell panels", Quantity = 4 });

            Orders.Add(order);
            return order;
        }
    }
}
