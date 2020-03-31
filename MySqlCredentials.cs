namespace DataToCSV
{
    class MySqlCredentials
    {
        public string ServerUrl;
        public string ServerUser;
        public string ServerPassword;
        public string ServerDatabase;
        public MySqlCredentials(string ServerUrl, string ServerUser, string ServerPassword, string ServerDatabase)
        {
            this.ServerUrl = ServerUrl;
            this.ServerUser = ServerUser;
            this.ServerPassword = ServerPassword;
            this.ServerDatabase = ServerDatabase;
        }
    }
}