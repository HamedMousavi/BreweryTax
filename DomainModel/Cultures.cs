using System;
using Entities;


namespace DomainModel
{
    public class Cultures
    {
        private static CultureCollection cultures;
        private static Repository.Sql.Languages repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.Languages(sqlConnectionString);
            
            LoadCultures();
        }


        private static void LoadCultures()
        {
            cultures = new CultureCollection();
            repo.Load(cultures);
        }


        public static CultureCollection GetAll()
        {
            return cultures;
        }
    }
}
