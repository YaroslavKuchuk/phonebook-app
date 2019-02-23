using Phonebook.Models.DataModels;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Phonebook.AdonetLayer.Repositories
{
    public class GroupRepository : BaseRepository
    {
        public IEnumerable<Group> GetAll()
        {
            var groups = new List<Group>();

            // Connection
            using (SqlConnection conn
                = new SqlConnection(ConnectionString))
            {
                conn.Open();

                // Command
                string sql = "SELECT * FROM [Group]";

                SqlCommand command
                    = new SqlCommand(sql, conn);

                // Data retrieving
                DataTable groupsData = new DataTable();

                SqlDataAdapter dataAdapter
                    = new SqlDataAdapter(command);

                dataAdapter.Fill(groupsData);

                foreach (DataRow row in groupsData.Rows)
                {
                    groups.Add(new Group
                    {
                        Id = int.Parse(row["Id"].ToString()),
                        Name = row["Name"].ToString()
                    });
                }

                return groups;
            }
        }

        public void Add(Group group)
        {
            using (SqlConnection conn
                = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string sql = "AddGroup";

                var command = new SqlCommand(sql, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("Name", group.Name));

                command.ExecuteNonQuery();
            }
        }
    }
}
