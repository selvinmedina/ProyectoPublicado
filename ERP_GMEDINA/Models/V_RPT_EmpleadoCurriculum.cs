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
    
    public partial class V_RPT_EmpleadoCurriculum
    {
        public Nullable<int> per_Id { get; set; }
        public int emp_Id { get; set; }
        public string Nombre { get; set; }
        public string Identidad { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Direccion { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public string Estado_Civil { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Correo_Electronico { get; set; }
        public string Tipo_Sangre { get; set; }
        public Nullable<int> hape_Id { get; set; }
        public Nullable<int> cope_Id { get; set; }
        public Nullable<int> habi_Id { get; set; }
        public Nullable<int> comp_Id { get; set; }
        public string Habilidades { get; set; }
        public string Competencias { get; set; }
    }
}