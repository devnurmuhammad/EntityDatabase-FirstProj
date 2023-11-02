using System;
using System.Collections.Generic;

namespace EntityDatabase_First.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? Lastname { get; set; }

    public DateTime? Year { get; set; }
}
