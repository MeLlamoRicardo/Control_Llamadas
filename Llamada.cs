//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Control_Llamadas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Llamada
    {
        public int ID_Llamada { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public string Fecha { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }
        public string Tiempo_Total { get; set; }
        public int ID_Dia { get; set; }
    }
}
