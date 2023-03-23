using System;

namespace Entidades
{
    public class Usuario
    {

        //Propiedades
        public string CodigoUsuario { get; set; }

        public string Nombre { get; set; }

        public string Contrasena { get; set; }

        public string Correo { get; set; }

        public DateTime FechaCreacion { get; set; }
        public bool EstaActivo { get; set; }


        //Constructor Vacio
        public Usuario()
        {
        }


        //Constructor de Propiedades
        public Usuario(string codigoUsuario, string nombre, string contrasena, string correo, DateTime fechaCreacion, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contrasena = contrasena;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            EstaActivo = estaActivo;
        }
    }
}
