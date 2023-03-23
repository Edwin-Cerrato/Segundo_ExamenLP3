namespace Entidades
{
    public class Login
    {
        //Propiedades
        public string CodigoUsuario { get; set; }

        public string Contrasena { get; set; }


        //Constructor Vacio
        public Login()
        {
        }

        //Constructores de las Propiedades
        public Login(string codigoUsuario, string contrasena)
        {
            CodigoUsuario = codigoUsuario;
            Contrasena = contrasena;
        }







    }
}
