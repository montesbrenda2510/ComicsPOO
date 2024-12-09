using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsPOO.Entidades.Entidades
{
    public class Comic : Producto
    {
        public string autor;
        public TipodeComic tipodeComic { get; set; }
        public string? Autor
        {
            get { return autor; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    autor = value;
                }
                else
                {
                    throw new ArgumentException("El autor es requerido");
                }
            }
        }

        
        public Comic(string Descripcion, decimal Precio, int Stock, string Autor,TipodeComic tipodecomic ) 
            : base(Descripcion, Precio, Stock)
        {
            autor= Autor;
            tipodeComic = tipodecomic;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Autor: {autor}");
            sb.AppendLine($"Tipo de comic: {tipodeComic}"); 
            return sb.ToString();
        }
    }
}
