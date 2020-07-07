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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Factura_Encabezado = new HashSet<Factura_Encabezado>();
            this.Vehiculo_Cliente = new HashSet<Vehiculo_Cliente>();
        }
    
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int Id_Provincia { get; set; }
        public int Id_Canton { get; set; }
        public int Id_Distrito { get; set; }
        public string Direccion_Fisica { get; set; }
        public int Telefono { get; set; }
        public string Correo_Electronico { get; set; }
    
        public virtual Cantones Cantones { get; set; }
        public virtual Distritos Distritos { get; set; }
        public virtual Provincias Provincias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura_Encabezado> Factura_Encabezado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo_Cliente> Vehiculo_Cliente { get; set; }
    }
}
