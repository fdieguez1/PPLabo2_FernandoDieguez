using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0661 
    public class Cliente : Persona
#pragma warning restore CS0661 
    {
        double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                this.saldo = value;
            }
        }


        public Cliente(string nombre, string apellido, double saldo, double cuil) : base(nombre, apellido, cuil)
        {
            this.Saldo = saldo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Saldo: {this.Saldo.ToString()}");
            return sb.ToString();
        }
        public static bool operator +(List<Cliente> listaClientes, Cliente cliente)
        {
            bool altaOk = false;
            if (Empleado.CantidadMaximaClientes > listaClientes.Count)
            {
                foreach (Cliente clt in listaClientes)
                {
                    if (clt == cliente)
                    {
                        return false;
                    }
                }
                listaClientes.Add(cliente);
                altaOk = true;
            }
            return altaOk;
        }
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1.Usuario == cliente2.Usuario)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }
    }
}
