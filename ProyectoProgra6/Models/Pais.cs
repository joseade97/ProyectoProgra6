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
    
    public partial class Pais
    {
        public Pais()
        {
            this.Casa_Fabricante_Vehiculo = new HashSet<Casa_Fabricante_Vehiculo>();
        }
    
        public int Id_Pais { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
    
        public virtual ICollection<Casa_Fabricante_Vehiculo> Casa_Fabricante_Vehiculo { get; set; }
    }
}
