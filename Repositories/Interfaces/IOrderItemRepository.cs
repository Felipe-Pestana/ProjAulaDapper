using Models;

namespace Repositories;

public interface IOrderItemRepository
{
    int InsertOrderItem(OrderItem orderItem);
}