using System;

namespace Exercise_Polymorphism
{
    public class OracleConnection : DbConnection
    {

        public OracleConnection(string connStr)
            : base(connStr)
        {
            
        }

        public override void Open()
        {
            if (!ConnectionOpen)
            {
                Console.WriteLine("Oracle Connection open");
                ConnectionOpen = true;
            }
            else
            {
                Console.WriteLine("Oracle connection already opened.");
            }
            
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection closed");
            ConnectionOpen = false;
        }

    }
}