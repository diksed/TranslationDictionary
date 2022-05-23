using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationDictionary.DAL.Entities;

namespace TranslationDictionary.DAL.Abstract
{
    public interface IEntityRepository<T>
        where T : class, new()
    {
        void Add(T entity);
        void Update(T entity);
        List<T> GetAll();
        void Delete(T entity);
        T Get(string firstWord);
    }
}
