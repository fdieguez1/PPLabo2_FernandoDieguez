using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
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
            throw new NotImplementedException();
        }
    }
}
