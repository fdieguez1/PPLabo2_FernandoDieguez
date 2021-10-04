﻿using Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
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
        public Producto()
        {

        }
    }
}
