using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Car_Project.Clases
{
    internal class Comisionado : Empleado
    {
        private double Comision;

        public Comisionado(double comision, string Nombre, string ID, int Edad, int NumeroCarrosVendidos)
            : base(Nombre, ID, Edad, NumeroCarrosVendidos) 
        {
            Comision = comision;
        }

        public override void vender()
        {
            throw new NotImplementedException();
        }
    }
}
