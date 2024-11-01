using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    [Serializable]
    internal class Ticket:IComparable
    {
        public int nroOrden { get; protected set; }
        private DateTime fechaHora = DateTime.Now;
        public int VerNro()
        {
            return nroOrden;
        }
        public DateTime VerfechaHora()
        {
            return fechaHora;
        }
        public int CompareTo(object obj)
        {
            Ticket actual = obj as Ticket;
            if (actual != null)
            {
                return this.nroOrden.CompareTo(actual.nroOrden);
            }
            return 1;
        }
    }
}
