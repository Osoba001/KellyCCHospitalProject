using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.Models
{
    public class Bills: BaseEntity, IBaseModel
    {
        public Bills()
        {

        }
        public Bills(Patient patient)
        {
            BoughtDrugs = new List<BoughtDrug>();
            Treatments=new List<Treatment>();
            Patient=patient;
        }
        public virtual Patient Patient { get; set; }
        public virtual decimal AmountBilled => BoughtDrugs.Sum(x => x.Amount)+Treatments.Sum(x => x.Amount);
        public virtual List<BoughtDrug> BoughtDrugs { get; set; }
        public virtual List<Treatment> Treatments { get; set; }

    }
}
