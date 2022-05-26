﻿using HospitalRepository.HospitalRepository.IModelRepo;
using HospitalRepository.HospitalRepository.ModelRepository;
using HospitalRepository.NHibernateDatabaseAccess;
using HospitalRepository.NHibernateDatabaseAccess.Mapping;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.Wrapper
{
    public class Wrapper : IWrapper
    {
        protected ISession _session;
        public Wrapper( )
        {
            _session= NHibernateHelper.OpenSession();
        }
        private IPatientRepo _patientRepo;

        public IPatientRepo PatientRepo
        {
            get {
                if (_patientRepo==null)
                {
                    _patientRepo = new PatientRepo(_session);
                }
                return _patientRepo; 
            }

        }
        private IReceptionist _Receptionist;
        public IReceptionist Receptionist
        {
            get
            {
                if (_Receptionist == null)
                {
                    _Receptionist = new ReceptionistRepo(_session);
                }
                return _Receptionist;
            }

        }
        private IDrugRep _DrugRep;

        public IDrugRep DrugRep
        {
            get
            {
                if (_DrugRep==null)
                {
                    _DrugRep = new DrugRepo(_session);
                }
                return _DrugRep;
            }
        }
        private IHospitalRepo _HospitalRepo;

        public IHospitalRepo HospitalRepo
        {
            get
            {
                if (_HospitalRepo==null)
                {
                    _HospitalRepo = new HospitalRepo(_session);
                }
                return _HospitalRepo;
            }
          
        }
        private IDoctor doctor  ;

        public IDoctor Doctor
        {
            get
            {
                if (doctor==null)
                {
                    doctor = new DoctorRepo(_session);
                }
                return doctor;
            }
           
        }


        public void Commit()
        {
            using (var _transaction = _session.BeginTransaction())
            {
                _transaction.Commit();
            }
        }
    }
}
