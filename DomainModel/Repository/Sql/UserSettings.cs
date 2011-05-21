using System;
using System.Data;
using System.Data.SqlClient;
using Entities.Abstract.Repository;


namespace DomainModel.Repository.Sql
{

    public class UserSettings : IUserSettings
    {
        public string ConnectionString { get; set; }


        public UserSettings(string sqlCnnStr)
        {
            this.ConnectionString = sqlCnnStr;
        }

        
        public bool LoadByUserId(Entities.User user)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM UserSettings WHERE UserId = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@UserId", user.Id));

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                user.Settings.Id = Utils.GetSafeInt32(reader, "SettingId");

                                user.Settings.LastWindowState = Utils.GetSafeInt32(
                                    reader, "LastWindowState");

                                user.Settings.WindowBounds = new System.Drawing.Rectangle(
                                    Utils.GetSafeInt32(reader, "WindowBoundsX"),
                                    Utils.GetSafeInt32(reader, "WindowBoundsY"),
                                    Utils.GetSafeInt32(reader, "WindowBoundsWidth"),
                                    Utils.GetSafeInt32(reader, "WindowBoundsHeight")
                                    );

                                res = true;
                            }
                        }
                    }
                }
            }

            return res;
        }


        public bool Save(Entities.User user)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                string query = 
                    "UPDATE UserSettings SET" +
                    " LastWindowState = @LastWindowState," +
                    " WindowBoundsX = @WindowBoundsX," +
                    " WindowBoundsY = @WindowBoundsY," +
                    " WindowBoundsWidth = @WindowBoundsWidth," +
                    " WindowBoundsHeight = @WindowBoundsHeight," +
                    " WHERE UserId = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@UserId", user.Id));
                    cmd.Parameters.Add(new SqlParameter("@LastWindowState", user.Settings.LastWindowState));
                    cmd.Parameters.Add(new SqlParameter("@WindowBoundsX", user.Settings.WindowBounds.X));
                    cmd.Parameters.Add(new SqlParameter("@WindowBoundsY", user.Settings.WindowBounds.Y));
                    cmd.Parameters.Add(new SqlParameter("@WindowBoundsWidth", user.Settings.WindowBounds.Width));
                    cmd.Parameters.Add(new SqlParameter("@WindowBoundsHeight", user.Settings.WindowBounds.Height));

                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();

                    res = (affected > 0);
                }
            }

            return res;
        }


        public bool Insert(Entities.User user)
        {
            bool res = false;

            if (user.Id >= 0)
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    string query =
                        "INSERT INTO UserSettings" +
                        " (UserId) VALUES (@UserId);" +
                        " SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@UserId", user.Id));

                        cnn.Open();

                        object id = cmd.ExecuteScalar();
                        if (id != null)
                        {
                            user.Settings.Id = Convert.ToInt32(id);
                            res = true;
                        }
                    }
                }
            }

            return res;
        }


        public bool Delete(Entities.User user)
        {
            bool res = false;
            
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                string query =
                    "DELETE FROM UserSettings" +
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
