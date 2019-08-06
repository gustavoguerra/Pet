using MongoDB.Driver;
using ProgramPet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramPet.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {

        protected IMongoDatabase mongo;

        public Repository()
        {
            mongo = new conection().startconection();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> getall()
        {
            var collection = mongo.GetCollection<TEntity>(typeof(TEntity).Name);

            return collection.AsQueryable().AsEnumerable<TEntity>();
        }

        public TEntity getbyid(int id)
        {
            throw new NotImplementedException();
        }

        public bool save(TEntity obj)
        {
            var collection = mongo.GetCollection<TEntity>(typeof(TEntity).Name);
            try
            {
                collection.InsertOne(obj);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool update()
        {
            throw new NotImplementedException();
        }
    }
}
