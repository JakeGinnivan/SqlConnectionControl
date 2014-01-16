using System.Collections.Generic;

namespace WpfApplication1
{
    public interface ISmoTasks
    {
        IEnumerable<string> SqlServers {get;}
        List<string> GetDatabases(SqlConnectionString connectionString);
        List<DatabaseTable> GetTables(SqlConnectionString connectionString);
    }
}
