using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Merkur.BL
{
    public class DatosdeIncio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            //Usurios

            var Admin = new Usuarios();
            Admin.Nombre = "Admin";
            Admin.Contrasena = "123";
            contexto.Usuarios.Add(Admin);

            var User = new Usuarios();
            User.Nombre = "Jeffry";
            User.Contrasena = "456";
            contexto.Usuarios.Add(User);

            var User1 = new Usuarios();
            User1.Nombre = "Orlando";
            User1.Contrasena = "789";
            contexto.Usuarios.Add(User1);

            //Categorias

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Fragil";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Pesado";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Documentacion";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Peligroso";
            contexto.Categorias.Add(categoria4);

            //Tipos de envios

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Urgente";
            contexto.Tipo.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "No Urgente";
            contexto.Tipo.Add(tipo2);

            //Clientes

            var clientes = new Cliente();
            
            clientes.Nombres = "Orlando";
            clientes.Apellidos = "Garcia";
            clientes.Cedula = "0502-1999-01495";
            clientes.Email = "FuentesGarcia197@gmail.com";
            clientes.Telefono = "97681994";         
            contexto.Cliente.Add(clientes);


            var clientes2 = new Cliente();
            
            clientes2.Nombres = "Ronaldo";
            clientes2.Apellidos = "Zelaya";
            clientes2.Cedula = "1602-1997-01458";
            clientes2.Email = "FreddyZelaya@gmail.com";
            clientes2.Telefono = "95658745";
            contexto.Cliente.Add(clientes2);

            //paquetes(productos)

            var producto1 = new Producto();
            producto1.Activo = true;
            producto1.Descripcion = "paquete1";
            producto1.Destino = "Colón";
            producto1.Tipo = tipo1;
            producto1.Categorias = categoria3;
            producto1.FechadeEntrega = DateTime.Now;
            producto1.Precio = 150;
            contexto.Productos.Add(producto1);

            //Departamentos

            var departamento = new Departamento();
            departamento.Descripcion = "Atlántida";
            contexto.Departamento.Add(departamento);

            var departamento1 = new Departamento();
            departamento1.Descripcion = "Choluteca";
            contexto.Departamento.Add(departamento1);

            var departamento2 = new Departamento();
            departamento2.Descripcion = "Colón";
            contexto.Departamento.Add(departamento2);

            var departamento3 = new Departamento();
            departamento3.Descripcion = "Comayagua";
            contexto.Departamento.Add(departamento3);

            var departamento4 = new Departamento();
            departamento4.Descripcion = "Copán";
            contexto.Departamento.Add(departamento4);

            var departamento5 = new Departamento();
            departamento5.Descripcion = "Cortes";
            contexto.Departamento.Add(departamento5);

            var departamento6 = new Departamento();
            departamento2.Descripcion = "El Paraíso";
            contexto.Departamento.Add(departamento2);

            var departamento7 = new Departamento();
            departamento7.Descripcion = "Francisco Morazán";
            contexto.Departamento.Add(departamento7);

            var departamento8 = new Departamento();
            departamento8.Descripcion = "Gracias a Dios";
            contexto.Departamento.Add(departamento8);

            var departamento9 = new Departamento();
            departamento9.Descripcion = "Intibucá";
            contexto.Departamento.Add(departamento9);

            var departamento10 = new Departamento();
            departamento10.Descripcion = "Islas de la Bahía";
            contexto.Departamento.Add(departamento10);

            var departamento11 = new Departamento();
            departamento11.Descripcion = "La Paz";
            contexto.Departamento.Add(departamento11);

            var departamento12 = new Departamento();
            departamento12.Descripcion = "Lempira";
            contexto.Departamento.Add(departamento12);

            var departamento13 = new Departamento();
            departamento13.Descripcion = "Ocotepeque";
            contexto.Departamento.Add(departamento13);

            var departamento14 = new Departamento();
            departamento14.Descripcion = "Olancho";
            contexto.Departamento.Add(departamento14);

            var departamento15 = new Departamento();
            departamento15.Descripcion = "Santa Bárbara";
            contexto.Departamento.Add(departamento15);

            var departamento16 = new Departamento();
            departamento16.Descripcion = "Valle";
            contexto.Departamento.Add(departamento16);

            var departamento17 = new Departamento();
            departamento17.Descripcion = "Yoro";
            contexto.Departamento.Add(departamento17);

            //Munipicios 18/298 municipios

            var muni = new Municipio();
            muni.Descripcion = "La ceiba";
            contexto.Municipio.Add(muni);

            var muni1 = new Municipio();
            muni1.Descripcion = "Choluteca";
            contexto.Municipio.Add(muni1);

            var muni2 = new Municipio();
            muni2.Descripcion = "Trujillo";
            contexto.Municipio.Add(muni2);

            var muni3 = new Municipio();
            muni3.Descripcion = "Comayagua";
            contexto.Municipio.Add(muni3);

            var muni4 = new Municipio();
            muni4.Descripcion = "Santa Rosa de Copán";
            contexto.Municipio.Add(muni4);

            var muni5 = new Municipio();
            muni5.Descripcion = "San Pedro de Sula";
            contexto.Municipio.Add(muni5);

            var muni6 = new Municipio();
            muni6.Descripcion = "Yuscarán";
            contexto.Municipio.Add(muni6);

            var muni7 = new Municipio();
            muni7.Descripcion = "Tegucigalpa";
            contexto.Municipio.Add(muni7);

            var muni8 = new Municipio();
            muni8.Descripcion = "Puerto Lempira";
            contexto.Municipio.Add(muni8);

            var muni9 = new Municipio();
            muni9.Descripcion = "La Esperanza";
            contexto.Municipio.Add(muni9);

            var muni10 = new Municipio();
            muni10.Descripcion = "Roatán";
            contexto.Municipio.Add(muni10);

            var muni11 = new Municipio();
            muni11.Descripcion = "Gracias";
            contexto.Municipio.Add(muni11);

            var muni12 = new Municipio();
            muni12.Descripcion = "La Paz";
            contexto.Municipio.Add(muni12);

            var muni13 = new Municipio();
            muni13.Descripcion = "Nuevo Ocotepeque";
            contexto.Municipio.Add(muni13);

            var muni14 = new Municipio();
            muni14.Descripcion = "Juticalpa";
            contexto.Municipio.Add(muni14);

            var muni15 = new Municipio();
            muni15.Descripcion = "Santa Bárbara";
            contexto.Municipio.Add(muni15);

            var muni16 = new Municipio();
            muni16.Descripcion = "Nacaome";
            contexto.Municipio.Add(muni16);

            var muni17 = new Municipio();
            muni17.Descripcion = "Yoro";
            contexto.Municipio.Add(muni17);







            base.Seed(contexto);
        }
    }
}
