using System;
using System.ComponentModel.DataAnnotations;

namespace PTD_KTRA.Models;

public class Ca2
{
    [Key]
    public string MyProperty { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}