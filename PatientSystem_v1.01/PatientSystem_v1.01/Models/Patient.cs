using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientSystem_v1._01.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public string DOB { get; set; }
        [Display(Name = "Active")]
        public bool isActive { get; set; }
        public string Disease { get; set; }
    }
}