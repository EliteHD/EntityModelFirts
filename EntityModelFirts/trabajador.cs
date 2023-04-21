namespace EntityModelFirts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("trabajador")]
    public partial class trabajador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trabajador()
        {
            pagos = new HashSet<pagos>();
            sueldo = new HashSet<sueldo>();
        }

        [Key]
        public int id_trabajador { get; set; }

        [Required]
        [StringLength(45)]
        public string nombre { get; set; }

        [Required]
        [StringLength(45)]
        public string apellido_pat { get; set; }

        [Required]
        [StringLength(45)]
        public string apellido_mat { get; set; }

        [Required]
        [StringLength(45)]
        public string direccion { get; set; }

        [Required]
        [StringLength(45)]
        public string telefono { get; set; }

        public int num_empleado { get; set; }

        public int id_usuario { get; set; }

        public int id_puesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pagos> pagos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sueldo> sueldo { get; set; }
    }
}
