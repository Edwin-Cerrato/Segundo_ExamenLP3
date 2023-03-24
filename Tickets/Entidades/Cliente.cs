namespace Entidades
{
    public class Cliente
    {
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Cliente()
        {
        }

        public Cliente(string identidad, string nombre, string telefono, string correo)
        {
            Identidad = identidad;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }
    }
}
