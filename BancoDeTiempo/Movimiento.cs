//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoDeTiempo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movimiento
    {
        public string id_movimiento { get; set; }
        public string usuario_origen { get; set; }
        public string usuario_destino { get; set; }
        public string concepto { get; set; }
        public string comentarios { get; set; }
        public double horas { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual Servicio servicios { get; set; }
        public virtual Usuario usuarios { get; set; }
        public virtual Usuario usuarios1 { get; set; }
    }
}
