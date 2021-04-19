using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEB.Models;

namespace WEB.Models
{

        public partial class Usuario
        {
            [Key]
            public int ID_usuario { get; set; }         
            public string Nombre_usuario { get; set; }
            [Required]
            [StringLength(200)]
            public string Correo { get; set; }
            [Required]
            [StringLength(15)]
            public string Contraseña { get; set; }
   
        }

    }

