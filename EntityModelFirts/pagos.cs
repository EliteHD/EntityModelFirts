namespace EntityModelFirts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pagos
    {
        [Key]
        public int id_pagos { get; set; }

        public int id_trabajador { get; set; }

        public int id_puesto { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechapago { get; set; }

        public int semanas { get; set; }

        public double montopago { get; set; }

        public virtual puesto puesto { get; set; }

        public virtual trabajador trabajador { get; set; }
    }
}
