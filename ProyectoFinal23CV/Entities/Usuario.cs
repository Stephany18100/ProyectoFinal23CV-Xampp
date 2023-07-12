using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal23CV.Entities
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }
        public string Nombre { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
       
        [ForeignKey("Roles")] 
        
        public int? FKRol { get; set; } //Cuando se pone ? es un dato no requerido

        public Rol Roles { get; set; }


    }
}
