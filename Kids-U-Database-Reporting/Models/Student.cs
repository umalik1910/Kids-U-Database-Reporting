﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kids_U_Database_Reporting.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public char SchoolGrade { get; set; }
        public string Facility { get; set; }
        public string Gender { get; set; }
        public string Income { get; set; }
        public string Ethnicity { get; set; }
        public int? EnrolledYear { get; set; }
        public int? UnEnrolledYear { get; set; }
        public string EnrolledSemester { get; set; }
        public string UnEnrolledSemester { get; set; }
        public DateTime? Birthday { get; set; }
        public bool Lunch { get; set; }
        public string SchoolName { get; set; }
        [Required]
        public bool Active { get; set; }

        //one to many relationship of students to report cards
        public ICollection<ReportCard> ReportCards { get; set; }
    }
}