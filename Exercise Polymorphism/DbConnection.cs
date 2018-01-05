using System;

namespace Exercise_Polymorphism
{
    /*      A DbConnection will not be in a valid state if it doesn’t have a connection string. So you need to
            pass a connection string in the constructor of this class. Also, take into account the scenarios
            where null or an empty string is sent as the connection string. Make sure to throw an exception
            to guarantee that your class will always be in a valid state.
            Our DbConnection should also have two methods for opening and closing a connection.We
            don’t know how to open or close a connection in a DbConnection and this should be left to the
            classes that derive from DbConnection. These classes (eg SqlConnection or OracleConnection) 
            will provide the actual implementation. So you need to declare these methods as abstract.
            Derive two classes SqlConnection and OracleConnection from DbConnection and provide a
            simple implementation of opening and closing connections using Console.WriteLine(). In the
            real-world, SQL Server provides an API for opening or closing a connection to a database.But
            for this exercise, we don’t need to worry about it. */

    public abstract class DbConnection
    {
        public TimeSpan Timeout { get; set; }
        public bool ConnectionOpen { get; protected set; }
        private string _connectionString;

        public string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value ?? throw new SystemException("Connection string cannot be null, or isn't provided");
        }

        protected DbConnection(string connStr)
        {
            ConnectionString = connStr;
            ConnectionOpen = false;

            if (Timeout.TotalSeconds > 30)
                throw new SystemException("Timeout occured, connection to DB cannot be opened.");
        }

        public abstract void Open();
        public abstract void Close();


    }
}