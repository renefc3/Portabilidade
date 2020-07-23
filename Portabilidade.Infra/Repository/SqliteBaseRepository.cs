using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace Portabilidade.Infra.Repository
{
    public class SqliteBaseRepository
    {
        // Sugestão para diminuir o acesso a essa propriedade
        // protected string DbFile
        public static string DbFile
        {
            get { return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\Portabilidade.Infra\Data\Portabilidade.sqlite")); }
        }
        
        // Sugestão para diminuir o acesso a essa função 
        // protected SqliteConnection SimpleDbConnection() => new SqliteConnection("Data Source=" + DbFile);
        public static SqliteConnection SimpleDbConnection() => new SqliteConnection("Data Source=" + DbFile);
    }
}
