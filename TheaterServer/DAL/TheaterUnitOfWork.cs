using TheaterServer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterServer.DAL
{
    public class TheaterUnitOfWork
    {

        UserRepsitory authorRepsitory;
        MovieRepository bookRepository;
        BookTypeRepository typeRepository;
        BorrowRepository borrowRepository;

        DbContext dbContext;

        public TheaterUnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext; 
        }
        public AuthorRepsitory AuthorRepsitory
        {
            get
            {
                if (this.authorRepsitory == null)
                    this.authorRepsitory = new AuthorRepsitory(dbContext);
                return this.authorRepsitory;
            }
           
        }

        public BookRepository BookRepository
        {
            get
            {
                if (this.bookRepository == null)
                    this.bookRepository = new BookRepository(dbContext);
                return this.bookRepository;
            }
        }

        public BookTypeRepository BookTypeRepository
        {
            get
            {
                if (this.typeRepository == null)
                    this.typeRepository = new BookTypeRepository(dbContext);
                return this.typeRepository;
            }
        }

        public BorrowRepository BorrowRepository
        {
            get
            {
                if (this.borrowRepository == null)
                    this.borrowRepository = new BorrowRepository(dbContext);
                return this.borrowRepository;
            }
        }

        public UserRepository CityRepository
        {
            get
            {
                if (this.cityRepository == null)
                    this.cityRepository = new UserRepository(dbContext);
                return this.cityRepository;
            }
        }

        public CountryRepository CountryRepository
        {
            get
            {
                if (this.countryRepository == null)
                    this.countryRepository = new CountryRepository(dbContext);
                return this.countryRepository;
            }
        }

        public UserRepository ReaderRepository
        {
            get
            {
                if (this.readerRepository == null)
                    this.readerRepository = new UserRepository(dbContext);
                return this.readerRepository;
            }
        }
    }
}