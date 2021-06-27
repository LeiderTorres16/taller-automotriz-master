using System;
using System.Collections.Generic;
using Datos;
using Entidad;

namespace Logica
{
    public class CitaService
    {
        private readonly TallerContext _context;
        public CitaService(TallerContext context)
        {
            _context = context;
        }

         public GuardarCitaResponse GuardarCita(Cita cita)
        {
            try
            {
                

                var cliente = _context.Clientes.Find(cita.Cliente.Identificacion);
                var vehiculo = _context.Vehiculos.Find(cita.Vehiculo.Placa);
                if(cliente == null){
                    _context.Clientes.Add(cita.Cliente);
                }else{
                     cita.Cliente=cliente;
                }

                if(vehiculo==null)
                    {
                        _context.Vehiculos.Add(cita.Vehiculo);

                    }else{
                        cita.Vehiculo=vehiculo;
                    }
                
               
                
                _context.Citas.Add(cita);
                _context.SaveChanges();

                return new GuardarCitaResponse(cita);
            }
            catch (Exception e)
            {
                return new GuardarCitaResponse("Ocurrieron algunos Errores:" + e.Message);
            }
        }
    }
    public class GuardarCitaResponse
    {
        public Cita Cita { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }


        public GuardarCitaResponse(Cita cita)
        {
            Cita = cita;
            Error = false;
        }

        public GuardarCitaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
      public class ConsultaCitaResponse
    {
        public List<Cita> Citas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }


        public ConsultaCitaResponse(List<Cita> citas)
        {
            Citas = citas;
            Error = false;
        }

        public ConsultaCitaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}
