using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Drug:BaseEntity,IBaseModel
    {
        public Drug()
        {

        }
        public Drug(string name, string purpose, string cauction, decimal unitprice, int quantity , Pharmacist pharmacist, Hospital hospital)
        {
            Name = name;
            Purpose=purpose;
            Caution= cauction;
            UnitPrice = unitprice;
            Pharmacist= pharmacist;
            Hospital = hospital;
            Quantity = quantity;
            BoughtDrugs = new List<BoughtDrug>();
        }
        public virtual string Name { get; set; }
        public virtual string Purpose { get; set; }
        public virtual string Caution { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual string Photo { get; set; }
        public virtual Pharmacist Pharmacist { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual List<BoughtDrug> BoughtDrugs { get; set; }
        private int _quantity;

        public virtual int Quantity
        {
            get { return _quantity; }
            set { _quantity = _quantity+ value; }
        }

    }
}
