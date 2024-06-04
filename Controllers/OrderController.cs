using Models;
using Services;

namespace Controllers;

public class OrderController
{
    private OrderService _orderService;
    private OrderItemService _orderItemService;
    public OrderController()
    { 
        _orderService = new OrderService();
        _orderItemService = new OrderItemService();
    } 

    public bool InsertOrder(Order order)
    {
        return _orderService.InsertOrder(order);
    }
}