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
    
    public partial class Marca_Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Marca_Vehiculo()
        {
            this.Modelo_Marca_Vehiculo = new HashSet<Modelo_Marca_Vehiculo>();
        }
    
        public int Id_Marca_Vehiculo { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Id_Casa_Fabricante { get; set; }
    
        public virtual Casa_Fabricante_Vehiculo Casa_Fabricante_Vehiculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Marca_Vehiculo> Modelo_Marca_Vehiculo { get; set; }
    }
}