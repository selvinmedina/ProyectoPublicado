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
    
    public partial class tbHistorialAmonestaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbHistorialAmonestaciones()
        {
            this.tbHistorialAmonestaciones1 = new HashSet<tbHistorialAmonestaciones>();
        }
    
        public int hamo_Id { get; set; }
        public int emp_Id { get; set; }
        public int tamo_Id { get; set; }
        public System.DateTime hamo_Fecha { get; set; }
        public Nullable<int> hamo_AmonestacionAnterior { get; set; }
        public string hamo_Observacion { get; set; }
        public bool hamo_Estado { get; set; }
        public string hamo_RazonInactivo { get; set; }
        public int hamo_UsuarioCrea { get; set; }
        public System.DateTime hamo_FechaCrea { get; set; }
        public Nullable<int> hamo_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> hamo_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialAmonestaciones> tbHistorialAmonestaciones1 { get; set; }
        public virtual tbHistorialAmonestaciones tbHistorialAmonestaciones2 { get; set; }
        public virtual tbTipoAmonestaciones tbTipoAmonestaciones { get; set; }
    }
}
