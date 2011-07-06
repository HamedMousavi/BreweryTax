using System;
using System.Data.SqlClient;
using StatusController.Abstract;


namespace DomainModel.Repository.Sql
{

    public class TourPayments
    {

        protected QueryHelper query;


        public TourPayments(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.Tour tour, Entities.TourPayment pay)
        {
            bool res = false;

            try
            {
                if (pay.Id >= 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_already_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@PaymentTypeId", pay.Type.Id));
                this.query.Parameters.Add(new SqlParameter("@AmountValue", pay.Amount.Value));
                this.query.Parameters.Add(new SqlParameter("@AmountUnitId", pay.Amount.Currency.Id));
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourPaymentAdd", out id);
                pay.Id = id;
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


        internal bool Update(Entities.Tour tour, Entities.TourPayment pay)
        {
            bool res = false;

            try
            {
                if (pay.Id < 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_not_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@PaymentTypeId", pay.Type.Id));
                this.query.Parameters.Add(new SqlParameter("@AmountValue", pay.Amount.Value));
                this.query.Parameters.Add(new SqlParameter("@AmountUnitId", pay.Amount.Currency.Id));
                this.query.Parameters.Add(new SqlParameter("@PaymentId", pay.Id));
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourPaymentUpdateById", out affected);
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


        internal bool GetByTour(Entities.Tour tour)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                res = this.query.ExecuteReader("TourPaymentsGetByTourId", MapPaymentToObject, tour);
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
            payment.Type = DomainModel.PaymentTypes.GetById(
                Utils.GetSafeInt32(reader, "PaymentTypeId"));
            payment.Amount.Value = Utils.GetSafeDecimal(reader, "AmountValue");
            payment.Amount.Currency = DomainModel.Currencies.GetById(
                Utils.GetSafeInt32(reader, "AmountUnitId"));
            payment.IsDirty = false;

            Entities.Tour tour = (Entities.Tour)userData;
            //tour.Payments.Add(payment);
        }


        internal bool Delete(Entities.Tour tour, Entities.TourPayment pay)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@PaymentId", pay.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourPaymentDeleteById", out affected);
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
