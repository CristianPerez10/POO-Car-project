using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Car_Project.Clases
{
    internal abstract class Empleado
    {
        public string Nombre = "";
        public string ID = "";
        public int Edad;
        public int NumeroCarrosVendidos;

        protected Empleado(string nombre, string iD, int edad, int numeroCarrosVendidos)
        {
            Nombre = nombre;
            ID = iD;
            Edad = edad;
            NumeroCarrosVendidos = numeroCarrosVendidos;
        }

        public abstract void vender();

    }
}
