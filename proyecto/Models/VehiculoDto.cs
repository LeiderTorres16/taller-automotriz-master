using System;
using Entidad;


namespace CitaCliente.Models
{   
    public class VehiculoInputModel
    {
        public string Placa { get; set; }
        public string ClienteId { get; set; }
        public ClienteInputModel Cliente { get; set; } = new ClienteInputModel();
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public VehiculoInputModel()
        {
            
        }

    }

    public class SoloVehiculoInputModel
    {
        public string Placa { get; set; }
        public string ClienteId { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public SoloVehiculoInputModel()
        {
            
        }

    }
     

    public class VehiculoViewModel:SoloVehiculoInputModel
    {

        public VehiculoViewModel(Vehiculo vehiculo)
        {
            Placa=vehiculo.Placa;
            ClienteId=vehiculo.ClienteId;
            Tipo=vehiculo.Tipo;
            Modelo=vehiculo.Modelo;
            Color=vehiculo.Color;
            Marca=vehiculo.Marca;
            
        }


    }

}