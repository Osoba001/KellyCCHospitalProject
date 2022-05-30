using Autofac;
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
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(HospitalRepository)))
                .Where(t => t.Name.EndsWith("Repo"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            return builder.Build();
        }
    }
}
