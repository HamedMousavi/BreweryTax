using System;
using System.Data;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class TourCostGroups
    {

        private string sqlConnectionString;


        public TourCostGroups(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }


        internal void LoadAll(Entities.TourCostGroupCollection groups)
        {
            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostGroupsGetAll", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Entities.TourCostGroup group = new Entities.TourCostGroup();

                                group.Id = Utils.GetSafeInt32(reader, "GroupId");
                                group.Name = Utils.GetSafeString(reader, "GroupName");

                                groups.Add(group);
                            }
                        }
                    }
                }
            }
        }


        internal bool Update(Entities.TourCostGroup group)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostGroupUpdateById", cnn))
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


        internal bool Insert(Entities.TourCostGroup group)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostGroupAdd", cnn))
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


        internal bool Delete(Entities.TourCostGroup group)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostGroupDeleteById", cnn))
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
                using (SqlCommand cmd = new SqlCommand("TourCostGroupRuleAdd", cnn))
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
                using (SqlCommand cmd = new SqlCommand("TourCostGroupRuleRemove", cnn))
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
