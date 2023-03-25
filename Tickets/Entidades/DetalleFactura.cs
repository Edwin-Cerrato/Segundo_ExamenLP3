namespace Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }

        public int IdFactura { get; set; }

        public decimal Precio { get; set; }

        public DetalleFactura()
        {
        }

        public DetalleFactura(int id, int idFactura, decimal precio)
        {
            Id = id;
            IdFactura = idFactura;
            Precio = precio;
        }
    }
}
