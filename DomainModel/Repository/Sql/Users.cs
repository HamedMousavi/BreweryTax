using System;
using System.Data;
using System.Data.SqlClient;
using Entities;
using Entities.Abstract;
using Entities.Abstract.Repository;


namespace DomainModel.Repository.Sql
{

    public class Users : IUsers
    {

        public string ConnectionString { get; set; }
        private CultureCollection cultures;
        protected QueryHelper query;


        public Users(string sqlCnnStr, CultureCollection cultures)
        {
            this.cultures = cultures;
            ConnectionString = sqlCnnStr;

            this.query = new QueryHelper(sqlCnnStr);
        }


        public Entities.UserCollection GetAll()
        {
            Entities.UserCollection users = new Entities.UserCollection();
            
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Users";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            ICrypt crypto = new SimpleCrypt();

                            while (reader.Read())
                            {
                                Entities.User user = new Entities.User();

                                user.Id = Utils.GetSafeInt32(reader, "UserId");
                                user.Name = crypto.Decrypt(Utils.GetSafeString(reader, "UserName"));
                                user.Password = crypto.Decrypt(Utils.GetSafeString(reader, "UserPass"));
                                user.Culture = cultures[Utils.GetSafeString(reader, "UserLocale")];
                                user.IsEnabled = Utils.GetSafeBoolean(reader, "IsEnabled");
                                user.Role = Membership.Roles.GetById(Utils.GetSafeInt32(reader, "RoleId"));
                                user.IsEmployee = Utils.GetSafeBoolean(reader, "IsEmployee");
                                Membership.UserSettings.LoadById(user);

                                users.Add(user);       
                            }
                        }
                    }
                }
            }
            
            return users;
        }


        public bool Insert(User user)
        {
            bool res = false;

            try
            {
            
                ICrypt crypto = new SimpleCrypt();

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@UserName", crypto.Encrypt(user.Name)));
                this.query.Parameters.Add(new SqlParameter("@UserPass", crypto.Encrypt(user.Password)));
                this.query.Parameters.Add(new SqlParameter("@UserLocale", user.Culture.CultureName));
                this.query.Parameters.Add(new SqlParameter("@IsEnabled", user.IsEnabled));
                this.query.Parameters.Add(new SqlParameter("@RoleId", user.Role.Id));
                this.query.Parameters.Add(new SqlParameter("@IsEmployee", user.IsEmployee));

                int id;
                res = this.query.ExecuteInsertProc("UsersAdd", out id);
                user.Id = id;
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


        public bool Update(User user)
        {
            bool res = false;

            try
            {
                ICrypt crypto = new SimpleCrypt();

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@UserName", crypto.Encrypt(user.Name)));
                this.query.Parameters.Add(new SqlParameter("@UserPass", crypto.Encrypt(user.Password)));
                this.query.Parameters.Add(new SqlParameter("@UserLocale", user.Culture.CultureName));
                this.query.Parameters.Add(new SqlParameter("@IsEnabled", user.IsEnabled));
                this.query.Parameters.Add(new SqlParameter("@RoleId", user.Role.Id));
                this.query.Parameters.Add(new SqlParameter("@IsEmployee", user.IsEmployee));
                this.query.Parameters.Add(new SqlParameter("@UserId", user.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("UsersUpdateById", out affected);
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


        public bool Delete(User user)
        {
            bool res = false;
            
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                string query =
                    "DELETE FROM Users" +
                    " WHERE UserId = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@UserId", user.Id));

                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();

                    res = (affected > 0);
                }
            }

            return res;
        }
    }
}
