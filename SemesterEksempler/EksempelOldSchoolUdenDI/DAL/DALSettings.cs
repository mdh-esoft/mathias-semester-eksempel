namespace EksempelOldSchoolUdenDI.DAL
{
    public class DALSettings
    {
        public string DbConnectionString { get; set; }

        public DALSettings(string dbConnectionString)
        {
            DbConnectionString = dbConnectionString;
        }

    }
}
