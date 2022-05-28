using HospitalRepository.NHibernateDatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRepository.HospitalRepository.BaseRepository
{
    public interface IRepostory<T> where T : IBaseModel
    {
        bool IsExist(Guid id);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindByPredicate(Expression<Func<T, bool>> predicate);
        void AddEntity(T entity);
        void UpdateEntity(T entity);
        void RomoveEntity(T entity);
    }
}
