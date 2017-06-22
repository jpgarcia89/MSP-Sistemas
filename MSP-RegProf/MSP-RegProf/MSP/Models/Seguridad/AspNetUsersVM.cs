using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MSP_RegProf.Models.Seguridad
{
    [MetadataType(typeof(AspNetUsersMetadata))]
    public partial class AspNetUsers
    {
    }

    public class AspNetUsersMetadata
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido.")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido.")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(50, MinimumLength = 10)]
        public string Password { get; set; }
    }
}