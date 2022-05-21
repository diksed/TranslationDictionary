using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationDictionary.DAL.Abstract;
using TranslationDictionary.DAL.Entities;

namespace TranslationDictionary.DAL.Concrete
{
    public class WordsDal : IWordsDal
    {
        public void Add(WordList entity)
        {
            try
            {
                var cmd = new SqlCommand("INSERT INTO word_list(firstWord, secondWord) VALUES(@firstWord,@secondWord)");
                cmd.Parameters.AddWithValue("firstWord", entity.firstWord);
                cmd.Parameters.AddWithValue("secondWord", entity.secondWord);
                RDMS.SqlNonQuery(cmd);
                Console.WriteLine("Add successful!");
            }
            catch
            {
                throw new Exception("Add failed!");
            }
        }
        public void Delete(WordList entity)
        {
            try
            {
                var cmd = new SqlCommand("DELETE FROM word_list WHERE firstWord = @firstWord");
                cmd.Parameters.AddWithValue("firstWord", entity.firstWord);
                RDMS.SqlNonQuery(cmd);
                Console.WriteLine("Delete successful!");
            }
            catch
            {
                throw new Exception("Deletion failed!");
            }
        }
        public List<WordList> GetAll()
        {
            var _list = new List<WordList>();
            var cmd = new SqlCommand("SELECT firstWord, secondWord FROM word_list");
            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new WordList()
                {
                    firstWord = item[0].ToString(),
                    secondWord = item[1].ToString()
                });
            }
            return _list;
        }
        public void Update(WordList entity)
        {
            try
            {
                var cmd = new SqlCommand("UPDATE word_list SET firstWord = @firstWord, secondWord = @secondWord WHERE firstWord = @firstWord");
                cmd.Parameters.AddWithValue("firstWord", entity.firstWord);
                cmd.Parameters.AddWithValue("secondWord", entity.secondWord);
                RDMS.SqlNonQuery(cmd);
                Console.WriteLine("Update successful!");
            }
            catch
            {
                throw new Exception("Update failed!");
            }
        }
    }
}
