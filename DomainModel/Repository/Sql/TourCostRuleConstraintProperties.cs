using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class TourCostRuleConstraintProperties
    {

        protected QueryHelper query;


        public TourCostRuleConstraintProperties(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        public bool LoadByConstraint(Entities.TourCostRuleConstraint Constraint)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@ConstraintId", Constraint.Id));

                res = this.query.ExecuteReader("TourCostRuleConstraintPropertyGetByConstraintId", MapCostToObject, Constraint);
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


        protected void MapCostToObject(SqlDataReader reader, object userData)
        {
            Entities.TourCostRuleConstraintProperty prop = new 
                Entities.TourCostRuleConstraintProperty();

            prop.Id = Utils.GetSafeInt32(reader, "PropertyId");
            prop.TypeId = Utils.GetSafeInt32(reader, "PropertyTypeId");
            prop.Value = Utils.GetSafeInt32(reader, "PropertyValue");
            prop.IsDirty = false;

            Entities.TourCostRuleConstraint Constraint = (Entities.TourCostRuleConstraint)userData;
            Constraint.Properties.Add(prop);
        }


        internal bool Save(Entities.TourCostRule rule)
        {
            throw new NotImplementedException();
        }


        internal bool Insert(Entities.TourCostRuleConstraint constraint, Entities.TourCostRuleConstraintProperty property)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@ConstraintId", constraint.Id));
                this.query.Parameters.Add(new SqlParameter("@PropertyTypeId", property.TypeId));
                this.query.Parameters.Add(new SqlParameter("@PropertyValue", property.Value));

                int id;
                res = this.query.ExecuteInsertProc("TourCostRuleConstraintPropertyAdd", out id);
                property.Id = id;
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


        internal bool Update(Entities.TourCostRuleConstraint constraint, Entities.TourCostRuleConstraintProperty property)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@ConstraintId", constraint.Id));
                this.query.Parameters.Add(new SqlParameter("@PropertyTypeId", property.TypeId));
                this.query.Parameters.Add(new SqlParameter("@PropertyValue", property.Value));
                this.query.Parameters.Add(new SqlParameter("@PropertyId", property.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourCostRuleConstraintPropertyUpdateById", out affected);
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
