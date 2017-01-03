using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Utiles.RespuestaGenerica
{
    public class RespuestaGenerica : IRespuestaGenerica
    {
        [ScaffoldColumn(false)]
        public bool Ok { set; get; }
        [ScaffoldColumn(false)]
        public string Mensaje { set; get; }

        public string TipoRespuesta
        {
            get { return this.GetType().AssemblyQualifiedName; }
        }
        [ScaffoldColumn(false)]
        public string JSON { set; get; }
        [ScaffoldColumn(false)]
        public int NroDeEntidadesModificadas { set; get; }
        [ScaffoldColumn(false)]
        public string UltimoIdInsertado { set; get; }
        [ScaffoldColumn(false)]
        public string UltimoIDObtenido { set; get; }
        [ScaffoldColumn(false)]
        public string Usuario { get; set; }
    }
}
