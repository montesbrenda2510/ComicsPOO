using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComicsPOO.Entidades.Entidades
{
    public class Producto
    {
        public Guid codigo  { get; set; }
        public string decripcion { get; set; }
        public decimal precio { get; set; }
        public  int stock { get; set; }

        public Producto(string Descripcion, decimal Precio, int Stock)
        {
            codigo = Guid.NewGuid();
            decripcion=Descripcion;
            precio = Precio;    
            stock=Stock;    
        }
        public string? Descripcion
        {
            get { return decripcion; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    decripcion = value;
                }
                else
                {
                    throw new ArgumentException("La descripcion es requerida");
                }
            }
        }
        public decimal Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
                else { throw new ArgumentException("El precio tiene que ser mayor que cero"); }
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value > 0)
                {
                    stock = value;
                }
                else { throw new ArgumentException("El stock tiene que ser mayor que cero"); }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Descripcion: {decripcion}");
            sb.AppendLine($"Codigo: {codigo}");
            sb.AppendLine($"Precio: ${precio}");
            sb.AppendLine($"Stock: {stock} unidades");
            return sb.ToString();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Producto p)
            {
                return string.Equals(codigo, p.codigo);
            }
            return false;
        }



    }
}
