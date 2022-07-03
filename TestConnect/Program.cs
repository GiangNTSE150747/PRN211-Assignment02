using FStoreAppLibrary.Data_Layer;
using FStoreAppLibrary.Data_Layer.Repository;
using FStoreAppLibrary.Models;

public class Program : FStoreContext
{
    public static void Main()
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        Console.WriteLine(((OrderDetailRepository)orderDetailRepository).GetOrderItemsByOrderId(2).Count());
        
        Console.ReadLine();
    }
}