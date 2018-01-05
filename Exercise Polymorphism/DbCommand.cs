using System;

namespace Exercise_Polymorphism
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _dbCommand;
        

        public DbCommand(DbConnection dbConnection, string dbCommand)
        {
            if (dbConnection != null)
            {
                if (!string.IsNullOrWhiteSpace(dbCommand))
                {
                    _dbConnection = dbConnection;
                    _dbCommand = dbCommand;
                }
                else
                    throw new InvalidOperationException("Command cannot be empty");
                
            }
            else
                throw new ArgumentNullException("There is no open connection!");
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Execute: {0}", _dbCommand);
            _dbConnection.Close();
        }

    }
}