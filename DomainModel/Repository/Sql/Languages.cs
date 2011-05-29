using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DomainModel.Repository.Sql
{
    public class Languages
    {
        private string sqlConnectionString;


        public Languages(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }


        internal void Load(Entities.CultureCollection cultures)
        {
            Entities.GeneralTypeCollection types = new Entities.GeneralTypeCollection();

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                string query = "LanguagesGetAll";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Entities.Culture culture = new Entities.Culture();

                                culture.Id = Utils.GetSafeInt32(reader, "LanguageId");
                                culture.LanguageName = Utils.GetSafeString(reader, "LanguageName");
                                culture.CultureName = Utils.GetSafeString(reader, "CultureName");

                                cultures.Add(culture);
                            }
                        }
                    }
                }
            }

            //return types;
        }
    }
}
