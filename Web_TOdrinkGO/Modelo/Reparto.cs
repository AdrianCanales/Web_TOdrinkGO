//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_TOdrinkGO.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reparto
    {
        public int id_reparto { get; set; }
        public Nullable<int> venta { get; set; }
        public Nullable<int> estado { get; set; }
        public string cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> Repartidor { get; set; }
    
        public virtual EstadoR EstadoR { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual Venta Venta1 { get; set; }
    }
}
