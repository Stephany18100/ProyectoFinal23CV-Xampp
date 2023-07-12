using Microsoft.EntityFrameworkCore.Migrations.Operations;
using ProyectoFinal23CV.Context;
using ProyectoFinal23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal23CV.Services
{
   public class UsuarioServices
    {
        public void AddUser (Usuario request) 
        {
            try
            {
                if (request != null)
                {
                    using (var _context = new ApplicationDBContex())
                    {
                        Usuario res = new Usuario();
                        res.Nombre = request.Nombre;
                        res.UserName = request.UserName;
                        res.Password = request.Password;
                        //res.FKRol = resquest.FKROl; 

                        _context.Usuarios.Add(res);
                        _context.SaveChanges();



                    }
                }
            }
            catch (Exception ex )
            {

                throw new Exception ("Succedio un error"+ex.Message);
            }
            
            
        
        }
        public List<Usuario> GetUser() 
        {
            try
            {
                using (var _context = new ApplicationDBContex())
                {
                    List<Usuario> usuarios = new List<Usuario>();
                    usuarios = _context.Usuarios.ToList();
                    return usuarios;

                }

            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error" + ex.Message);
            }



        }
    }
}
