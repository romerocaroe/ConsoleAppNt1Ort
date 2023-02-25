using System; //Esto es como el import de java
                //aquí le estoy diciendo que use una liubrería base del gramework que se llama System

namespace PrimerEjemplo //Espacio de nombres, relacionado con la compilación y visibilidad de las librerias
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int dni;
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su dni: ");
            dni = Convert.ToInt32(Console.ReadLine());

            //Instancio un objeto del tipo Alumno
            Alumno alumno = new Alumno(nombre,apellido,dni,"Base de datos");
            Console.WriteLine("Mostrar datos del alumno: "+alumno.MostrarDatos());

            //Espera leer algo tipeado desde la consola
            Console.ReadKey();
        }
    }
}