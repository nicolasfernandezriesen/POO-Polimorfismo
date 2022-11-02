using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibAnimales
{
    public class Loro : Animal
    {
        #region Propiedades

        public string color;

        #endregion
        #region Constructores

        public Loro() { }

        public Loro(string color, int edad, decimal altura, decimal peso) : base(edad, altura, peso) 
        {
            this.color = color;
        }

        #endregion
        #region Metodos

        public override string Comida()
        {
            return "Comida: semillas";
        }

        #endregion
    }
}
