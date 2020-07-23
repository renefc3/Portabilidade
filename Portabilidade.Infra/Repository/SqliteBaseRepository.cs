using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace Portabilidade.Infra.Repository
{
    /*public interface IDatabaseConnectionFactory{
        IDbConnection Get();
    }
    
    public class SqliteDatabaseConnectionFactory :IDatabaseConnectionFactory {
        protected string DbFile
        {
            get { return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\Portabilidade.Infra\Data\Portabilidade.sqlite")); }
        }
        
         protected  IDbConnection Get() => new SqliteConnection("Data Source=" + DbFile);
    }*/

    public class SqliteBaseRepository
    {
        //protected IDatabaseConnectionFactory _connectionFactory;
        
        //protected SqliteBaseRepository(IDatabaseConnectionFactory connectionFactory){
        //    _connectionFactory = connectionFactory;
        //}
        
        // Remover propriedade Usar o IDatabaseConnectionFactory 
        public static string DbFile
        {
            get { return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\Portabilidade.Infra\Data\Portabilidade.sqlite")); }
        }
        
        // Remover esse metodo Usar o IDatabaseConnectionFactory 
        public static SqliteConnection SimpleDbConnection() => new SqliteConnection("Data Source=" + DbFile);
    }
}
