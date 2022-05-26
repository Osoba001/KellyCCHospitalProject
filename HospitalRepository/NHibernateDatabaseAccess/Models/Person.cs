using HospitalRepository.HospitalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Person:BaseEntity
    {
        protected Person()
        {

        }
        public Person(string name, Gender gender, Contact contact)
        {
            Name = name;
            Gender = gender;
            Contact = contact;
        }
        public virtual string Name { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Contact Contact { get; set; }

        private DateTime _dob;

        public virtual DateTime DOB
        {
            get { return _dob; }
            set
            {
                if (value<DateTime.Now)
                {
                    _dob = value;
                }
                
            }
        }

    }
}
