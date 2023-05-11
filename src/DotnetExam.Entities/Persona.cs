using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetExam.Entities
{
    public abstract class Persona
    {
        public int _Id { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public string NombreCompleto { get; set; }
    }
}
