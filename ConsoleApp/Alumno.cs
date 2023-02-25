namespace PrimerEjemplo
{
    class Alumno : Persona //el : es como el extends de java
    {
        public string materiaFavorita { get; set;}

        public DateTime fechaNaciminento { get; set;}

        public Alumno()
        {
            materiaFavorita = "Sin valor";
        }
        
        public Alumno(string a, string n, int d, string m) : base(a,n,d)
        {
            materiaFavorita = m;
        }

        public string MostrarDatos()
        {
            string resultado;
            //el base es como el super de java (referencia a la clase base que es la superclase)
            resultado = "El Alumno " + base.MostrarDatos() + $" y su materia favorita es {materiaFavorita}";
            return resultado;
        }

    }
}