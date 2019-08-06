using ProgramPet.Domain;
using ProgramPet.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPet.Services
{
    public interface IServicesPet
    {
        bool save(PetShop pet);

        bool update(PetShop pet);

        bool delete(PetShop pet);

        IEnumerable<PetShop> getall();

        PetShop getbyid(int id);
    }
}
