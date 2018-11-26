using Npgsql;

namespace AppDB
{
    static class Connection
    {
        public static NpgsqlConnection con;

        public static string connection()
        {
            return @"Host = localhost;
                     Port = 5432;
                     UserId = postgres;
                     Password = 123;
                     Database = AutoSalonDB;";
                        
        }
    }
}
