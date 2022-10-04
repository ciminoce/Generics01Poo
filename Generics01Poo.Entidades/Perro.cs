using System;
using System.Collections.Generic;
using System.Text;

namespace Generics01Poo.Entidades
{
    public class Perro:Animal
    {
        public Perro(string Raza, string Nombre) : base("Perro", Raza, Nombre)
        {
        }

        public override string MostrarDatos()
        {
            return $"Soy un {especie} de raza {raza} y mi nombre es {nombre} ";
        }

        public string Morder()
        {
            return "Muerdo todo lo que puedo";
        }
    }
}
