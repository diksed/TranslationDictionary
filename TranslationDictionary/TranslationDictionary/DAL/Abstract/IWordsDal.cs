using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationDictionary.DAL.Entities;

namespace TranslationDictionary.DAL.Abstract
{
    public interface IWordsDal : IEntityRepository<WordList>
    {
    }
}
