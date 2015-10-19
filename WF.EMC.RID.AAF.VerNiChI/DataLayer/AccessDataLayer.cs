using System;
//todo<!-- 1 add using statements -->
using System.Data;
using System.Data.SqlClient;
//todo<!-- 1 end -->
using System.Globalization;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// d[C#]b-- PullData() used to read from the database and write the query to a .csv file
        /// </summary>
        public static void PullData()
        {
        }
        #endregion

        

        #region //ReturnRows Method
        /// <summary>
        /// d[C#]b-- 
        /// </summary>
        public static List<String> ExecuteQuery(string connectionString, string storedProcedure,
            params SqlParameter[] paramaters)
        {
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
