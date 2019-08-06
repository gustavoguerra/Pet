using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPet.Domain
{
   public class PetShop : Entity
    {
        public string Name { get; set; }
        public string Active { get; set; }
        public DateTime Age { get; set; }
    }
}
