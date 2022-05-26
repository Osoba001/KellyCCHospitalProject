using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class StaffID:BaseEntity,IBaseModel
    {
        protected StaffID()
        {

        }
        public StaffID(string idnumber, DateOnly exp, Hospital hospital )
        {
            IdNumber=idnumber;
            ExpiringDate=exp;
            Hospital=hospital;
            IsUse = false;
        }
        public virtual string IdNumber { get; set; }
        public virtual bool IsUse { get; set; }
        public virtual DateOnly ExpiringDate { get; set; }
        public virtual DateOnly IssueDate { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
