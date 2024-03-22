using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using TheaterServer;

namespace MovieTheater.DAL
{
    public class OleDbContext:DbContext
    {
        static OleDbContext oleDbContext;
        static object blocker = new object();
        private OleDbContext()
        {
            this.connection = new OleDbConnection();
            this.connection.ConnectionString = CommonParameters.ConnectionString;
            this.command = this.connection.CreateCommand();

        }
        public static OleDbContext GetInstance()
        {
            lock(blocker)
            {
              if (oleDbContext == null)
                oleDbContext = new OleDbContext();
            return oleDbContext;
            }
            
        }
    }
   
}