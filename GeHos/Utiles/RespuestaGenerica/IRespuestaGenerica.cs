using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles.RespuestaGenerica
{
    public interface IRespuestaGenerica
    {
        bool Ok { set; get; }

        string Mensaje { set; get; }

        string UltimoIdInsertado { set; get; }
    }
}
