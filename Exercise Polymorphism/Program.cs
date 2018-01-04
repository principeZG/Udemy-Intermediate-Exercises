using System;

namespace Exercise_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            var sqlConn = new SqlConnection("Sql000");
            var oracleConn = new OracleConnection("OracleABCD");

            Console.WriteLine(sqlConn.ConnectionOpen.ToString());
            Console.WriteLine(oracleConn.ConnectionOpen.ToString());
            Console.WriteLine();

            sqlConn.Open();
            oracleConn.Open();
            Console.WriteLine(sqlConn.ConnectionOpen.ToString());
            Console.WriteLine(oracleConn.ConnectionOpen.ToString());
            oracleConn.Open();

        }
    }
}
