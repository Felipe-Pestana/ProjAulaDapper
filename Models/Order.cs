namespace Models;

public class Order
{
    public const string INSERT =
        "INSERT INTO tb_order (Description, Board, IdItem) VALUES (@description, @board, @IdItem)";
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Board { get; set; }
    public OrderItem Item { get; set; } = new();
}