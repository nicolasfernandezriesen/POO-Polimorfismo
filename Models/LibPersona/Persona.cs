using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibPersona
{
    public abstract class Persona
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return "Nombre: " + Name + " Apellido: " + LastName;
        }
    }
}
