using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_9
{
    internal class Camionero
    {
        float salario;
        string direccion;
        int telefono;
        string nom;
        int poblacion;
        float rfc;

        public Camionero(float salario, string direccion, int telefono, string nom, int poblacion, float rfc)
        {
            this.Salario = salario;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Nom = nom;
            this.Poblacion = poblacion;
            this.Rfc = rfc;
        }
        public Camionero()
        {

        }

        public float Salario { get => salario; set => salario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Poblacion { get => poblacion; set => poblacion = value; }
        public float Rfc { get => rfc; set => rfc = value; }
    }
}
