using Models;
using Repositories;

namespace Services;

public class OrderService
{
    private IOrderRepository _orderRepository;
    private IOrderItemRepository _orderItemRepository;

    public OrderService()
    {
        _orderRepository = new OrderRepository();
        _orderItemRepository = new OrderItemRepository();
    }

    public bool InsertOrder(Order order)
    {
        int idItem = _orderItemRepository.InsertOrderItem(order.Item);
        order.Item.Id = idItem;
        return _orderRepository.InsertOrder(order);
    }
}
