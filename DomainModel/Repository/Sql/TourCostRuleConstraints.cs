using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class TourCostRuleConstraints
    {

        protected QueryHelper query;
        

        public TourCostRuleConstraints(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        public bool LoadByRule(Entities.TourCostRule rule)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@RuleId", rule.Id));

                res = this.query.ExecuteReader("TourCostRuleConstraintGetByRuleId", 
                    MapConstraintToObject, rule);
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }


        protected void MapConstraintToObject(SqlDataReader reader, object userData)
        {

            Entities.TourCostRuleConstraint con = new Entities.TourCostRuleConstraint();

            con.Id = Utils.GetSafeInt32(reader, "ConstraintId");
            con.Name = Utils.GetSafeString(reader, "ConstraintName");
            con.ConstraintType = DomainModel.TourCostConstraintTypes.GetById(
                Utils.GetSafeInt32(reader, "ConstraintTypeId"));


            Entities.TourCostRule rule =
                (Entities.TourCostRule)userData;

            rule.Constraints.Add(con);
        }


        internal bool Insert(Entities.TourCostRule rule, Entities.TourCostRuleConstraint constraint)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@RuleId", rule.Id));
                this.query.Parameters.Add(new SqlParameter("@ConstraintName", constraint.Name));
                this.query.Parameters.Add(new SqlParameter("@ConstraintTypeId", constraint.ConstraintType.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourCostRuleConstraintAdd", out id);
                constraint.Id = id;
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }


        internal bool Update(Entities.TourCostRule rule, Entities.TourCostRuleConstraint constraint)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@RuleId", rule.Id));
                this.query.Parameters.Add(new SqlParameter("@ConstraintName", constraint.Name));
                this.query.Parameters.Add(new SqlParameter("@ConstraintTypeId", constraint.ConstraintType.Id));
                this.query.Parameters.Add(new SqlParameter("@ConstraintId", constraint.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourCostRuleConstraintUpdateById", out affected);
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }
    }
}
