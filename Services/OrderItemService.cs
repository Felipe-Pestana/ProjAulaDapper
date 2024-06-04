using Models;
using Repositories;

namespace Services;

public class OrderItemService
{
    private IOrderItemRepository _orderItemRepository;
    public OrderItemService()
    {
        _orderItemRepository = new OrderItemRepository();
    }

    public int InsertOrderItem(OrderItem orderItem)
    {
        return _orderItemRepository.InsertOrderItem(orderItem);
    }
}