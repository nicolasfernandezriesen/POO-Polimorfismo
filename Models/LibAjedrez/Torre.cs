using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibAjedrez
{
    public class Torre : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Se puede mover en linea recta en las cuatro direcciones hasta el final";
        }
    }
}
