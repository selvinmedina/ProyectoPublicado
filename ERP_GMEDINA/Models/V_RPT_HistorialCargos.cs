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
    
    public partial class V_RPT_HistorialCargos
    {
        public int hcar_Id { get; set; }
        public string Nombre { get; set; }
        public string Identidad { get; set; }
        public string CargoAnterior { get; set; }
        public int car_Id { get; set; }
        public string CargoNuevo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public int emp_Id { get; set; }
    }
}
