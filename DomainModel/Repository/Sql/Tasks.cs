using System.Data;
using System.Data.SqlClient;
using Entities.Abstract.Repository;


namespace DomainModel.Repository.Sql
{

    public class Tasks : ITask
    {

        private string sqlCnnStr;


        public Tasks(string sqlCnnStr)
        {
            this.sqlCnnStr = sqlCnnStr;
        }


        public Entities.TaskCollection GetAll()
        {
            Entities.TaskCollection tasks = new Entities.TaskCollection();

            using (SqlConnection cnn = new SqlConnection(sqlCnnStr))
            {
                string query = "SELECT * FROM Tasks";

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
                                Entities.Task task = new Entities.Task();

                                task.Id = Utils.GetSafeInt32(reader, "TaskId");
                                task.Name = Utils.GetSafeString(reader, "TaskName");

                                tasks.Add(task);
                            }
                        }
                    }
                }
            }

            return tasks;
        }
    }
}
