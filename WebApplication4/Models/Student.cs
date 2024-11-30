using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime Dob { get; set; }

    public int ClassId { get; set; }

    public virtual Class Class { get; set; } = null!;
}
