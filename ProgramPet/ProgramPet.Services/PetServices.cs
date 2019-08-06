using System;
using System.Collections.Generic;
using System.Text;
using ProgramPet.Domain;
using ProgramPet.Repository;

namespace ProgramPet.Services
{
    public class PetServices : IServicesPet
    {
        private readonly IRepository<PetShop> _repository;

        public PetServices(IRepository<PetShop> repository)
        {
            _repository = repository;
        }
        public bool delete(PetShop pet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PetShop> getall()
        {
            return _repository.getall();
        }

        public PetShop getbyid(int id)
        {
            throw new NotImplementedException();
        }

        public bool save(PetShop pet)
        {
            return _repository.save(pet);
        }

        public bool update(PetShop pet)
        {
            throw new NotImplementedException();
        }
    }
}
