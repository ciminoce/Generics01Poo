using System;
using System.Collections.Generic;
using System.Text;

namespace Generics01Poo.Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int edad { get; }

        public Persona(string Nombre, string Apellido, DateTime FechaNacimiento)
        {
            nombre = Nombre;
            apellido = Apellido;
            fechaNacimiento = FechaNacimiento;
            edad = CalcularEdad();
        }

        private int CalcularEdad()
        {
            return (int)Math.Truncate(DateTime.Today.Subtract(fechaNacimiento).TotalDays / 365.25);
        }

        public override string ToString()
        {
            return $"Soy {nombre} {apellido} y tengo {edad} años ";
        }
    }
}
