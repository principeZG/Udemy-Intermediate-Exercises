﻿using System;

namespace Exercise_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = "SELECT * FROM tblCustomers";
            var sqlConn = new SqlConnection("Sql000");
            var oracleConn = new OracleConnection("OracleABCD");
            var dbCommand = new DbCommand(sqlConn,command);

            Console.WriteLine(sqlConn.ConnectionOpen.ToString());
            Console.WriteLine(oracleConn.ConnectionOpen.ToString());
            Console.WriteLine();

            sqlConn.Open();
            //oracleConn.Open();
            Console.WriteLine(sqlConn.ConnectionOpen.ToString());
            Console.WriteLine(oracleConn.ConnectionOpen.ToString());
            //oracleConn.Open();

            dbCommand.Execute();

        }
    }
}
