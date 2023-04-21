namespace EntityModelFirts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sueldo")]
    public partial class sueldo
    {
        [Key]
        public int id_sueldo { get; set; }

        public int id_trabajador { get; set; }

        public int id_puesto { get; set; }

        [Column("sueldo")]
        public double sueldo1 { get; set; }

        public virtual trabajador trabajador { get; set; }
    }
}
