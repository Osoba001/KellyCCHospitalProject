using Autofac;
using HospitalRepository.HospitalRepository.IModelRepo;
using HospitalRepository.HospitalRepository.ModelRepository;
using HospitalRepository.HospitalRepository.Wrapper;
using HospitalRepository.IFunctionalities;
using HospitalRepository.Models;
using HospitalRepository.NHibernateDatabaseAccess;
using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KellyCCBackEndEvaluation2
{
    public class ContainerConfig
    {
        public  IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Doctor>().As<IDoctor>();
            builder.RegisterType<Acountant>().As<IAcountant>();
            builder.RegisterType<Admin>().As<IAdmin>();
            builder.RegisterType<Patient>().As<IPatient>();
            builder.RegisterType<Pharmacist>().As<IPharmacist>();
            builder.RegisterType<Receptionist>().As<IReceptionist>();
            builder.RegisterType<Wrapper>().As<IWrapper>();
            builder.RegisterType<NHibernateHelper>().As<INHibernateHelper>();
            builder.RegisterType<AccountantRepo>().As<IAcountantRepo>();
            builder.RegisterType<AdminRepo>().As<IAdminRepo>();
            builder.RegisterType<ApointmentRep>().As<IApointmentRepo>();
            builder.RegisterType<BillRepo>().As<IBillRepo>();
            builder.RegisterType<BoughtDrugRepo>().As<IBoughtDrugRepo>();
            builder.RegisterType<DoctorRepo>().As<IDoctorRepo>();
            builder.RegisterType<DrugRepo>().As<IDrugRep>();
            builder.RegisterType<HospitalRepo>().As<IHospitalRepo>();
            builder.RegisterType<NurseRepo>().As<INurseRepo>();
            builder.RegisterType<PatientRepo>().As<IPatientRepo>();
            builder.RegisterType<PaymentRepo>().As<IPaymentRepo>();
            builder.RegisterType<PharmacistRepo>().As<IPharmacistRepo>();
            builder.RegisterType<ReceptionistRepo>().As<IReceptionistRepo>();
            builder.RegisterType<StaffIDRepo>().As<IStaffIDRepo>();
            builder.RegisterType<TreatmentRepo>().As<ITreatmentRepo>();
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(HospitalRepository)))
            //    .Where(t => t.Name.EndsWith("Repo"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            return builder.Build();
        }
    }
}
