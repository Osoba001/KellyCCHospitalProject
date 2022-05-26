using HospitalRepository.NHibernateDatabaseAccess;
using HospitalRepository.NHibernateDatabaseAccess.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.BaseRepository
{
    public class Repository<T>:IRepostory<T> where T : IBaseModel
    {
        protected ISession _session;
        public Repository(ISession session)
        {
            _session = session;
        }
        public virtual void AddEntity(T entity)
        {
            _session.Save(entity);
        }


        public IEnumerable<T> FindByPredicate(Expression<Func<T, bool>> predicate)
        {
            return _session.Query<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _session.Query<T>();
        }

        public T GetById(Guid id)
        {
            var temp = _session.Query<T>().FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new NullReferenceException("Item does not exist in the database");
            }
        }
        public bool IsExist(Guid id)
        {
            return _session.Query<T>().Where(x => x.Id == id) != null;
        }

        public virtual void RomoveEntity(Guid id)
        {
            var p = _session.Query<T>().FirstOrDefault(x => x.Id == id);
            if (p != null)
            {
                _session.Delete(p);
            }
            else
            {
                throw new NullReferenceException("Item does not exist in the database");
            }

        }

        public virtual void UpdateEntity(T entity)
        {
            if (IsExist(entity.Id))
            {
                _session.Update(entity);
            }
            else
            {
                throw new NullReferenceException("Item does not exist in the database");
            }

        }

    }
}
