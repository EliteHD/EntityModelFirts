namespace EntityModelFirts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        public int id { get; set; }

        [StringLength(10)]
        public string usuario { get; set; }

        [StringLength(10)]
        public string passwd { get; set; }

        [StringLength(10)]
        public string estado { get; set; }

        [StringLength(20)]
        public string tipo_usuario { get; set; }
    }
}
