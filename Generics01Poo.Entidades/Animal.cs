using System;
using System.Collections.Generic;
using System.Text;

namespace Generics01Poo.Entidades
{
    public abstract class Animal
    {
        protected string especie;
        protected string raza;
        protected string nombre;

        public Animal(string Especie, string Raza, string Nombre)
        {
            especie = Especie;
            raza = Raza;
            nombre = Nombre;

        }

        public abstract string MostrarDatos();
    }
}
