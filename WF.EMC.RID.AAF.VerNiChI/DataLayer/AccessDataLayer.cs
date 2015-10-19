using System;
//todo<!-- 1 add using statements -->
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Notes
//todo<!-- 2 class public stubed out methods no logic -->
//todo<!-- 3 Added logic to PullDataMethod-->
namespace DataLayer
{
    /// <summary>
    /// d[C#]b-- AccessDataLayer handles the interactions with the database
    /// </summary>
    public class AccessDataLayer
    {
        public static string LoggerPath = Environment.CurrentDirectory + @"\Logger.txt";

        
        #region//PullDataMethod
        /// <summary>
        /// d[C#]b-- PullData() used to read from the database and write the query to a .csv file. </summary>
        /// 
        public static void PullData()
        {
            const string connectionString = "LocalSqlInstance...Need to Create Dummy data in SQL";
            const string commandText = "SELECT ID, FROM [AAF].[dob].[ConfigurationItems]";
            try
            {
                
                var filePath = Environment.CurrentDirectory + @"\AAFDbReturn.csv";
                var dataOut = new StringBuilder();
                if (!File.Exists(filePath)) File.Create(filePath).Close();

                using (var conn = new SqlConnection(connectionString)) //newing up SqlConn passing conString using = disposable
                {
                    using (var command = new SqlCommand(commandText,conn))
                    {
                        conn.Open();

                        //SqlDataReader todo read more about members
                        var dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            //string
                            var dataRow = string.Format("{0}, {1}", dataReader["ID"], dataReader["Name"]);
                            //stringBuilder
                            dataOut.AppendLine(dataRow);
                        }
                    }
                    conn.Close();
                }

                File.WriteAllText("AAFDbReturn.csv", dataOut.ToString());
               
            }
            catch (Exception e)
            {
                
                File.AppendAllText(LoggerPath, e.Message);
            }
        }

        #endregion

        

        #region //ReturnRows Method
        /// <summary>
        /// d[C#]b-- ReturnStoredProcedures method Execute the read query.</summary>
        
        /// <para>The ReturnStoredProcedure is a generic ExecuteQuery method used to Execute a Transact-SQL statemwnt
        /// against the connection for Data Base. </para>
        /// <param name="connectionString"> Name of database connection. </param>
        /// <param name="storedProcedure"> Name of stored procedure. </param>
        /// <param name="paramaters"> Array of input ParamValues. </param>
        /// <returns> Results of query in a reader. </returns>
        ///<remarks> Ceated by Nichi9130 </remarks>
        public static List<String> ExecuteQuery(string connectionString, string storedProcedure,
            params SqlParameter[] paramaters)
        {
            var queryResults = new List<string>();
            try
            {
                var sqlConnFirSqlConnection = new SqlConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return null;
            
        }

        #endregion

        #region //ExecuteNonQueryWithParams Method
        /// <summary>
        /// d[C#]b-- 
        /// </summary>
        public static int ExecuteNonQueryWithParams(string connectionStrings, string storedProcedures,
            CommandType commandType, params SqlParameter[] parameters)
        {
            return 0;
        }

        #endregion

        #region //ExecuteNonQuery Method
        /// <summary>
        /// d[C#]b-- 
        /// </summary>
        public static void ExecuteNonQuery(string connectionString, string nonQuery, CommandType commandType)
        {
        }
        #endregion

        #region //GetDataTable Method
        /// <summary>
        /// d[C#]b-- 
        /// </summary>
        public static DataTable GetDataTable(string connectionString, string query, CommandType commandType)
        {
            var dataTable = new DataTable();
            return dataTable;
        }
        #endregion
    }
}
