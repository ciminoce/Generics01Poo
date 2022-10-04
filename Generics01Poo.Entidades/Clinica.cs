using System;
using System.Collections.Generic;
using System.Text;

namespace Generics01Poo.Entidades
{
    public class Clinica<T>
    {
        private List<T> lista;

        public Clinica()
        {
            lista = new List<T>();
        }

        public int GetCantidad() => lista.Count;

        public void Agregar(T elemento)
        {
            lista.Add(elemento);
        }

        public void Borrar(T elemento)
        {
            lista.Remove(elemento);
        }

        public T this[int index]
        {
            get
            {
                return lista[index];
            }
        }

        public string MostrarInfoClinica()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T elemento in lista)
            {
                sb.AppendLine(elemento.ToString());
            }

            sb.AppendLine($"Cantidad registros:{GetCantidad()}");
            return sb.ToString();
        }
    }
}
