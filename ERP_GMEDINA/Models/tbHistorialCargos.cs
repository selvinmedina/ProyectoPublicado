//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbHistorialCargos
    {
        public int hcar_Id { get; set; }
        public int emp_Id { get; set; }
        public Nullable<int> car_IdAnterior { get; set; }
        public int car_IdNuevo { get; set; }
        public Nullable<System.DateTime> hcar_Fecha { get; set; }
        public bool hcar_Estado { get; set; }
        public string hcar_RazonInactivo { get; set; }
        public int hcar_UsuarioCrea { get; set; }
        public System.DateTime hcar_FechaCrea { get; set; }
        public Nullable<int> hcar_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> hcar_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbCargos tbCargos { get; set; }
        public virtual tbCargos tbCargos1 { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
    }
}
