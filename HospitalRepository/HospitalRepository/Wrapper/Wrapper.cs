using HospitalRepository.HospitalRepository.IModelRepo;
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
        private IReceptionistRepo _Receptionist;
        public IReceptionistRepo Receptionist
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
        private IDoctorRepo doctor  ;

        public IDoctorRepo Doctor
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
        private IPharmacistRepo pharmacist;

        public IPharmacistRepo Pharmacist
        {
            get
            {
                if (pharmacist==null)
                {
                    pharmacist=new PharmacistRepo(_session);
                }
                return pharmacist;
            }
        }
        private INurseRepo nurseRepo;

        public INurseRepo NurseRepo
        {
            get
            {
                if (nurseRepo==null)
                {
                    nurseRepo = new NurseRepo(_session);
                }
                return nurseRepo;
            }
        }

        private IDoctorRepo doctorReo;

        public IDoctorRepo DoctorReo
        {
            get
            {
                if (doctorReo==null)
                {
                    doctorReo = new DoctorRepo(_session);
                }
                return doctorReo; 
            }
        }
        private IAcountantRepo acountant;

        public IAcountantRepo Acountant
        {
            get
            {
                if (acountant==null)
                {
                    acountant = new AccountantRepo(_session);
                }
                return acountant; 
            }
        }

        private IAdminRepo admin;

        public IAdminRepo Admin
        {
            get
            {
                if (admin==null)
                {
                    admin = new AdminRepo(_session);
                }
                return admin;
            }
        }

        private IApointmentRepo apointment;

        public IApointmentRepo Apointment
        {
            get
            {
                if (apointment==null)
                {
                    apointment = new ApointmentRep(_session);
                }
                return apointment; 
            }
        }

        private IBoughtDrugRepo boughtDrug;

        public IBoughtDrugRepo BoughtDrug
        {
            get
            {
                if (boughtDrug==null)
                {
                    boughtDrug = new BoughtDrugsRepo(_session);
                }
                return boughtDrug; 
            }
        }

        private IPaymentRepo payment;

        public IPaymentRepo Payment
        {
            get
            {
                if (payment==null)
                {
                    payment = new PaymentRepo(_session);
                }
                return payment; 
            }
        }


        private IStaffIDRepo staffIDRepo;

        public IStaffIDRepo StaffIDRepo
        {
            get
            {
                if (staffIDRepo==null)
                {
                    staffIDRepo = new StaffIDRepo(_session);
                }
                return staffIDRepo;
            }
        }
        private ITreatmentRepo treatmentReo;

        public ITreatmentRepo TreatmentReo
        {
            get
            {
                if (treatmentReo == null)
                {
                    treatmentReo = new TreatmentRepo(_session);
                }
                return treatmentReo;
            }
        }

        private IBillRepo billRepo;

        public IBillRepo BillRepo
        {
            get
            {
                if (billRepo==null)
                {
                    billRepo = new BillRepo(_session);
                }
                return billRepo; 
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
