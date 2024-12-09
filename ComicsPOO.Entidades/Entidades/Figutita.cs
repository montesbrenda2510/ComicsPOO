using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsPOO.Entidades.Entidades
{
    public class Figutita:Producto
    {
        public Figutita(string Descripcion, decimal Precio, int Stock, float Altura) 
            : base(Descripcion, Precio, Stock)
        {
            altura = Altura;
        }

        public float altura;

        public float Altura 
        {
            get
            {
                return altura;
            }
            set
            {
                if (altura>0)
                {

                    altura = value;
                }
                else
                {
                    throw new ArgumentException("La altura es requerida");
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Figura de {altura} cm");
            return sb.ToString();
        }

    }
}
