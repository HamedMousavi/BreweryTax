using System.Data;
using System.Data.SqlClient;
using Entities;


namespace DomainModel.Repository.Sql
{

    class TourBasePrice
    {

        private string sqlConnectionString;


        public TourBasePrice(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }


        internal void Load(TourBasePriceCollection prices)
        {
            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourBasePriceGetAll", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Entities.TourBasePrice price = new Entities.TourBasePrice();
                                price.Id = Utils.GetSafeInt32(reader, "PriceId");
                                price.TourType = DomainModel.TourTypes.GetById(Utils.GetSafeInt32(reader, "TourTypeId"));
                                price.PricePerPerson.Value = Utils.GetSafeDecimal(reader, "PricePerPerson");
                                price.PricePerPerson.Currency = DomainModel.Currencies.GetById(Utils.GetSafeInt32(reader, "PricePerPersonUnitId"));

                                prices.Add(price);
                            }
                        }
                    }
                }
            }
        }


        internal bool Update(int priceId, Money money)
        {
            using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("TourBasePriceUpdateById", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PriceId", priceId));
                    cmd.Parameters.Add(new SqlParameter("@PricePerPerson", money.Value));
                    cmd.Parameters.Add(new SqlParameter("@PricePerPersonUnitId", money.Currency.Id));
                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    return (affected > 0);
                }
            }
        }
    }
}
