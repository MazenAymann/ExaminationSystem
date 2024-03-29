﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Data.Enums;

namespace WebApplication1.Models
{
    public partial class SelectStudentExamsResult
    {
        public int Exam_ID { get; set; }
        public string Crs_Name { get; set; }
        public DateOnly? Date { get; set; }
        public TimeOnly? time { get; set; }
        public int? Duration { get; set; }
        public int? Grade { get; set; }
        public ExamStatus examStatus = ExamStatus.NotAvailable;

        public void setExamStatus()
        {
            if (Date.HasValue && time.HasValue && Duration.HasValue)
            {
                DateTime examDateTime = new DateTime(Date.Value.Year, Date.Value.Month, Date.Value.Day, time.Value.Hour, time.Value.Minute, 0);
                DateTime currentDateTime = DateTime.Now;
                TimeSpan remainingTime = examDateTime - currentDateTime;

                if (currentDateTime >= examDateTime && Grade != null)
                {
                    examStatus = ExamStatus.submitted; // Exam already submitted
                }
                else if (currentDateTime >= examDateTime.AddMinutes(Duration.Value) && Grade == null)
                {
                    examStatus = ExamStatus.Missed; // Exam missed
                }
                else if (currentDateTime >= examDateTime && currentDateTime <= examDateTime.AddMinutes(Duration.Value))
                {
                    examStatus = ExamStatus.Available; // Exam available
                }
                else
                {
                    examStatus = ExamStatus.NotAvailable; // Exam details are not complete
                }
            }
            else
            {
                examStatus = ExamStatus.NotAvailable; // Exam details are not complete
            }
        }

    }
}

