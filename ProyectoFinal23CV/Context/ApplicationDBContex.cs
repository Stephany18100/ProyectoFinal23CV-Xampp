using Microsoft.EntityFrameworkCore;
using ProyectoFinal23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal23CV.Context
{
    public class ApplicationDBContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //aqui va la coneccion con php
            options.UseMySQL("Server= localhost; database= fanyyProyectooodb23cv; user= root; password ="); 
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol>Roles { get; set; }
    }
}
