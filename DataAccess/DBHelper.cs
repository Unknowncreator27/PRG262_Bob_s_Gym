using System;
using System.Data;
using System.Data.SqlClient;

namespace PRG262_Bob_s_Gym.DataAccess
{
    /// <summary>
    /// Central helper class for all database operations using ADO.NET.
    /// This class manages connections and provides reusable methods for CRUD operations.
    /// All DAO classes (MemberDAO, ClassDAO) should use this class.
    /// </summary>
    public static class DBHelper
    {
        // ================== CONNECTION STRING ==================
        private static readonly string connectionString =
            @"Server=Avisto-Desktop\SQLEXPRESS;Database=GymManagementDB;Integrated Security=True;";

        /// <summary>
        /// Returns an open SqlConnection. 
        /// IMPORTANT: Always wrap this in a 'using' statement.
        /// </summary>
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// Executes INSERT, UPDATE, DELETE commands.
        /// Returns the number of rows affected.
        /// </summary>
        public static int ExecuteNonQ(string commandText,
            CommandType cmdType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection con = CreateConnection())
                using (SqlCommand sqlCmd = new SqlCommand(commandText, con))
                {
                    con.Open();
                    sqlCmd.CommandType = cmdType;

                    if (parameters != null && parameters.Length > 0)
                        sqlCmd.Parameters.AddRange(parameters);

                    return sqlCmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database Error (SQL): {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error while executing command: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Executes SELECT queries and returns a SqlDataReader.
        /// </summary>
        public static SqlDataReader Read(string commandText,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            SqlConnection conn = null;
            try
            {
                conn = CreateConnection();
                SqlCommand sqlCmd = new SqlCommand(commandText, conn);
                sqlCmd.CommandType = commandType;

                if (parameters != null && parameters.Length > 0)
                    sqlCmd.Parameters.AddRange(parameters);

                conn.Open();
                return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn?.Close();
                throw new Exception($"Error reading data: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Returns a single value (e.g. new ID after INSERT).
        /// </summary>
        public static object ExecuteScalarVal(string cmdText,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = CreateConnection())
                using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                {
                    connection.Open();
                    cmd.CommandType = commandType;

                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database Error (SQL): {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing scalar: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Returns data in a DataTable - Best for binding to DataGridView.
        /// </summary>
        public static DataTable ExecDataTable(string cmdText,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection con = CreateConnection())
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database Error while filling DataTable: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error filling DataTable: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Optional: Test connection method (useful for debugging)
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection con = CreateConnection())
                {
                    con.Open();
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Excetion occurred: {e}");
                return false;
            }
        }
    }
}