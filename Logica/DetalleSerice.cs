using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidad;

namespace Logica
{
    public class DetalleService
    {

        private readonly TallerContext _context;
        public DetalleService(TallerContext context)
        {
            _context = context;
        }

        public ConsultaDetalleRespuesta ConsultarDetalleClienteIdentificacion(string identificaion)
        {
            try
            {
                //var Cliente = _context.Clientes.Find(identificaion);
                var detalles = _context.Detalles.Where(p=> p.Cliente_ID==identificaion).ToList();
                if (detalles == null)
                {
                    return new ConsultaDetalleRespuesta("No se encontraron Detalles para el cliente solicitado");
                }
                return new ConsultaDetalleRespuesta(detalles);
            }
            catch (Exception e)
            {
                return new ConsultaDetalleRespuesta("Ocurrieron algunos Errores:" + e.Message);
            }
        }


    }

    public class ConsultaDetalleRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Detalle> Detalles { get; set; }

        public ConsultaDetalleRespuesta(List<Detalle> detalles)
        {
             Detalles = detalles;
            Error = false;
        }

        public ConsultaDetalleRespuesta(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }


    public class BusquedaDetalleRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Detalle detalle { get; set; }
    }



    public class ConteoDetalleRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}