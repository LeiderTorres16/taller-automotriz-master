using System;
using CitaCliente.Models;
using Entidad;


namespace DetalleCliente.Models
{
    public class DetalleClienteInputModel{

        public string Id_Servicio { get; set; }
        public double ValorUnitario { get; set; }
        public string Cliente_ID { get; set; }
        public ClienteInputModel Cliente { get; set; }
        public ServicioInputModel Servicio { get; set; }

    }


    public class DetalleClienteViewModel: DetalleClienteInputModel
    {
        public DetalleClienteViewModel(Detalle detalle)
        {
            Id_Servicio = detalle.Id_Servicio;
            ValorUnitario = detalle.ValorUnitario;
            Cliente_ID = detalle.Cliente_ID;

            Cliente= new ClienteInputModel()
            {
                Identificacion = detalle.cliente.Identificacion,
                Nombre = detalle.cliente.Nombre,
                Apellido= detalle.cliente.Apellido,
                Edad = detalle.cliente.Edad,
                Telefono = detalle.cliente.Telefono,
                Sexo = detalle.cliente.Sexo

            };

            Servicio = new ServicioInputModel()
            {
                Nombre = detalle.Servicio.Nombre,
                Precio= detalle.Servicio.Precio

            };

            
        }

        
    }

}