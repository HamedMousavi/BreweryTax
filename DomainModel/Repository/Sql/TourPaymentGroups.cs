using System;
using System.Data;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class TourPaymentGroups
    {

        private string sqlConnectionString;


        public TourPaymentGroups(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }


        internal void LoadAll(Entities.TourPaymentGroupCollection groups)
        {
            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourPaymentGroupsGetAll", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Entities.TourPaymentGroup group = new Entities.TourPaymentGroup();

                                group.Id = Utils.GetSafeInt32(reader, "GroupId");
                                group.Name = Utils.GetSafeString(reader, "GroupName");

                                groups.Add(group);
                            }
                        }
                    }
                }
            }
        }


        internal bool Update(Entities.TourPaymentGroup group)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourPaymentGroupUpdateById", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@GroupId", group.Id));
                    cmd.Parameters.Add(new SqlParameter("@GroupName", group.Name));
                    
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }


        internal bool Insert(Entities.TourPaymentGroup group)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourPaymentGroupAdd", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@GroupName", group.Name));
                    cnn.Open();

                    object id = cmd.ExecuteScalar();
                    if (id != null)
                    {
                        group.Id = Convert.ToInt32(id);
                        res = true;
                    }
                }
            }

            return res;
        }


        internal bool Delete(Entities.TourPaymentGroup group)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourPaymentGroupDeleteById", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@GroupId", group.Id));
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }


        internal bool AddRuleToGroup(int groupId, int ruleId)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourPaymentGroupRuleAdd", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@GroupId", groupId));
                    cmd.Parameters.Add(new SqlParameter("@RuleId", ruleId));
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }


        internal bool RemoveRuleFromGroup(int groupId, int ruleId)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourPaymentGroupRuleRemove", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@GroupId", groupId));
                    cmd.Parameters.Add(new SqlParameter("@RuleId", ruleId));
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }
    }
}
