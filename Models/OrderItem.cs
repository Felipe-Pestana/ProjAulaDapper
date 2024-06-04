namespace Models;

public class OrderItem
{
    public const string INSERT = "INSERT INTO tb_item (Description) VALUES (@description); " +
                                 "SELECT CAST(SCOPE_IDENTITY() as int)";

    public int Id { get; set; }

    public string Description { get; set; } = string.Empty;
    
}