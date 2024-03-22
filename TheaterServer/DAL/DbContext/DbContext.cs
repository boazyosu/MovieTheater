using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MovieTheater.DAL
{
    public abstract class DbContext : IDbContext
    {
        protected IDbConnection connection; //צינור ל - DB
        protected IDbCommand command; // ברז
        protected IDbTransaction transaction; // חבילת פקודות    

        public void BeginTransaction()
        {
           this.transaction = this.connection.BeginTransaction();
        }

        public void CloseConnection()
        {
            if(this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
                this.command.Parameters.Clear();
            }
               
            // this.connection.Dispose();// שחרור זיכרון  
            this.command.Dispose();
            if(transaction!=null)
              this.transaction.Dispose();

        }

        public int Create(string sql)
        {
            return ChangeDb(sql);
        }

        private int ChangeDb(string sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteNonQuery();
        }
        public void CreateCommand()
        {
           this.command = this.connection.CreateCommand();
        }

        public int Delete(string sql)
        {
            return ChangeDb(sql);
        }

        public void OpenConnection()
        {
            if(this.connection.State == ConnectionState.Closed)
               this.connection.Open();
            CreateCommand();
        }

        public IDataReader Read(string sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteReader();
        }

        public object ReadValue(string sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteScalar();
        }

        public int Update(string sql)
        {
            return ChangeDb(sql);
            
        }
        public void AddParameters(IDataParameter parameter)
        {
            this.command.Parameters.Add(parameter);
        }
    }
}