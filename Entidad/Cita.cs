using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Cita
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; } 
        public string ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        
        public Vehiculo Vehiculo { get; set; }
        //public List<Servicio> servicios { get; set;} 
        public DateTime fecha { get; set;}
    }
}
