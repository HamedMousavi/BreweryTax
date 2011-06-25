using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class TourCostRules
    {

        private string sqlConnectionString;

        public TourCostRules(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }


        internal bool Insert(Entities.TourCostRule rule)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostRuleAdd", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@RuleId", rule.Id));
                    cmd.Parameters.Add(new SqlParameter("@RuleName", rule.Name));
                    cmd.Parameters.Add(new SqlParameter("@RuleValue", rule.Formula.Value));
                    cmd.Parameters.Add(new SqlParameter("@PriceOperationId", (Int32)rule.Formula.PriceOperation));
                    cmd.Parameters.Add(new SqlParameter("@ValueOperationId", (Int32)rule.Formula.ValueOperation));
                    cmd.Parameters.Add(new SqlParameter("@CurrencyId", rule.Formula.Currency == null ? -1 : rule.Formula.Currency.Id));
                    cnn.Open();

                    object id = cmd.ExecuteScalar();
                    if (id != null)
                    {
                        rule.Id = Convert.ToInt32(id);
                        res = true;
                    }
                }
            }

            return res;
        }


        internal bool Update(Entities.TourCostRule rule)
        {
            bool res = false;
            
            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostRuleUpdateById", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@RuleId", rule.Id));
                    cmd.Parameters.Add(new SqlParameter("@RuleName", rule.Name));
                    cmd.Parameters.Add(new SqlParameter("@RuleValue", rule.Formula.Value));
                    cmd.Parameters.Add(new SqlParameter("@PriceOperationId", (Int32)rule.Formula.PriceOperation));
                    cmd.Parameters.Add(new SqlParameter("@ValueOperationId", (Int32)rule.Formula.ValueOperation));
                    cmd.Parameters.Add(new SqlParameter("@CurrencyId", rule.Formula.Currency == null? -1 : rule.Formula.Currency.Id));
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }


        internal void LoadAll(Entities.TourCostRuleCollection rules)
        {
            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostRulesGetAll", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Entities.TourCostRule rule = new Entities.TourCostRule();

                                rule.Id = Utils.GetSafeInt32(reader, "RuleId");
                                rule.Name = Utils.GetSafeString(reader, "RuleName");
                                rule.Formula.Currency = DomainModel.Currencies.GetById(Utils.GetSafeInt32(reader, "CurrencyId"));
                                rule.Formula.PriceOperation = (Entities.TourCostFormula.PriceOperations)Utils.GetSafeInt32(reader, "PriceOperationId");
                                rule.Formula.Value = Utils.GetSafeDecimal(reader, "RuleValue");
                                rule.Formula.ValueOperation = (Entities.TourCostFormula.ValueOperations)Utils.GetSafeInt32(reader, "ValueOperationId");

                                rules.Add(rule);
                            }
                        }
                    }
                }
            }
        }


        internal bool Delete(Entities.TourCostRule rule)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostRuleDeleteById", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@RuleId", rule.Id));
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }


        internal void LoadByGroupId(int groupId, List<int> ruleIds)
        {
            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourCostRulesGetByGroupId", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@GroupId", groupId));

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ruleIds.Add(Utils.GetSafeInt32(reader, "RuleId"));
                            }
                        }
                    }
                }
            }
        }
    }
}
