using System;

namespace Exercise_Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connStr)
            : base(connStr)
        {

        }

        public override void Open()
        {
            if (!ConnectionOpen)
            {
                Console.WriteLine("Sql Connection open");
                ConnectionOpen = true;
            }
            else
                Console.WriteLine("Sql connection already opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Sql connection closed ");
            ConnectionOpen = false;
        }

    }
}