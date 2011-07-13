using System;
using System.Data.SqlClient;
using Entities.Abstract;


namespace DomainModel.Repository.Sql
{

    public class TourGroupServicePayments
    {

        protected QueryHelper query;


        public TourGroupServicePayments(string sqlConnectionString)
        {
            this.query = new QueryHelper(sqlConnectionString);
        }


        internal bool Insert(Entities.TourServiceBase service, Entities.TourPayment payment)
        {
            bool res = false;
           
            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@ServiceId", service.Id));
                this.query.Parameters.Add(new SqlParameter("@PaymentTypeId", payment.Type.Id));
                this.query.Parameters.Add(new SqlParameter("@AmountValue", payment.Amount.Value));
                this.query.Parameters.Add(new SqlParameter("@AmountUnitId", payment.Amount.Currency.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourGroupServicePaymentAdd", out id);
                payment.Id = id;
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


        internal bool Update(Entities.TourServiceBase service, Entities.TourPayment payment)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@ServiceId", service.Id));
                this.query.Parameters.Add(new SqlParameter("@PaymentTypeId", payment.Type.Id));
                this.query.Parameters.Add(new SqlParameter("@AmountValue", payment.Amount.Value));
                this.query.Parameters.Add(new SqlParameter("@AmountUnitId", payment.Amount.Currency.Id));
                this.query.Parameters.Add(new SqlParameter("@PaymentId", payment.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupServicePaymentUpdateById", out affected);
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
        

        internal bool Delete(Entities.TourPayment payment)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@PaymentId", payment.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupServicePaymentDeleteById", out affected);
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


        internal bool Load(Entities.Abstract.ITourService service)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@ServiceId", service.Id));

                res = this.query.ExecuteReader("TourGroupServicePaymentGetByServiceId", MapPaymentToObject, service);
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


        protected void MapPaymentToObject(SqlDataReader reader, object userData)
        {
            Entities.TourPayment payment = new Entities.TourPayment();

            payment.Id = Utils.GetSafeInt32(reader, "PaymentId");
            payment.Type = DomainModel.PaymentTypes.GetById(Utils.GetSafeInt32(reader, "PaymentTypeId"));
            payment.Amount.Value = Utils.GetSafeDecimal(reader, "AmountValue");
            payment.Amount.Currency = DomainModel.Currencies.GetById(Utils.GetSafeInt32(reader, "AmountUnitId"));
            
            payment.IsDirty = false;

            ITourService service = (ITourService)userData;
            service.Payments.Add(payment);
        }
    }
}
