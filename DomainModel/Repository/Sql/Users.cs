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


        public Users(string sqlCnnStr, CultureCollection cultures)
        {
            ConnectionString = sqlCnnStr;
            this.cultures = cultures;
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

            ICrypt crypto = new SimpleCrypt();

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                string query =
                    "INSERT INTO Users" +
                    " (UserName, UserPass, UserLocale, IsEnabled, RoleId)" +
                    " VALUES " +
                    " (@UserName, @UserPass, @UserLocale, @IsEnabled, @RoleId);"+
                    " SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@UserName", crypto.Encrypt(user.Name)));
                    cmd.Parameters.Add(new SqlParameter("@UserPass", crypto.Encrypt(user.Password)));
                    cmd.Parameters.Add(new SqlParameter("@UserLocale", user.Culture.CultureName));
                    cmd.Parameters.Add(new SqlParameter("@IsEnabled", user.IsEnabled));
                    cmd.Parameters.Add(new SqlParameter("@RoleId", user.Role.Id));

                    cnn.Open();

                    object uid = cmd.ExecuteScalar();
                    if (uid != null)
                    {
                        user.Id = Convert.ToInt32(uid);
                        res = true;
                    }
                }
            }

            return res;
        }


        public bool Update(User user)
        {
            bool res = false;

            ICrypt crypto = new SimpleCrypt();

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                string query =
                    "UPDATE Users" +
                    " SET UserName = @UserName, UserPass = @UserPass," +
                    " UserLocale = @UserLocale, IsEnabled = @IsEnabled," +
                    " RoleId = @RoleId " +
                    " WHERE UserId = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@UserName", crypto.Encrypt(user.Name)));
                    cmd.Parameters.Add(new SqlParameter("@UserPass", crypto.Encrypt(user.Password)));
                    cmd.Parameters.Add(new SqlParameter("@UserLocale", user.Culture.CultureName));
                    cmd.Parameters.Add(new SqlParameter("@IsEnabled", user.IsEnabled));
                    cmd.Parameters.Add(new SqlParameter("@RoleId", user.Role.Id));
                    cmd.Parameters.Add(new SqlParameter("@UserId", user.Id));

                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();

                    res = (affected > 0);
                }
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
