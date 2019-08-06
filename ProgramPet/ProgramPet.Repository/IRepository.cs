using ProgramPet.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPet.Repository
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        bool save(TEntity obj);
        bool update();
        bool Delete();
        IEnumerable<TEntity> getall();     
        TEntity getbyid(int id);
    }
}
