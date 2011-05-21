using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Entities.Abstract.Repository;


namespace DomainModel.Repository.Sql
{

    public class Roles : IRole
    {

        private string sqlCnnStr;


        public Roles(string sqlCnnStr)
        {
            this.sqlCnnStr = sqlCnnStr;
        }


        public Entities.RoleCollection GetAll()
        {
            Entities.RoleCollection roles = new Entities.RoleCollection();

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                string query = "SELECT * FROM Roles";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Entities.Role role = new Entities.Role();

                                role.Id = Utils.GetSafeInt32(reader, "RoleId");
                                role.Name = Utils.GetSafeString(reader, "RoleName");
                                role.Priority = System.Convert.ToInt32(Utils.GetSafeString(reader, "RolePriority"));

                                roles.Add(role);
                            }
                        }
                    }
                }
            }

            return roles;
        }


        public void LoadTasks(Entities.RoleCollection roles)
        {
            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                string query = "SELECT * FROM RoleTasks";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;

                    cnn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            Entities.Role role;
                            Entities.Task task;

                            while (reader.Read())
                            {
                                role = Membership.Roles.GetById(Utils.GetSafeInt32(reader, "RoleId"));
                                task = Membership.Tasks.GetById(Utils.GetSafeInt32(reader, "TaskId"));

                                role.Tasks.Add(task);
                            }
                        }
                    }
                }
            }
        }


        public bool AddTaskToRole(Entities.Role role, Entities.Task task)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                string query =
                    "INSERT INTO RoleTasks" +
                    " (RoleId, TaskId)" +
                    " VALUES " +
                    " (@RoleId, @TaskId)";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("@TaskId", task.Id));
                    cmd.Parameters.Add(new SqlParameter("@RoleId", role.Id));

                    cnn.Open();


                    int affected = cmd.ExecuteNonQuery();

                    res = (affected > 0);

                }
            }

            return res;
        }


        public bool RemoveTaskFromRole(Entities.Role role, Entities.Task task)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                string query =
                    "DELETE FROM RoleTasks" +
                    " WHERE RoleId = @RoleId AND TaskId = @TaskId";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("@TaskId", task.Id));
                    cmd.Parameters.Add(new SqlParameter("@RoleId", role.Id));

                    cnn.Open();


                    int affected = cmd.ExecuteNonQuery();

                    res = (affected > 0);

                }
            }

            return res;
        }


        public bool Delete(Entities.Role role)
        {
            bool res = false;

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
                {
                    string query = "DELETE FROM RoleTasks WHERE RoleId = @RoleId";
                    int affected = 0;

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Add(new SqlParameter("@RoleId", role.Id));

                        cnn.Open();

                        affected = cmd.ExecuteNonQuery();
                    }

                    query = "DELETE FROM Roles WHERE RoleId = @RoleId";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Add(new SqlParameter("@RoleId", role.Id));

                        affected = cmd.ExecuteNonQuery();
                    }

                }

                ts.Complete();
                res = true;
            }

            return res;
        }


        public bool Insert(Entities.Role role)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                string query =
                    "INSERT INTO Roles" +
                    " (RoleName, RolePriority)" +
                    " VALUES " +
                    " (@RoleName, @RolePriority);" +
                    " SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@RoleName", role.Name));
                    cmd.Parameters.Add(new SqlParameter("@RolePriority", role.Priority));

                    cnn.Open();

                    object id = cmd.ExecuteScalar();
                    if (id != null)
                    {
                        role.Id = Convert.ToInt32(id);
                        res = true;
                    }
                }
            }

            return res;
        }


        public bool Update(Entities.Role role)
        {
            bool res = false;

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                string query =
                    "UPDATE Roles" +
                    " SET RoleName = @RoleName, RolePriority = @RolePriority" +
                    " WHERE " +
                    " RoleId = @RoleId;";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@RoleName", role.Name));
                    cmd.Parameters.Add(new SqlParameter("@RolePriority", role.Priority));
                    cmd.Parameters.Add(new SqlParameter("@RoleId", role.Id));

                    cnn.Open();

                    int affected = cmd.ExecuteNonQuery();
                    res = (affected > 0);
                }
            }

            return res;
        }
    }
}
