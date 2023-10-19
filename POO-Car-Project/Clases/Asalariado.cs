using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Car_Project.Clases
{
    internal class Asalariado : Empleado
    {
        private double Comision;

        public Asalariado(double comision, string nombre, string iD, int edad, int numeroCarrosVendidos)
            : base(nombre, iD, edad, numeroCarrosVendidos)
        {   
            Comision = comision;
        }

        public override void vender()
        {
            throw new NotImplementedException();
        }

    }
}
