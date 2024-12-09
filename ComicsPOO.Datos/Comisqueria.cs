using ComicsPOO.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsPOO.Datos
{
    public class Comisqueria
    {
        private List<Producto> producto;
        private string? nombre;
        private readonly Serializador? serializador;

        private Comisqueria()
        {
            producto = new List<Producto>();
            serializador = new Serializador();
            producto = serializador.LeerDatos();

        }
        public bool Existe(Producto producto)
        {
            return 

        }
    }
}
