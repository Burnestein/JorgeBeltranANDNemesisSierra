using System;

namespace JorgeBeltranANDNemesisSierra.entidades
{
    public class Ventas
    {
        private int idventas;
        private String producto;
        private int cantidad;
        private int precio;
        private int subtotal;
        private int iva;
        private int total;

        public int Idventas { get => idventas; set => idventas = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
        public int Iva { get => iva; set => iva = value; }
        public int Total { get => total; set => total = value; }
    }
}
