using System;
using System.Data;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class Categories
    {

        private string sqlConnectionString;


        public Categories(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }


        internal void LoadAll(Entities.CategoryClassCollection classes)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
                {
                    string query = "SELECT * FROM AppTypeClasses";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.Text;

                        cnn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null && reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Entities.CategoryClass cat = new Entities.CategoryClass();

                                    cat.Id = Utils.GetSafeInt32(reader, "TypeClassId");
                                    cat.Name = Utils.GetSafeString(reader, "TypeClassName");

                                    classes.Add(cat);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //EventLogger.Instance.Add(ex.Message);
            }
        }
    }
}
