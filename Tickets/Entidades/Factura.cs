﻿using System;

namespace Entidades
{
    public class Factura
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }
        public string IdentidadCliente { get; set; }
        public string CodigoUsuario { get; set; }

        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalAPagar { get; set; }

        public string DescripcionSolicitud { get; set; }
        public string TipoSoporte { get; set; }

        public Factura()
        {
        }

        public Factura(int id, DateTime fecha, string identidadCliente, string codigoUsuario, decimal iSV, decimal descuento, decimal totalAPagar, string descripcionSolicitud, string tipoSoporte)
        {
            Id = id;
            Fecha = fecha;
            IdentidadCliente = identidadCliente;
            CodigoUsuario = codigoUsuario;
            ISV = iSV;
            Descuento = descuento;
            TotalAPagar = totalAPagar;
            DescripcionSolicitud = descripcionSolicitud;
            TipoSoporte = tipoSoporte;
        }
    }
}
