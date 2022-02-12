namespace Web_Persona.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pago")]
    public partial class Pago
    {
        [Key]
        public int IdPago { get; set; }

        public int IdPersona { get; set; }

        public DateTime FechadePago { get; set; }

        [Column(TypeName = "money")]
        public decimal Monto { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
