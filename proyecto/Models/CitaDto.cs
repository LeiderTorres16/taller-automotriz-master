using System;
using Entidad;


namespace CitaCliente.Models
{
    public class CitaInputModel
    {
        public ClienteInputModel Cliente { get; set; }
        public SoloVehiculoInputModel Vehiculo { get; set; }
        
        public DateTime fecha { get; set; }

    }

    public class CitaViewModel : CitaInputModel
    {
        public CitaViewModel(Cita cita)
        {

            Cliente = new ClienteInputModel()
            {
            Identificacion = cita.Cliente.Identificacion,
            Nombre = cita.Cliente.Nombre,
            Apellido = cita.Cliente.Apellido,
            Edad = cita.Cliente.Edad,
            Telefono = cita.Cliente.Telefono,
            Sexo = cita.Cliente.Sexo
            };
            
            Vehiculo = new SoloVehiculoInputModel()
            {
                Placa = cita.Vehiculo.Placa,
                ClienteId = cita.Vehiculo.ClienteId,
                Tipo = cita.Vehiculo.Tipo,
                Modelo = cita.Vehiculo.Modelo,
                Color = cita.Vehiculo.Color,
                Marca = cita.Vehiculo.Marca
            };
            fecha = cita.fecha;
        }



    }



}