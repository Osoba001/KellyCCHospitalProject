using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.Models
{
    public class HospitalService:BaseEntity, IBaseModel
    {
        protected HospitalService()
        {

        }
        public HospitalService(Patient patient)
        {
            Patient=patient;
            Date = DateTime.Now;
        }
        public virtual Patient Patient { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual decimal Amount { get; set; }
    }
}
