using System;

namespace Tarea3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de gestión de usuarios.");
            Console.WriteLine("Por favor, ingrese los datos del primer usuario:");

            // Pedir datos del primer usuario
            Console.Write("Nombre: ");
            string nombreUsuario1 = Console.ReadLine();
            Console.Write("Edad: ");
            int edadUsuario1 = Convert.ToInt32(Console.ReadLine());

            // Crear objeto de la clase Usuario con constructor que recibe nombre y edad
            Usuario usuario1 = new Usuario(nombreUsuario1, edadUsuario1);

            Console.WriteLine("\nDatos del primer usuario:");
            usuario1.ImprimirDatos();

            // Pedir datos del segundo usuario
            Console.WriteLine("\nPor favor, ingrese los datos del segundo usuario:");
            Console.Write("Nombre: ");
            string nombreUsuario2 = Console.ReadLine();
            Console.Write("Edad: ");
            int edadUsuario2 = Convert.ToInt32(Console.ReadLine());

            // Crear objeto de la clase Usuario con constructor por defecto
            Usuario usuario2 = new Usuario();
            usuario2.Nombre = nombreUsuario2;
            usuario2.Edad = edadUsuario2;

            Console.WriteLine("\nDatos del segundo usuario:");
            usuario2.ImprimirDatos();

            // Llamada a método que utiliza diferentes tipos de parámetros
            usuario1.MetodoConParametros(10, "Hola");

            // Llamada al método que se puede utilizar una o dos veces
            usuario1.MetodoRepetible();
            usuario1.MetodoRepetible();

            // Espera a que el usuario presione una tecla para salir
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

    class Usuario
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor por defecto
        public Usuario()
        {
        }

        // Constructor con parámetros
        public Usuario(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método para imprimir los datos del usuario
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }

        // Método con diferentes tipos de parámetros
        public void MetodoConParametros(int numero, string texto)
        {
            Console.WriteLine($"Número: {numero}, Texto: {texto}");
        }

        // Método que puede ser utilizado una o dos veces
        public void MetodoRepetible()
        {
             object objeto = null;

            if (objeto == null)
            {
                objeto = new object();
                Console.WriteLine("Se ha creado un objeto dentro de MetodoRepetible.");
            }
            else
            {
                Console.WriteLine("Ya se ha creado un objeto previamente.");
            }
        }
    }
}
