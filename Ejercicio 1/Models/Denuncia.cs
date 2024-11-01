using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    [Serializable]
    internal class Denuncia:Ticket
    {
        public Vehiculo dominio { get; private set; }
        static private int numero=1;

        public Denuncia(Vehiculo asegurado)
        {
            nroOrden = numero;
            numero++;
            dominio = asegurado;
        }

        public override string ToString()
        {
            return $"Denuncia - Patente: {dominio.Nropatente}, Turno: {nroOrden}";
        }

    }
}
