using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models
{


    public class shop
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public string Keys { get; set; }

        public int Price { get; set; }
    }
}