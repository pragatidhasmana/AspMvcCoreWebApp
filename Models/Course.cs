using System;
using System.Collections.Generic;

namespace AspMvcCoreWebApp.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public decimal? CourseFee { get; set; }
}
