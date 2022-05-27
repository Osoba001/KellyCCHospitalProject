﻿using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.IModelRepo
{
    public interface IDrugRep:IRepostory<Drug>
    {
        List<Drug> MostBoughtTop10Drugs();
    }
}
