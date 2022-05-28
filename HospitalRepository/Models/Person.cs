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
        public Person(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
           
        }
        public virtual string Name { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual string PhoneNo { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
    

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
