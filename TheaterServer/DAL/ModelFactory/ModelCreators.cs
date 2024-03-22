using TheaterServer.DAL;
using MovieModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TheaterServer.DAL
{
    public class MovieModelCreator : IOleDbModelCreator<Movie>
    {
        public Movie CreateModel(IDataReader source)
        {
            Movie movie = new Movie()
            {
                MovName = Convert.ToString(source["MovName"]),
                MovID = Convert.ToInt16(source["MovID"]),
                MovYear = Convert.ToInt16(source["MovYear"]),
                MovImg = Convert.ToString(source["MovImg"]),
                MovPrice = Convert.ToInt16(source["MovPrice"]),
                MovDesc = Convert.ToString(source["MovDesc"]),
                MovGenre = Convert.ToString(source["MovGenre"]),
            };
            return movie;
        }
        
    }

    public class UserModelCreator : IOleDbModelCreator<User>
    {
        public User CreateModel(IDataReader source)
        {
            User user = new User()
            {
                UserId = Convert.ToInt16(source["UserId"]),
                UserEmail = Convert.ToString(source["UserEmail"]),
                UserName = Convert.ToString(source["UserName"]),
                UserPassword = Convert.ToString(source["UserId"]),
                UserPhone = Convert.ToString(source["UserPhone"]),
            };
            return user;
        }
    }

    public class MessagesModelCreator : IOleDbModelCreator<Messages>
    {
        public Messages CreateModel(IDataReader source)
        {
            Messages message = new Messages()
            {
                MsgID = Convert.ToString(source["MsgID"]),
                MsgReceiver = Convert.ToString(source["MsgReceiver"]),
                MsgContent = Convert.ToString(source["MsgContent"]),
            };
            return message;
        }
    }

    public class PurchasesModelCreator : IOleDbModelCreator<Purchases>
    {
        public Purchases CreateModel(IDataReader source)
        {
            Purchases purchase = new Purchases()
            {
                PurchaseId = Convert.ToInt16(source["PurchaseId"]),
                PurchaseUser = Convert.ToString(source["PurchaseUser"]),
                PurchaseDate = Convert.ToString(source["PurchaseDate"]),
                TotalPayment = Convert.ToInt16(source["TotalPayment"]),
                PayedFor = Convert.ToBoolean(source["PayedFor"]),
                PurchaseMov = Convert.ToString(source["PurchaseUser"]),
            };
            return purchase;
        }
    }
}