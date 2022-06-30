using FStoreAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStoreAppLibrary.Data_Layer.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrderById(int orderId);
        Boolean InsertOrder(Order order);
        Boolean UpdateOrder(Order order);
        Boolean DeleteOrder(int orderId);

    }
}
