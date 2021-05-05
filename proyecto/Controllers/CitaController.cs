using System.Linq;
using System;
using Logica;
using Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using CitaCliente.Models;
using Entidad;

namespace CitaCliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CitaController : ControllerBase
    {
        private CitaService citaService;

        public CitaController(TallerContext context)
        {
            citaService = new CitaService(context);
        }

        [HttpPost]
        public ActionResult<CitaViewModel> GuardarCita(CitaInputModel citaInputModel)
        {
            var cita = MapearCita(citaInputModel);
            var response = citaService.GuardarCita(cita);
            if (!response.Error)
            {
                return Ok(new CitaViewModel(cita));
            }
            return BadRequest(response.Mensaje);

        }


        private Cita MapearCita(CitaInputModel citaInputModel)
        {
           var cita= new Cita()
           {
              ClienteId=citaInputModel.Cliente.Identificacion,
              Cliente=new Cliente{Identificacion=citaInputModel.Cliente.Identificacion, 
              Nombre=citaInputModel.Cliente.Nombre,Apellido=citaInputModel.Cliente.Apellido,Edad=citaInputModel.Cliente.Edad,
              Telefono=citaInputModel.Cliente.Telefono,Sexo=citaInputModel.Cliente.Sexo},
              Vehiculo = new Vehiculo{Placa=citaInputModel.Vehiculo.Placa,ClienteId=citaInputModel.Vehiculo.ClienteId,
              Tipo=citaInputModel.Vehiculo.Tipo, Modelo=citaInputModel.Vehiculo.Modelo,Color=citaInputModel.Vehiculo.Color,
              Marca=citaInputModel.Vehiculo.Marca},
              fecha=citaInputModel.fecha
           };
           return cita;   

        }


    }
}