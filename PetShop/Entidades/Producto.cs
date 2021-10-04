using Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public static int PrevId;
        int id;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        static Producto()
        {
            PrevId = 0;
        }

        static List<Producto> listaProductos;
        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }

        ETipoProducto tipoProducto;
        public ETipoProducto TipoProducto
        {
            get { return this.tipoProducto; }
            set { this.tipoProducto = value; }
        }

        public Producto(ETipoProducto tipo)
        {
            this.Id = ++PrevId;
            PrevId = this.Id;
            this.tipoProducto = tipo;
        }

        public static List<Producto> operator +(List<Producto> productos, Producto producto)
        {
            if (!(productos is null) && !(producto is null))
            {
                foreach (Producto p in productos)
                {
                    if (p == producto)
                        return productos;
                }
                productos.Add(producto);
            }

            return productos;
        }
        public static List<Producto> operator -(List<Producto> productos, Producto producto)
        {
            if (!(productos is null) && !(producto is null))
            {
                foreach (Producto p in productos)
                {
                    if (p == producto)
                    {
                        productos.Remove(p);
                        break;
                    }
                }
            }
            return productos;
        }
    }
}
