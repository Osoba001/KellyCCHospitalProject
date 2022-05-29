using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class StaffID:BaseEntity,IBaseModel
    {
        public StaffID()
        {

        }
        public StaffID(string idnumber, DateTime exp, Hospital hospital )
        {
            IdNumber=idnumber;
            ExpiringDate=exp;
            Hospital=hospital;
            IsUse = false;
        }
        public virtual string IdNumber { get; set; }
        public virtual bool IsUse { get; set; }
        public virtual DateTime ExpiringDate { get; set; }
        public virtual DateTime IssueDate { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
