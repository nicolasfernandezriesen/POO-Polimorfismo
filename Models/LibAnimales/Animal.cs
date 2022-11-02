using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LibAnimales
{
    public abstract class Animal
    {
        #region Propiedades

        public int Edad;
        public decimal Altura;
        public decimal Peso;

        #endregion

        #region Constructores

        public Animal() { }

        public Animal(int edad, decimal altura, decimal peso)
        {
            Edad = edad;
            Altura = altura; 
            Peso = peso;
        }

        #endregion

        #region Metodos

        public virtual string Imprimir()
        {
            return "Edad: " + Edad + ", altura: " + Altura + ", peso: " + Peso;
        }

        public abstract string Comida();
        #endregion
    }
}
