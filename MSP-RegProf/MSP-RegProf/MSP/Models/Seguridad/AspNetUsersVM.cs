using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MSP_RegProf.Models
{
    [MetadataType(typeof(AspNetUsersMetadata))]
    public partial class AspNetUsers
    {
    }

    public class AspNetUsersMetadata
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido.")]
        public string Email { get; set; }

        [DisplayName("Nombre de Usuario")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido.")]
        public string UserName { get; set; }

        [DisplayName("Contraseña")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(50, MinimumLength = 10)]
        public string PasswordHash { get; set; }
    }
}