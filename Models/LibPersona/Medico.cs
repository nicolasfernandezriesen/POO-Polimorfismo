using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibPersona
{
    public class Medico : Persona
    {
        public string profesion;

        public override string ToString()
        {
            return base.ToString() + " Area de trabajo: " + profesion;
        }
    }
}
