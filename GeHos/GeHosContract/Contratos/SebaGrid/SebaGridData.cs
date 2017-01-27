/************************************************************************************************************
 * Descripción: Clase catPersonaVM.
 * Observaciones: 
 * Creado por: MC.
 * Historial de Revisiones:
 * -----------------------------------------------------------------------------------------------
 * Fecha        Evento / Método Autor   Descripción
 * -----------------------------------------------------------------------------------------------
 * 28/12/2016					Implementación inicial.
 * -----------------------------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Utiles.ContratoBase;

namespace GeHosContract.Contrato
{
    public class SebaGridData
    {
        public List<info> info { get; set; }
        public object values { get; set; }
    }


    public class info
    {
        public int rows { get; set; }
        public int page { get; set; }
        public int page_count { get; set; }
        public int total_rows { get; set; }
        public int start { get; set; }        
    }
         
   
}
