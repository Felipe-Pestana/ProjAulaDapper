using System.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories;

public class OrderItemRepository : IOrderItemRepository
{
    private string Conn { get; set; }

    public OrderItemRepository()
    {
        Conn = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
    }
    
    public int InsertOrderItem(OrderItem orderItem)
    {
        int idItem;

        using (var db = new SqlConnection(Conn))
        {
            db.Open();
            idItem = db.ExecuteScalar<int>(OrderItem.INSERT, orderItem);
            db.Close();
        }

        return idItem;
    }
}