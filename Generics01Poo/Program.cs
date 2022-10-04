using System;
using Generics01Poo.Entidades;

namespace Generics01Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sanatorioLobos = new Clinica<Persona>();
            //var persona = new Persona("Steve", "Howe", new DateTime(1950, 10, 27));
            
            //var persona2 = new Persona("Rick", "Wakeman", new DateTime(1947, 7, 8));
            //sanatorioLobos.Agregar(persona);
            //Console.WriteLine(sanatorioLobos.MostrarInfoClinica());
            //sanatorioLobos.Agregar(persona2);
            //Console.WriteLine(sanatorioLobos.MostrarInfoClinica());
            //sanatorioLobos.Borrar(persona);
            //Console.WriteLine(sanatorioLobos.MostrarInfoClinica());
            var perro = new Perro("Ovejero", "Gunnar");
            var veterinariaElFortin = new Clinica<Animal>();
            veterinariaElFortin.Agregar(perro);
            var gato = new Gato("Angora", "Miyo");
            veterinariaElFortin.Agregar(gato);
            Console.WriteLine(veterinariaElFortin.MostrarInfoClinica());

            var veterinaria = new Veterinaria<Perro, Gato>();
            veterinaria.AgregarGato(gato);
            veterinaria.AgregarPerro(perro);
            Console.WriteLine(veterinaria.MostrarDatosVeterinaria());
            var lagarto = new Perro("Overo", "Juancho");
            Console.ReadLine();
        }
    }
}
