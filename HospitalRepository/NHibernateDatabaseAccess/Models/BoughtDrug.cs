using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess.Models
{
    public class BoughtDrug:BaseEntity,IBaseModel
    {
        protected BoughtDrug()
        {

        }
        public BoughtDrug(Patient patient, Drug drug)
        {
            Patient=patient;
            Drug=drug;
            Time=DateTime.Now;
        }
        public virtual Patient Patient { get; set; }
        public virtual Drug Drug { get; set; }
        public virtual DateTime Time { get; set; }
    }
}
