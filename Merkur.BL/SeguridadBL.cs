using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Merkur.BL
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public SeguridadBL()
        {
            _contexto = new Contexto();
        }
        public Usuarios Autenticar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var UsuarioDB in usuarios)
            {
                if (usuario == UsuarioDB.Nombre && contrasena == UsuarioDB.Contrasena)
                {
                    return UsuarioDB;
                }
            }
            return null;

        }
      
    }
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

    }
}
