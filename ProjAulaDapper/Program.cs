using Controllers;
using Models;

Console.WriteLine("Hello, Pedidos!");

Order order = new()
{
    Id = 2,
    Description = "Primeiro Pedido!",
    Board = 13,
    Item = new()
    {
        Description = "Picanha ao alho"
    }
};

try
{
    Console.WriteLine(new OrderController().InsertOrder(order) ? "Pedido Inserido" : "Ocorreu um erro!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}