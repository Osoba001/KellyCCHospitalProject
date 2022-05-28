using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.ModelRepository
{
    public class ContactRepo:Repository<Contact>,IContactRepo
    {
        public ContactRepo(ISession session) : base(session)
        {

        }
    }
}
