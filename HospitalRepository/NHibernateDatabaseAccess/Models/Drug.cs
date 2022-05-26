using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Drug:BaseEntity,IBaseModel
    {
        protected Drug()
        {

        }
        public Drug(string name, DateOnly exp, DateOnly manufac, decimal price , Pharmacist pharmacist)
        {
            Name = name;
            ExpiringDate = exp;
            ManufactureDate= manufac;
            UnitPrice = price;
            Pharmacist= pharmacist;
        }
        public virtual string Name { get; set; }
        public virtual DateOnly ExpiringDate { get; set; }
        public virtual DateOnly ManufactureDate { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual string Photo { get; set; }
        public virtual Pharmacist Pharmacist { get; set; }
    }
}
