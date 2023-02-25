namespace PrimerEjemplo
{
    class Persona 
    {
        //3 atributos: apellido, nombre, dni
        //atributos autoimplementados en c#
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int dni { get; set; }

        public Persona()
        {
            //este es el constructor por omisión, y si no le pongo código podría no escribirlo
            apellido = "Sin valor";
            nombre = "Sin valor";
        }
        
        public Persona(string a, string n, int d)
        {
            //este es un constructor sobrecargado
            apellido = a;
            nombre = n;
            dni = d;
        }

        public string MostrarDatos()
        {
            string resultado;
            resultado = $"{nombre} {apellido}, DNI {dni}";
            return resultado;
        }
    }
}