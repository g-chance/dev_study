using Castle.Core.Internal;
using System;

namespace cs_sandbox
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            Connection = connection;
            Instruction = instruction;
        }

        public void Execute()
        {
            Connection.OpenConnection();
            Console.WriteLine($"Running {Instruction}");
            Connection.CloseConnection();
        }
    }
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connString)
        {
            if (connString.IsNullOrEmpty())
            {
                throw new ArgumentNullException();
            }
            ConnectionString = connString;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connString)
            : base(connString) { }
        public override void OpenConnection()
        {
            Console.WriteLine($"Opening Sql connection at {ConnectionString}");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing Sql connection");
        }
    }
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connString)
            : base(connString) { }
        public override void OpenConnection()
        {
            Console.WriteLine($"Opening Oracle connection at {ConnectionString}");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle connection");
        }
    }
}
