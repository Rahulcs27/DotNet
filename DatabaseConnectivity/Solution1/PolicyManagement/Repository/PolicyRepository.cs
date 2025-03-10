using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyManagement.Constants;
using PolicyManagement.Models;
using PolicyManagement.Utility;

namespace PolicyManagement.Repository
{
    public class PolicyRepository
    {
        private readonly string connectionString = DbConnUtil.GetConnectionString();

        public List<Policy> GetAllPolicies()
        {
            List<Policy> policies = new List<Policy>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Policies";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!Enum.TryParse(reader["PolicyType"].ToString(), out PolicyType policyType))
                            {
                                Console.WriteLine($"Warning: Invalid PolicyType found for PolicyId {reader["PolicyId"]}, skipping.");
                                continue;
                            }

                            Policy policy = new Policy
                            {
                                PolicyId = (int)reader["PolicyId"],
                                PolicyHolderName = reader["PolicyHolderName"].ToString(),
                                PolicyType = policyType.ToString(),
                                //StartDate = (DateTime)reader["StartDate"],
                                StartDate = reader.GetDateTime("StartDate"),
                                EndDate = (DateTime)reader["EndDate"]
                            };

                            policies.Add(policy);
                        }
                    }
                }
            }
            return policies;
        }

    }
}
