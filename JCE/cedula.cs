//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JCE
{
    using System;
    using System.Collections.Generic;
    
    public partial class cedula
    {
        public System.Guid UniqueID { get; set; }
        public string cedula_id { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public Nullable<bool> sexo { get; set; }
        public string sangre { get; set; }
        public Nullable<int> estado_civil { get; set; }
        public Nullable<System.DateTime> fecha_expiracion { get; set; }
        public string direccion { get; set; }
        public Nullable<int> nacionalidad_id { get; set; }
        public Nullable<int> colegio_id { get; set; }
        public Nullable<int> ocupacion_id { get; set; }
    
        public virtual Colegio Colegio { get; set; }
        public virtual nacionalidad nacionalidad { get; set; }
        public virtual ocupacion ocupacion { get; set; }
    }
}
