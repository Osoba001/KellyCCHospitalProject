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
        public Drug(string name, DateOnly exp, DateOnly manufac, decimal unitprice, int quantity , Pharmacist pharmacist)
        {
            Name = name;
            ExpiringDate = exp;
            ManufactureDate= manufac;
            UnitPrice = unitprice;
            Pharmacist= pharmacist;
            Quantity = quantity;
        }
        public virtual string Name { get; set; }
        public virtual DateOnly ExpiringDate { get; set; }
        public virtual DateOnly ManufactureDate { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual string Photo { get; set; }
        public virtual Pharmacist Pharmacist { get; set; }
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

    }
}
