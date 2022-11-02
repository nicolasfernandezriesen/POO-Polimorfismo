using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibAnimales
{
    public class Leon : Animal
    {
        #region Propiedades

        public string genero;

        #endregion

        #region Constructores

        public Leon() { }

        public Leon(string genero, int edad, decimal altura, decimal peso) : base(edad, altura, peso)
        {
           this.genero = genero;
            
        }

        #endregion

        #region Metodos

        public override string Imprimir()
        {
            return "Animal: Leon, " + base.Imprimir();
        }

        public override string Comida()
        {
            return "Comida a base de carne";
        }

        #endregion
    }
}
