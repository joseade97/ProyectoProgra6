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
    
    public partial class Vehiculo_Cliente
    {
        public int Id_Vehiculo_Cliente { get; set; }
        public int Id_Vehiculo { get; set; }
        public int Id_Cliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
