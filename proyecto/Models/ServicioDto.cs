
using System;
using CitaCliente.Models;
using Entidad;


namespace DetalleCliente.Models
{

    public class ServicioInputModel
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

    }


    public class ServicioViewModel : ServicioInputModel
    {
        public ServicioViewModel(Servicio servicio)
        {
            Nombre=servicio.Nombre;
            Precio=servicio.Precio;
        }

    }




}