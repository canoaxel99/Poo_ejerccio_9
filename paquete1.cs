using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_9
{
    internal class paquete1
    {
        int codigo;
        string descripcion;
        string destinatario;
        string direccion;

        public paquete1(int codigo, string descripcion, string destinatario, string direccion)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Destinatario = destinatario;
            this.Direccion = direccion;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
