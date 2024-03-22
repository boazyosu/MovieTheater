using MovieModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TheaterServer.DAL
{

    public class MovieRepository : Repository, IRepository<Movie>
    {
        public MovieRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public bool Delete(string id)
        {
            string sql = $@"Delete from Books where BookId={id}";
            return this.dbContext.Delete(sql) > 0;
        }

        public bool Delete(int id)
        {
            string sql = $@"Delete from Books where BookId={id}";
            return this.dbContext.Delete(sql) > 0;
        }

        public bool Delete(Movie model)
        {
            string sql = $@"Delete from Books where BookId={model.BookId}";
            return this.dbContext.Delete(sql) > 0;
        }

        public bool Insert(Movie model)
        {
            string sql = $@"Insert into Books(BookName,BookDescription,
                          BookImage) values('{model.BookName}',
                          '{model.BookDescription}','{model.BookImage}')";
            return this.dbContext.Create(sql) > 0;
        }

        public Movie Read(object id)
        {

            string sql = $@"Select * from Books where BookId={id.ToString()}";
            using (IDataReader dataReader = this.dbContext.Read(sql))
                return this.modelFactory.BookModelCreator.CreateModel(dataReader);
        }

        public List<Movie> ReadAll()
        {
            string sql = $@"Select * from Books";
            List<Movie> list = new List<Movie>();
            using (IDataReader dataReader = this.dbContext.Read(sql))
            {
                while (dataReader.Read())
                    list.Add(this.modelFactory.MovieModelCreator.CreateModel(dataReader));
                return list;
            }

        }

        public object ReadValue()
        {
            throw new NotImplementedException();
        }

        public bool Update(Movie model)
        {
            string sql = $@"Update Movies set MovieName='{model.MovName}',
                            MovDesc='{model.MovDesc}'
                            MovImg='{model.MovImg}'
                            where AuthorId={model.BookId}";
            return this.dbContext.Update(sql) > 0;
        }
        public List<Movie> GetBooksByAuthor(int authorId)
        {
            List<Movie> movies = new List<Movie>();
            string sql = $@"SELECT BooksAythors.AuthorId, Books.BookId,
                             Books.BookName, Books.BookDescription, 
                             Books.BookImage, Books.BookCopies
                             FROM Books INNER JOIN BooksAythors ON 
                             Books.BookId = BooksAythors.BookId
                             WHERE BooksAythors.AuthorId={authorId}";
            using (IDataReader reader = this.dbContext.Read(sql))
            {
                while (reader.Read())
                {
                    movies.Add(modelFactory.MovieModelCreator.CreateModel(reader));
                }
            }
            return movies;
        }
    }
}