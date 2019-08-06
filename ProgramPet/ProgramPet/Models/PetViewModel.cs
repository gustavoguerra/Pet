using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramPet.Models
{
    public class PetViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Nome do Animal")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.DateTime)]
        public DateTime Age { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Telefone")]
        public string Active { get; set; }
    }
}
