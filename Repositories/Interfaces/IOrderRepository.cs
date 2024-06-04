using Models;

namespace Repositories;

public interface IOrderRepository
{
    bool InsertOrder(Order order);
}