//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoProgra6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Casa_Fabricante_Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Casa_Fabricante_Vehiculo()
        {
            this.Marca_Vehiculo = new HashSet<Marca_Vehiculo>();
        }
    
        public int Id_Casa_Fabricante { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Id_Pais { get; set; }
    
        public virtual Pais Pais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marca_Vehiculo> Marca_Vehiculo { get; set; }
    }
}
