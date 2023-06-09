using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PlayAndConnect.Models;
public class Info
{
    public int Id { get; set; }
    [Range(7, 100)]
    public int Age { get; set; } = 18;
    public string? Name { get; set; }
    public string? ImagePath { get; set; }
    public string? Description {get; set;}
    public string? Contact {get; set;}
    public User User { get; set; }
    public int UserId { get; set;}
}