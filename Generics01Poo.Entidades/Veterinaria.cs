using System;
using System.Collections.Generic;
using System.Text;

namespace Generics01Poo.Entidades
{
    public class Veterinaria<T,U> where T:Perro where U:Gato
    {
        private List<T> perros;
        private List<U> gatos;

        public Veterinaria()
        {
            perros = new List<T>();
            gatos = new List<U>();
        }

        public void AgregarPerro(T elemento)
        {
            perros.Add(elemento);
        }

        public void AgregarGato(U elemento)
        {
            gatos.Add(elemento);
        }

        public string MostrarDatosVeterinaria()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var perro in perros)
            {
                sb.AppendLine(perro.MostrarDatos());
            }

            foreach (var gato in gatos)
            {
                sb.AppendLine(gato.MostrarDatos());
            }

            return sb.ToString();
        }
    }
}
