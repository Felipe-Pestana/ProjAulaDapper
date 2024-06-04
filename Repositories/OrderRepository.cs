using System.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories;

public class OrderRepository : IOrderRepository
{
    private string Conn { get; set; }

    public OrderRepository()
    {
        Conn = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
    }
    public bool InsertOrder(Order order)
    {
        var status = false;

        using (var db = new SqlConnection(Conn))
        {
            db.Open();
            db.Execute(Order.INSERT, new
            {
                description = order.Description,
                board = order.Board,
                idItem = order.Item.Id
            });
            
            status = !status;
        }

        return status;
    }
}