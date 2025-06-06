﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamNest.Models
{
    public partial class CorrectExamResult
    {
        public int SubmissionID { get; set; }
        public int ExamID { get; set; }
        public int StudentID { get; set; }
        [StringLength(100)]
        public string StudentName { get; set; }
        public int CourseID { get; set; }
        [StringLength(100)]
        public string CourseName { get; set; }
        public DateTime SubmissionDate { get; set; }
        [Column("Score", TypeName = "decimal(5,2)")]
        public decimal? Score { get; set; }
        [Column("PointsEarned", TypeName = "decimal(10,2)")]
        public decimal? PointsEarned { get; set; }
        [Column("TotalPossiblePoints", TypeName = "decimal(10,2)")]
        public decimal? TotalPossiblePoints { get; set; }
        public int? TotalAnswered { get; set; }
        public int? CorrectAnswersCount { get; set; }
    }
}
