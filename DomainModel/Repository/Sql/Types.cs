using System;
using System.Data;
using System.Data.SqlClient;
using Entities;


namespace DomainModel.Repository.Sql
{

    public class Types
    {

        private string sqlCnnStr;


        public Types(string sqlCnnStr)
        {
            this.sqlCnnStr = sqlCnnStr;
        }


        public Entities.GeneralTypeCollection GetByName(string typeName, int languageId)
        {
            Entities.GeneralTypeCollection types = new Entities.GeneralTypeCollection();

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                string query ="AppTypesGetByName";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TypeClassName", typeName));
                    cmd.Parameters.Add(new SqlParameter("@LanguageId", languageId));

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Entities.GeneralType type = new Entities.GeneralType();

                                type.Id = Utils.GetSafeInt32(reader, "TypeId");
                                type.Name = Utils.GetSafeString(reader, "TypeName");
                                type.DetailsTable = Utils.GetSafeString(reader, "DetailsTable");
                                type.IsDirty = false;

                                types.Add(type);
                            }
                        }
                    }
                }
            }

            return types;
        }


        internal bool Insert(int classId, int languageId, GeneralType type)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                using (SqlCommand cmd = new SqlCommand("AppTypesAdd", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TypeId", type.Id));
                    cmd.Parameters.Add(new SqlParameter("@LanguageId", languageId));
                    cmd.Parameters.Add(new SqlParameter("@TypeClassId", classId));
                    cmd.Parameters.Add(new SqlParameter("@TypeName", type.Name));
                    cnn.Open();

                    object id = cmd.ExecuteScalar();
                    if (id != null)
                    {
                        type.Id = Convert.ToInt32(id);
                        res = true;
                    }
                }
            }

            return res;
        }


        internal bool Update(int languageId, int typeId, string name)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                using (SqlCommand cmd = new SqlCommand("AppTypesUpdateById", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TypeId", typeId));
                    cmd.Parameters.Add(new SqlParameter("@LanguageId", languageId));
                    cmd.Parameters.Add(new SqlParameter("@TypeName", name));
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }


        internal bool DeleteById(int typeId)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                using (SqlCommand cmd = new SqlCommand("AppTypesDelete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@TypeId", typeId));
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }
    }
}
