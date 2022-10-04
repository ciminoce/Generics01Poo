using System;
using System.Collections.Generic;
using System.Text;

namespace Generics01Poo.Entidades
{
    public class Gato:Animal
    {
        public Gato(string Raza, string Nombre) : base("Gato", Raza, Nombre)
        {
        }

        public override string MostrarDatos()
        {
            return $"Soy un {especie} de raza {raza} y mi nombre es {nombre} ";
        }

        public string Rasguniar()
        {
            return "Rajunio a todo el mundo";
        }
    }
}
