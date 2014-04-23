using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Baker
{
    public class DbProcessing
    {
        #region - Declarations

        private NpgsqlConnection _dbConn;

        #endregion

        #region - Methods

        /// <summary>
        /// USED to return the Connection State.
        /// </summary>
        /// <returns></returns>
        private ConnectionState GetConnectionState()
        {
            return _dbConn.State;
        }

        /// <summary>
        /// USED to OPEN or CLOSE DataBase Connection
        /// </summary>
        /// <param name="open"></param>
        private void OpenConnection(bool open)
        {
            try
            {
                if (open)
                {
                    if (_dbConn.State == ConnectionState.Closed)
                    {
                        _dbConn.Open();
                    }
                }
                else
                {
                    if (_dbConn.State == ConnectionState.Open)
                    {
                        _dbConn.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Logger.WriteToLog("DbProcessing", "OpenConnection", ex.Message);
                CommonMessages.ErrorMessage();
            }
        }

        /// <summary>
        /// USED to initialize a DataBase Connection Get the Connection String
        /// </summary>
        private string GetConnectionString()
        {
            string connString = "User Id=postgres;" + 
                                "Password=postgres;" + 
                                "Host=localhost;" + 
                                "Port=5432;" + 
                                "Database=yhb;";
            return connString;
        }

        /// <summary>
        /// Creates a new connection to the database
        /// </summary>
        /// <param name="connectionString"></param>
        private void CreateDBConnection(string connectionString)
        {
            _dbConn = new NpgsqlConnection(connectionString);
        }

        /// <summary>
        /// Incarca DataSet dupa un SQL dat intr-un timp limita impus
        /// </summary>
        public void LoadDataSetBySQL(DataTable dataTable, string sql, int CommandTimeOut)
        {
            CreateDBConnection(GetConnectionString());
            OpenConnection(true);

            if (GetConnectionState() == ConnectionState.Open)
            {
                using (NpgsqlDataAdapter _pgSqlDataAdapter = new NpgsqlDataAdapter())
                {
                    using (NpgsqlCommand _pgSqlCommand = new NpgsqlCommand(sql))
                    {
                        _pgSqlCommand.Connection = _dbConn;
                        _pgSqlCommand.CommandTimeout = CommandTimeOut;
                        _pgSqlDataAdapter.SelectCommand = _pgSqlCommand;

                        dataTable.Rows.Clear();
                        _pgSqlDataAdapter.Fill(dataTable);
                    }
                }
            }

            OpenConnection(false);
        }

        /// <summary>
        /// Incarca DataSet dupa un SQL dat 
        /// </summary>
        public void LoadDataSetBySQL(DataTable dataTable, string sql)
        {
            CreateDBConnection(GetConnectionString());
            OpenConnection(true);

            if (GetConnectionState() == ConnectionState.Open)
            {
                using (NpgsqlDataAdapter _pgSqlDataAdapter = new NpgsqlDataAdapter())
                {
                    using (NpgsqlCommand _pgSqlCommand = new NpgsqlCommand(sql))
                    {
                        _pgSqlCommand.Connection = _dbConn;
                        _pgSqlDataAdapter.SelectCommand = _pgSqlCommand;

                        dataTable.Rows.Clear();
                        _pgSqlDataAdapter.Fill(dataTable);
                    }
                }
            }

            OpenConnection(false);
        }

        /// <summary>
        /// Executes a nonquery command on selected table
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="CommandTimeOut"></param>
        public void ExecuteSqlCommand(string sql)
        {
            CreateDBConnection(GetConnectionString());
            OpenConnection(true);

            if (GetConnectionState() == ConnectionState.Open)
            {
                using (NpgsqlDataAdapter _pgSqlDataAdapter = new NpgsqlDataAdapter())
                {
                    using (NpgsqlCommand _pgSqlCommand = new NpgsqlCommand(sql))
                    {
                        _pgSqlCommand.Connection = _dbConn;
                        _pgSqlCommand.ExecuteNonQuery();
                    }
                }
            }

            OpenConnection(false);
        }

        /// <summary>
        /// Executes a nonquery command on selected table in a given time limit
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="CommandTimeOut"></param>
        public void ExecuteSqlCommand(string sql, int CommandTimeOut)
        {
            CreateDBConnection(GetConnectionString());
            OpenConnection(true);

            if (GetConnectionState() == ConnectionState.Open)
            {
                using (NpgsqlDataAdapter _pgSqlDataAdapter = new NpgsqlDataAdapter())
                {
                    using (NpgsqlCommand _pgSqlCommand = new NpgsqlCommand(sql))
                    {
                        _pgSqlCommand.Connection = _dbConn;
                        _pgSqlCommand.CommandTimeout = CommandTimeOut;
                        _pgSqlCommand.ExecuteNonQuery();
                    }
                }
            }

            OpenConnection(false);
        }

        #endregion
    }
}
