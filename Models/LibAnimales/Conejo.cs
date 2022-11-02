using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibAnimales
{
    public class Conejo : Animal
    {
        #region Propiedades

        public string habitat;

        #endregion
        #region Constructores

        public Conejo() { }

        public Conejo(string habitat, int edad, decimal altura, decimal peso) : base(edad, altura, peso)
        {
            this.habitat = habitat;
        }

        #endregion
        #region Metodos

        public override string Comida()
        {
            return "Comida: verduras o plantas";
        }

        #endregion
    }
}
