using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkur.BL
{
    public class MunicipioBL
    {
        Contexto _contexto;
        public BindingList<Municipio> ListadeMunicipios { get; set; }
        public MunicipioBL()
        {
            _contexto = new Contexto();
            ListadeMunicipios = new BindingList<Municipio>();
        }

        public BindingList<Municipio> ObtenerMunicipio()
        {
            _contexto.Municipio.Load();
            ListadeMunicipios = _contexto.Municipio.Local.ToBindingList();

            return ListadeMunicipios;

        }
    }

    public class Municipio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

}
