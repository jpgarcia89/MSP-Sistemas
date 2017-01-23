using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utiles.ContratoBase;

namespace GeHosContract.Contrato
{
    public class TipoAgendaDeProfesionalesVM : ContratoBase
    {
        #region Atributos
        int AID;
        string ANombre;
        bool AActiva;
        #endregion Atributos

        #region Propiedades - Get/Set

        [ScaffoldColumn(false)]
        public int ID
        {
            get { return AID; }
            set { AID = value; }
        }

        

        [DisplayName("Nombre")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="El campo Nombre no puede estar vacío.")]
        public string Nombre
        {
            get { return ANombre; }
            set { ANombre = value; }
        }

        

        [ScaffoldColumn(false)]
        public bool Activa
        {
            get { return AActiva; }
            set { AActiva = value; }
        }

        #endregion Propiedaddes - Get/Set
    }
}
