using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class Contact:BaseEntity, IBaseModel
    {
        public Contact()
        {

        }
        public Contact(string phoneNo, string email,string addres, Hospital hospital)
        {
            PhoneNo = phoneNo;
            Email = email;
            Address = addres;
            Hospital = hospital;
        }
        public virtual Hospital Hospital { get; set; }
        public virtual string PhoneNo { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
    }
}
