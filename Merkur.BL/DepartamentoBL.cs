using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkur.BL
{
    public class DepartamentoBL
    {
        Contexto _contexto;
        public BindingList<Departamento> ListadeDepartamentos { get; set; }
        public DepartamentoBL()
        {
            _contexto = new Contexto();
            ListadeDepartamentos = new BindingList<Departamento>();
        }

        public BindingList<Departamento> ObtenerDepartamento()
        {
            _contexto.Departamento.Load();
            ListadeDepartamentos = _contexto.Departamento.Local.ToBindingList();

            return ListadeDepartamentos;

        }
    }

    public class Departamento
    {
    public int Id { get; set; }
    public string Descripcion { get; set; }
}
}
