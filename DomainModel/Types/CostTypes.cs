﻿using Entities;


namespace DomainModel
{

    public static class PaymentTypes
    {

        private static Repository.Sql.Types repo;
        private static GeneralTypeCollection cache;


        public static void Init(string sqlConnectionString, Entities.Culture culture)
        {
            repo = new Repository.Sql.Types(sqlConnectionString);

            LoadAll(culture);
        }


        private static void LoadAll(Culture culture)
        {
            cache = repo.GetByName("PaymentType", culture.Id);
        }


        public static GeneralTypeCollection GetAll()
        {
            return cache;
        }


        internal static GeneralType GetById(int tourTypeId)
        {
            return cache.GetById(tourTypeId);
        }
    }
}
