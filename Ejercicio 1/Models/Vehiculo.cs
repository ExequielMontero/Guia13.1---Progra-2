using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    [Serializable]
    internal class Vehiculo:IComparable
    {
        public string Nropatente { get; private set; }
        private Cliente cliente;
        public Vehiculo(string patente, Cliente persona)
        {
            Nropatente = patente;
            cliente = persona;
        }
        public Cliente VerDueño()
        {
            return cliente;
        }
        public override string ToString()
        {
            return $"Patente: {Nropatente}";
        }
        public int CompareTo(object obj)
        {
            Vehiculo actual = obj as Vehiculo;
            if (actual != null)
            {
                return this.Nropatente.CompareTo(actual.Nropatente);
            }
            return 1;
        }
    }
}
