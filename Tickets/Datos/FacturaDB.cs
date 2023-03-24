using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class FacturaDB
    {
        string cadena = "server=localhost; user=root; database=bdtickets; password=ranger2718;";

        public bool Guardar(Factura factura, List<DetalleFactura> detalles)
        {
            bool inserto = false;
            int idFactura = 0;
            try
            {
                StringBuilder sqlFactura = new StringBuilder();
                sqlFactura.Append(" INSERT INTO factura (Fecha, Identidad, CodigoUsuario, ISV, Descuento, TotalAPagar,DescripcionSolicitud,TipoSoporte) VALUES (@Fecha, @IdentidadCliente, @CodigoUsuario, @ISV, @Descuento, @TotalAPagar,@DescripcionSolicitud,@TipoSoporte); ");
                sqlFactura.Append(" SELECT LAST_INSERT_ID(); ");




                StringBuilder sqlDetalle = new StringBuilder();
                sqlDetalle.Append(" INSERT INTO detallefactura (IdFactura,Precio) VALUES (@IdFactura, @Preciol); ");



                using (MySqlConnection con = new MySqlConnection(cadena))
                {
                    con.Open();

                    MySqlTransaction transaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {
                        using (MySqlCommand cmd1 = new MySqlCommand(sqlFactura.ToString(), con, transaction))
                        {
                            cmd1.CommandType = System.Data.CommandType.Text;
                            cmd1.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = factura.Fecha;
                            cmd1.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = factura.Identidad;
                            cmd1.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 20).Value = factura.CodigoUsuario;
                            cmd1.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = factura.ISV;
                            cmd1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = factura.Descuento;
                            cmd1.Parameters.Add("@TotalAPagar", MySqlDbType.Decimal).Value = factura.TotalAPagar;
                            idFactura = Convert.ToInt32(cmd1.ExecuteScalar());
                        }

                        foreach (DetalleFactura detalle in detalles)
                        {
                            using (MySqlCommand cmd2 = new MySqlCommand(sqlDetalle.ToString(), con, transaction))
                            {
                                cmd2.CommandType = System.Data.CommandType.Text;
                                cmd2.Parameters.Add("@IdFactura", MySqlDbType.Int32).Value = idFactura;

                                cmd2.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = detalle.precio;

                                cmd2.ExecuteNonQuery();
                            }

                        }

                        transaction.Commit();
                        inserto = true;
                    }
                    catch (System.Exception)
                    {
                        inserto = false;
                        transaction.Rollback();
                    }
                }
            }
            catch (System.Exception)
            {
            }
            return inserto;
        }
    }
}
