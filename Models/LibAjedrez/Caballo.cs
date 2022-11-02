using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibAjedrez
{
    public class Caballo : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Se puede mover en forma de L, tres casillas y luego 2 casillas";
        }
    }
}
