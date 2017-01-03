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
    public class CentroDeSaludVM : ContratoBase
    {
        #region Atributos
        int AID;
        string ACodigo;
        string ANombre;
        int ADepartamentoID;
        string ADepartamento;
        #endregion Atributos

        #region Propiedades - Get/Set

        [ScaffoldColumn(false)]
        public int ID
        {
            get { return AID; }
            set { AID = value; }
        }

        [DisplayName("Codigo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo Código no puede estar vacío.")]
        public string Codigo
        {
            get { return ACodigo; }
            set { ACodigo = value; }
        }

        [DisplayName("Nombre")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="El campo Nombre no puede estar vacío.")]
        public string Nombre
        {
            get { return ANombre; }
            set { ANombre = value; }
        }

        [ScaffoldColumn(false)]
        public int DepartamentoID
        {
            get { return ADepartamentoID; }
            set { ADepartamentoID = value; }
        }

        [ScaffoldColumn(false)]
        public string Departamento
        {
            get { return ADepartamento; }
            set { ADepartamento = value; }
        }

        #endregion Propiedaddes - Get/Set
    }
}
