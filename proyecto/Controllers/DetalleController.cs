using System.Linq;
using System;
using Logica;
using Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Entidad;
using DetalleCliente.Models;

namespace DetalleCliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DetalleController : ControllerBase
    {
        private DetalleService detalleservice;

        public DetalleController(TallerContext context)
        {
            detalleservice = new DetalleService(context);
            
        }

        //[HttpPost]
        /*public ActionResult<DetalleClienteViewModel> GuardarDetalle(DetalleClienteInputModel soloDetalleClienteInputModel)
        {
            var cita = MapearDetalle(soloDetalleClienteInputModel);
            var response = citaService.GuardarCita(cita);
            if (!response.Error)
            {
                return Ok(new CitaViewModel(cita));
            }
            return BadRequest(response.Mensaje);

        }*/

         private Detalle MapearCita(DetalleClienteInputModel detalleClienteInputModel)
        {
           var detalle= new Detalle()
           {
              /*ClienteId=citaInputModel.Cliente.Identificacion,
              Cliente=new Cliente{Identificacion=citaInputModel.Cliente.Identificacion, 
              Nombre=citaInputModel.Cliente.Nombre,Apellido=citaInputModel.Cliente.Apellido,Edad=citaInputModel.Cliente.Edad,
              Telefono=citaInputModel.Cliente.Telefono,Sexo=citaInputModel.Cliente.Sexo},
              Vehiculo = new Vehiculo{Placa=citaInputModel.Vehiculo.Placa,ClienteId=citaInputModel.Vehiculo.ClienteId,
              Tipo=citaInputModel.Vehiculo.Tipo, Modelo=citaInputModel.Vehiculo.Modelo,Color=citaInputModel.Vehiculo.Color,
              Marca=citaInputModel.Vehiculo.Marca},
              fecha=citaInputModel.fecha*/
              Cliente_ID=detalleClienteInputModel.Cliente_ID,
              
           };
           return detalle;   

        }


    }



}


