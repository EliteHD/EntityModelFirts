namespace EntityModelFirts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("puesto")]
    public partial class puesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public puesto()
        {
            pagos = new HashSet<pagos>();
        }

        [Key]
        public int id_puesto { get; set; }

        [Column("puesto")]
        [Required]
        [StringLength(45)]
        public string puesto1 { get; set; }

        [Required]
        [StringLength(45)]
        public string cargo { get; set; }

        [Required]
        [StringLength(45)]
        public string tareas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pagos> pagos { get; set; }
    }
}
