using PatientSystem_v1._01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientSystem_v1._01.Models
{
    public class PatientBussiness
    {
        private PatientContext db = new PatientContext();
        public List<Patient> View()
        {
            return db.Patients.ToList();
        }
        public Patient Find(int? Id)
        {
            return db.Patients.Find(Id);
        }
        public void Add(Patient patient)
        {
            db.Patients.Add(patient);
            db.SaveChanges();
        }
        public void Delete(Patient patient)
        {
            db.Patients.Remove(patient);
            db.SaveChanges();
        }
        public void Edit(Patient patient)
        {
            var Patient = db.Patients.Where(p => p.PatientId == patient.PatientId).FirstOrDefault();
            db.Patients.Remove(Patient);
            db.Patients.Add(patient);
            db.SaveChanges();
        }
    }
}