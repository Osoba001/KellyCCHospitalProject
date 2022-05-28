using HospitalRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Treatment: HospitalService
    {
        public Treatment()
        {

        }
        public Treatment(string name, Patient patient, decimal amount, Doctor doctor):base(patient)
        {
            Name = name;
            Amount = amount;
            Doctor =doctor;
        }
        public virtual string Name { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
