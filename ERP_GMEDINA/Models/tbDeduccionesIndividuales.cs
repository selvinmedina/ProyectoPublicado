//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDeduccionesIndividuales
    {
        public int dei_IdDeduccionesIndividuales { get; set; }
        public string dei_Motivo { get; set; }
        public int emp_Id { get; set; }
        public Nullable<decimal> dei_MontoInicial { get; set; }
        public Nullable<decimal> dei_MontoRestante { get; set; }
        public Nullable<decimal> dei_Cuota { get; set; }
        public Nullable<bool> dei_PagaSiempre { get; set; }
        public Nullable<bool> dei_Pagado { get; set; }
        public int dei_UsuarioCrea { get; set; }
        public System.DateTime dei_FechaCrea { get; set; }
        public Nullable<int> dei_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> dei_FechaModifica { get; set; }
        public bool dei_Activo { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
    }
}
