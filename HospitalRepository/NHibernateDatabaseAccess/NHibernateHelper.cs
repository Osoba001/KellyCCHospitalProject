using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using HospitalRepository.NHibernateDatabaseAccess.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.NHibernateDatabaseAccess
{
    public class NHibernateHelper : INHibernateHelper
    {
        private ISessionFactory _sessionFactory;

        public ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFatory();
                }
                return _sessionFactory;
            }
        }
        public void InitializeSessionFatory()
        {
            //Data Source=.;Initial Catalog=Sample1;Integrated Security=True
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2000
                .ConnectionString(@"Data Source=.;Initial Catalog=HospitalDB;Integrated Security=True")
                )
                .Mappings(m => m.FluentMappings
                .AddFromAssemblyOf<HospitalMap>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(true, true))
                .BuildSessionFactory();
        }
        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
