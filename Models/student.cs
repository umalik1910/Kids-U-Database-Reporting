//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        public int student_Unique_ID { get; set; }
        public string first_Name { get; set; }
        public string last_Name { get; set; }
        public string school_Grade { get; set; }
        public string kids_U_Site { get; set; }
        public string gender { get; set; }
        public string income { get; set; }
        public string ethnicity { get; set; }
        public string enrolled { get; set; }
        public string lunch { get; set; }
        public string school_name { get; set; }
    
        public virtual outcome_measurement outcome_measurement { get; set; }
        public virtual report_card report_card { get; set; }
        public virtual school school { get; set; }
    }
}
