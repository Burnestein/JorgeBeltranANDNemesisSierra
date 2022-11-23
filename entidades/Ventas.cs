using System;

namespace JorgeBeltranANDNemesisSierra.entidades
{
    public class Ventas
    {
        private int idventas;
        private int cantidad;
        private int precio;
        private int total;
        private String producto;
        private String fechaVenta;
        private String nomCliente;
        private String usuario;

        public int Idventas { get => idventas; set => idventas = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Total { get => total; set => total = value; }
        public string Producto { get => producto; set => producto = value; }
        public string FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public string NomCliente { get => nomCliente; set => nomCliente = value; }
        public string Usuario { get => usuario; set => usuario = value; }
    }
}
