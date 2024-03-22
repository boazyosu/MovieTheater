using MovieModels;
using MovieTheater.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TheaterServer.DAL
{
    public class UserRepository : Repository, IRepository<User>
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public bool Delete(string id)
        {
            return false;
        }

        public bool Delete(int id)
        {
            string sql = $"Delete from Cities where CityId=@id";
            this.AddParameters("id", id.ToString());
            return this.dbContext.Delete(sql) > 0;

        }

        public bool Delete(City model)
        {
            string sql = $"Delete from Cities where CityId=@id";
            this.AddParameters("id", model.CityId.ToString());
            return this.dbContext.Delete(sql) > 0;
        }

        public bool Insert(City model)
        {
            string sql = "Insert into Cities(CityName) values('@CityName')";
            this.AddParameters("CityName", model.CityName);
            return this.dbContext.Create(sql) > 0;
        }

        public City Read(object id)
        {
            string sql = "Select * from Cities where CountryId=@id";
            this.AddParameters("countryId", id.ToString());
            IDataReader reader = this.dbContext.Read(sql);
            City city = this.modelFactory.CityModelCreator.CreateModel(reader);
            return city;

            // return this.modelFactory.CountryModelCreator.CreateModel(this.dbContext.Read(sql));
        }

        public List<City> ReadAll()
        {
            List<City> countries = new List<City>();
            string sql = "Select * from Cities";
            IDataReader reader = this.dbContext.Read(sql);
            while (reader.Read() == true)
                countries.Add(this.modelFactory.CityModelCreator.CreateModel(reader));
            return countries;
        }

        public object ReadValue()
        {
            throw new NotImplementedException();
        }

        public bool Update(City model)
        {
            string sql = @"Update Cities set cityName='@cityName'
                           where CountryId=@cityId";
            this.AddParameters("cityId", model.CityId.ToString());
            this.AddParameters("cityName", model.CityName);
            return this.dbContext.Update(sql) > 0;

        }
    }
}