using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibPersona
{
    public class Paciente : Persona
    {
        public int numPaciente;

        public override string ToString()
        {
            return base.ToString() + " Numero de paciente: " + numPaciente;
        }
    }
}
