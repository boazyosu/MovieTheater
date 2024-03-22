using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterServer.DAL
{
    public class ModelFactory
    {

        MessagesModelCreator messagesModelCreator;
        MovieModelCreator movieModelCreator;
        UserModelCreator userModelCreator;
        PurchasesModelCreator purchasesTypeModelCreator;

        public MessagesModelCreator MessagesModelCreator
        {
            get
            {
                if (MessagesModelCreator == null)
                    this.messagesModelCreator = new MessagesModelCreator();
                return this.messagesModelCreator;
            }
        }
        public MovieModelCreator MovieModelCreator
        {
            get
            {
                if (movieModelCreator == null)
                    this.movieModelCreator = new MovieModelCreator();
                return this.movieModelCreator;
            }
        }
        public UserModelCreator UserModelCreator
        {
            get
            {
                if (this.userModelCreator == null)
                    this.userModelCreator = new UserModelCreator();
                return this.userModelCreator;
            }
        }
        public PurchasesModelCreator PurchasesModelCreator
        {
            get
            {
                if (PurchasesModelCreator == null)
                    this.purchasesTypeModelCreator = new PurchasesModelCreator();
                return this.purchasesTypeModelCreator;
            }
        }
    }
}