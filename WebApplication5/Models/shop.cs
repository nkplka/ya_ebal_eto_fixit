using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class shop
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Keys { get; set; }

    public string Price { get; set; }
}