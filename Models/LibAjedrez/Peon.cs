using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibAjedrez
{
    public class Peon : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Se puede mover una casilla para adelante solo en diagonal, izquierda o derecha";
        }
    }
}
