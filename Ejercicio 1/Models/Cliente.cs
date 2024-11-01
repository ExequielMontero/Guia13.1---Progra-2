using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    [Serializable]
    internal class Cliente:Ticket
    {
        public long Dni;
        private static int numero = 1;
        string patente;

        public Cliente(long dni)
        {
            if (dni > 5000000 && Regex.Match(dni.ToString(), @"^\d{7,}$").Success==true)
            {
                Dni = dni;
            }
            else
            {
                throw new Exception("Dni incorrecto");
            }
            nroOrden = numero;
            this.Dni = dni;
        }

        public void RecibirPatente(string patente)
        {
            this.patente = patente;
        }
        public override string ToString()
        {
            return $"Nuevo cliente - Dni: {Dni}, Patente: {patente}, Turno: {numero}";
        }
    }
}
