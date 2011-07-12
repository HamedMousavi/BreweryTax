using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class QueryHelper : IDisposable
    {

        public readonly Int32 ErrorResult = -2;


        public CommandType CommandType { get; set; }
        public List<SqlParameter> Parameters { get; private set; }
        public delegate void MapToObjectFunc(SqlDataReader reader, object userData);


        private string sqlConnectionString;


        public QueryHelper(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
            
            this.Parameters = new List<SqlParameter>();
            this.CommandType = System.Data.CommandType.StoredProcedure;
        }


        public bool ExecuteInsertProc(string procName, out Int32 procResult)
        {
            bool res = false;
            procResult = ErrorResult;

            try
            {
                using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter param in this.Parameters)
                        {
                            if (param.Value == null) param.Value = DBNull.Value;
                            cmd.Parameters.Add(param);
                        }

                        cnn.Open();

                        object id = cmd.ExecuteScalar();
                        if (id != null)
                        {
                            procResult = Convert.ToInt32(id);
                        }
                    }
                }

                res = true;
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


        public bool ExecuteUpdateProc(string procName, out Int32 affected)
        {
            bool res = false;
            affected = 0;

            try
            {
                using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter param in this.Parameters)
                        {
                            if (param.Value == null) param.Value = DBNull.Value;
                            cmd.Parameters.Add(param);
                        }

                        cnn.Open();

                        affected = cmd.ExecuteNonQuery();
                        res = true;
                    }
                }
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


        public bool ExecuteReader(string procName, MapToObjectFunc func, object userData)
        {
            bool res = false;

            try
            {
                using (SqlConnection cnn = new SqlConnection(sqlConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter param in this.Parameters)
                        {
                            if (param.Value == null) param.Value = DBNull.Value;
                            cmd.Parameters.Add(param);
                        }

                        cnn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null && reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    func(reader, userData);
                                }
                            }
                        }
                    }
                }

                res = true;
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


        public void Dispose()
        {
            this.Parameters.Clear();
            this.Parameters = null;
        }
    }
}
