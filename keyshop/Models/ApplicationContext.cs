using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;

namespace WebApplication5.Models;

public class ApplicationContext: DbContext
{
    public DbSet<shop> Shops
    {
        get;
        set;
    } = null!;
    

    public DbSet<Account> Accounts
    {
        get;
        set;
    } = null!;

    public DbSet<Role> Roles
    {
        get;
        set;
    } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    
    

    
    
}