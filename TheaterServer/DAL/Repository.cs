using MovieTheater.DAL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace TheaterServer.DAL
{
    public class Repository
    {
       protected DbContext dbContext;
       protected ModelFactory modelFactory;
       
        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.modelFactory = new ModelFactory();
        }

        protected void AddParameters(string parmName, string paraValue)
        {
            OleDbParameter oleDbParameter = new OleDbParameter();
            oleDbParameter.Value = paraValue;
            oleDbParameter.ParameterName = parmName;
            this.dbContext.AddParameters(oleDbParameter);
        }

    }
}