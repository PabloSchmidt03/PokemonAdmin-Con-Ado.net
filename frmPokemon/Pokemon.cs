using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPokemon
{
    internal class Pokemon
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public Tipo Elemento { get; set; }
        public Tipo Debilidad { get; set; }

    }
}
