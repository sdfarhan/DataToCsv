using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataToCSV
{
    class MySql
    {
        private MySqlConnection Connection;
        private string Server;
        private string Database;
        private string User;
        private string Password;
        public MySql()
        {
            Initialize();
        }
        public MySql(MySqlCredentials ServerInfo)
        {
            Initialize(ServerInfo);
        }
        private string GetConnectionString()
        {
            return "SERVER=" + Server + ";"
                + "DATABASE=" + Database + ";"
                + "UID=" + User + ";"
                + "PASSWORD=" + Password + ";";
        }
        private void Initialize(MySqlCredentials serverInfo)
        {
            Server = serverInfo.ServerUrl;
            Database = serverInfo.ServerDatabase;
            User = serverInfo.ServerUser;
            Password = serverInfo.ServerPassword;
                Connection = new MySqlConnection(GetConnectionString());            
        }
        private void Initialize()
        {
            Server = "localhost";
            Database = "TodoDatabase";
            User = "root";
            Password = "953624187";
            Connection = new MySqlConnection(GetConnectionString());
        }
        private bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException EX)
            {
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                throw new InvalidCredentialsException(EX.Message);
                switch (EX.Number)
                {
                    case 0:
                        Debug.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Debug.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public List<List<string>> GetData(string Table)
        {
            string query = $"select * from {Table}";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
                List<List<string>> MyData = new List<List<string>>();
            MyData.Add(GetColumns(Table));
            if (this.OpenConnection())
            {
                using (MySqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        List<string> EachRow = new List<string>();
                        foreach (string Column in MyData[0])
                        {
                            EachRow.Add(Reader[Column].ToString());
                        }
                        MyData.Add(EachRow);
                    }
                }
                CloseConnection();
            }
            return MyData;
        }
        public List<string> GetColumns(string Table)
        {
            List<string> Names = new List<string>();
            string query = $"show columns from {Table}";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            if (this.OpenConnection())
            {
                using (MySqlDataReader Reader = cmd.ExecuteReader())
                {
                    while(Reader.Read())
                    {
                        Names.Add(Reader.GetString(0));
                    }
                }
                CloseConnection();
            }
            return Names;
        }
        private bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
        public List<string> GetTables()
        {
            List<string> TableNames = new List<string>();
            string query = $"show tables from {Database}";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            if (this.OpenConnection())
            {
                using (MySqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        TableNames.Add(Reader.GetString(0));
                    }
                }
                CloseConnection();
            }
            return TableNames;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
