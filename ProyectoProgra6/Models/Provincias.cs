//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoProgra6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provincias
    {
        public Provincias()
        {
            this.Cantones = new HashSet<Cantones>();
            this.Cliente = new HashSet<Cliente>();
        }
    
        public int id_provincia { get; set; }
        public string nombre { get; set; }
        public string usuario_creacion { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string usuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_ult_mod { get; set; }
        public string vc_estado { get; set; }
    
        public virtual ICollection<Cantones> Cantones { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
