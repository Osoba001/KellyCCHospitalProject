using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class ApointmentRep:Repository<Apointment>,IApointmentRepo
    {
        public ApointmentRep(ISession session) : base(session)
        {

        }
    }
}
