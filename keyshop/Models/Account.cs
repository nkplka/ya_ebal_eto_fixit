namespace WebApplication5.Models;

public class Account
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
 
    public int? RoleId { get; set; }
    public Role? Role { get; set; }
}
public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Account> Accounts { get; set; }
    public Role()
    {
        Accounts = new List<Account>();
    }
}