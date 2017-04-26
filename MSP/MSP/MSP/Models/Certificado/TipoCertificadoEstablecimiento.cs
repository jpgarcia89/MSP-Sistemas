using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSP.Models
{
    public class TipoCertificadoEstablecimientoVM
    {
        public int Id { get; set; }

        public string Denominacion { get; set; }

        public int IdTipoCertificado { get; set; }
    }
}