using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Car_Project.Clases
{
    internal class Carro
    {
        public string Marca = "";
        public string Modelo = "";
        public int AñoModelo;
        public int Precio_Compra;
        public int Precio_venta;
        public string Tipo = "";
        public string Exposición = "";
        public string Proveedor = "";
        public string NecesitaReparación = "";
        public string Estado = "";

        public Carro(string marca, string modelo, int añoModelo, int precio_Compra, int precio_venta, string tipo, string exposición, string proveedor, string necesitaReparación, string estado)
        {
            Marca = marca;
            Modelo = modelo;
            AñoModelo = añoModelo;
            Precio_Compra = precio_Compra;
            Precio_venta = precio_venta;
            Tipo = tipo;
            Exposición = exposición;
            Proveedor = proveedor;
            NecesitaReparación = necesitaReparación;
            Estado = estado;
        }
    }
}
