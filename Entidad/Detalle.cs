using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Detalle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Id_Servicio { get; set; }
        public double ValorUnitario { get; set; }
        public string Cliente_ID { get; set; }
        public Cliente cliente { get; set; }
        public Servicio Servicio { get; set; }


    }
}