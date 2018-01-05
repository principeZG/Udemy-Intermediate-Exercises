/*Design a class called DbCommand for executing an instruction against the database. A 
DbCommand cannot be in a valid state without having a connection. So in the constructor of 
this class, pass a DbConnection. Don’t forget to cater for the null.
Each DbCommand should also have the instruction to be sent to the database. In case of SQL 
Server, this instruction is expressed in T-SQL language. Use a string to represent this instruction. 
Again, a command cannot be in a valid state without this instruction. So make sure to receive it 
in the constructor and cater for the null reference or an empty string. 
Each command should be executable. So we need to create a method called Execute(). In this 
method, we need a simple implementation as follows: 
Open the connection
Run the instruction 
Close the connection
*/

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
