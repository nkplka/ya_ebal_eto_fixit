﻿using System.ComponentModel.DataAnnotations;
namespace WebApplication5.Models;

public class LoginDB
{
    [Required(ErrorMessage = "Не указан Email")]
    public string Email { get; set; }
         
    [Required(ErrorMessage = "Не указан пароль")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
}