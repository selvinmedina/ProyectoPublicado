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
    
    public partial class tbHistorialDePago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbHistorialDePago()
        {
            this.tbHistorialDeduccionPago = new HashSet<tbHistorialDeduccionPago>();
            this.tbHistorialDeIngresosPago = new HashSet<tbHistorialDeIngresosPago>();
        }
    
        public int hipa_IdHistorialDePago { get; set; }
        public int emp_Id { get; set; }
        public Nullable<decimal> hipa_SueldoNeto { get; set; }
        public System.DateTime hipa_FechaInicio { get; set; }
        public System.DateTime hipa_FechaFin { get; set; }
        public System.DateTime hipa_FechaPago { get; set; }
        public int hipa_Anio { get; set; }
        public int hipa_Mes { get; set; }
        public int peri_IdPeriodo { get; set; }
        public int hipa_UsuarioCrea { get; set; }
        public System.DateTime hipa_FechaCrea { get; set; }
        public Nullable<int> hipa_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> hipa_FechaModifica { get; set; }
        public decimal hipa_TotalISR { get; set; }
        public Nullable<bool> hipa_ISRPendiente { get; set; }
        public decimal hipa_AFP { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbPeriodos tbPeriodos { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialDeduccionPago> tbHistorialDeduccionPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialDeIngresosPago> tbHistorialDeIngresosPago { get; set; }
    }
}
