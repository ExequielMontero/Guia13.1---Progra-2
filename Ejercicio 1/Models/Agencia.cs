using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1.Models
{
    [Serializable]
    internal class Agencia
    {
        public List<Ticket> listaatendidos = new List<Ticket>();
        public List<Vehiculo> listavehiculos = new List<Vehiculo>();
        Queue<Denuncia> denuncias = new Queue<Denuncia>();
        Queue<Cliente> clientes = new Queue<Cliente>();
        public int cantidadvehiculos = 0;
        public Vehiculo this[int idx]
        {

            get
            {
                if (cantidadvehiculos>=1)
                { 
                    return listavehiculos[idx];
                }
                return null;
            }
        }


        public void Agregarticket(Ticket turno)
        {
            if (turno is Denuncia)
            {
                denuncias.Enqueue((Denuncia)turno);
            }
            else if (turno is Cliente)
            {
                clientes.Enqueue((Cliente)turno);
            }
        }

        public Ticket Atenderticket(int tipo)
        {
            Ticket f=null;
            if (tipo == 0)
            {
                f = denuncias.Dequeue();
                listaatendidos.Add(f);
            }
            else
            {
                f = clientes.Dequeue();
                listaatendidos.Add(f);
            }
            return f;
        }

        public string[] Estado()
        {
            int i = 0;
            string[] resumen = new string[denuncias.Count + clientes.Count];
            foreach(Denuncia f in denuncias)
            {
                string linea = f.ToString();
                resumen[i++] = linea;
            }
            foreach (Cliente f in clientes)
            {
                string linea = f.ToString();
                resumen[i++] = linea;
            }
            return resumen;
        }
        
    }
}
