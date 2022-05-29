using HospitalRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Treatment:BaseEntity ,IBaseModel
    {
        public Treatment()
        {

        }
        public Treatment(Patient patient, string name, decimal amount, Doctor doctor)
        {
            Name = name;
            Patient= patient;
            Amount = amount;
            Doctor =doctor;
            Date = DateTime.Now;
        }
        public virtual string Name { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
