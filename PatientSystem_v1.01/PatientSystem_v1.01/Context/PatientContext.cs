using PatientSystem_v1._01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PatientSystem_v1._01.Context
{
    public class PatientContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}