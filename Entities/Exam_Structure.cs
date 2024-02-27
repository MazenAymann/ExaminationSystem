﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities;

[Table("Exam_Structure")]
public partial class Exam_Structure
{
    [Key]
    public int Structure_ID { get; set; }

    public int? Course_ID { get; set; }

    public int? Duration { get; set; }

    public int? MCQ_Count { get; set; }

    public int? TF_Count { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public TimeOnly? time { get; set; }

    [ForeignKey("Course_ID")]
    [InverseProperty("Exam_Structures")]
    public virtual Course Course { get; set; }

    [InverseProperty("Structure")]
    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}