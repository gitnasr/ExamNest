﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExamNest.Models;

public partial class Instructor
{
    public int InstructorId { get; set; }

    public int BranchId { get; set; }

    public int TrackId { get; set; }

    public string UserId { get; set; }

    public virtual Branch Branch { get; set; }

    public virtual Track Track { get; set; }

    public virtual User User { get; set; }
}