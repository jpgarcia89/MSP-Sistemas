/************************************************************************************************************
 * Descripción: Clase catEspecialidadVM.
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
using System.ComponentModel.DataAnnotations;

namespace GeHosContract.Contrato
{
    public class EspecialidadVM : ContratoBase
    {
        #region Atributos
        int AID;
        string ANombre;
        int? AIdPadre;
        string ACodigo;
        string ADescripcionPlanilla;
        string AAbreviatura;
        int AIdMHO;
        #endregion Atributos

        #region Propiedades - Get/Set
        [ScaffoldColumn(false)]
        public int ID
        {
            get { return AID; }
            set { AID = value; }
        }

        [ScaffoldColumn(true)]
        [DisplayName("Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo Nombre no puede estar vacío.")]
        public string Nombre
        {
            get { return ANombre; }
            set { ANombre = value; }
        }
        [ScaffoldColumn(false)]
        public int? IdPadre
        {
            get { return AIdPadre; }
            set { AIdPadre = value; }
        }

        [ScaffoldColumn(true)]
        public string Codigo
        {
            get { return ACodigo; }
            set { ACodigo = value; }
        }

        [ScaffoldColumn(true)]
        public string DescripcionPlanilla
        {
            get { return ADescripcionPlanilla; }
            set { ADescripcionPlanilla = value; }
        }

        [ScaffoldColumn(true)]
        public string Abreviatura
        {
            get { return AAbreviatura; }
            set { AAbreviatura = value; }
        }

        [ScaffoldColumn(false)]
        public int IdMHO
        {
            get { return AIdMHO; }
            set { AIdMHO = value; }
        }

        #endregion Propiedaddes - Get/Set

    }
}
