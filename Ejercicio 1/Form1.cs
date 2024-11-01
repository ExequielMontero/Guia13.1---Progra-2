using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Agencia agencia;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            string ruta = Path.Combine(Application.StartupPath, "Estado.txt");
            try
            {
                if (File.Exists(ruta))
                {
                    fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    agencia = bf.Deserialize(fs) as Agencia;
                    
                    if (agencia.Estado().Length > 0)
                    {
                        foreach(string f in agencia.Estado())
                        {
                            lbVer.Items.Add(f);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se ha encontrado el archivo de persistencia");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (agencia == null)
            {
                agencia = new Agencia();
            }
            try
            {
                long dni;
                string patente = tbPatente.Text;
                agencia.listavehiculos.Sort();
                if (rbDenuncia.Checked)
                {
                    int idx = agencia.listavehiculos.BinarySearch((new Vehiculo(patente, new Cliente(100000000))));
                    if (idx >= 0)
                    {
                        Denuncia ahora = new Denuncia(agencia[idx]);
                        agencia.Agregarticket(ahora);
                        lbVer.Items.Add($"{ahora.ToString()}");
                    }
                    else
                    {
                        throw new Exception("Vehiculo no asegurado");
                    }
                }
                else if (rbNuevo.Checked)
                {
                    dni = Convert.ToInt64(tbDni.Text);
                    Cliente f = new Cliente(dni);
                    int idx = agencia.listavehiculos.BinarySearch((new Vehiculo(patente, f)));
                    if (idx >= 0)
                    {
                        throw new Exception("Vehiculo ya asegurado");
                    }
                    else
                    {
                        Vehiculo automovil = new Vehiculo(patente, f);
                        agencia.listavehiculos.Add(automovil);
                        agencia.Agregarticket(f);
                        f.RecibirPatente(patente);
                        lbVer.Items.Add($"{f.ToString()}");
                        agencia.cantidadvehiculos++;
                    }
                }
            }
            catch (Exception z)
            {
                MessageBox.Show($"Excepcion: {z.Message}");
            }

        }

        private void btnAtenderDenuncia_Click(object sender, EventArgs e)
        {
            try
            {
                int tipo = 0;
                Denuncia actual = (Denuncia)agencia.Atenderticket(tipo);
                lbVer.Items.Remove(actual.ToString());
            }
            catch
            {
                MessageBox.Show("No hay Denuncias aun");
            }

        }

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int tipo = 1;
                Cliente actual = (Cliente)agencia.Atenderticket(tipo);
                lbVer.Items.Remove(actual.ToString());
            }
            catch
            {
                MessageBox.Show("No hay Nuevos clientes aun");
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            string ruta = Path.Combine(Application.StartupPath, "Estado.txt");
            try
            {
                fs = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                bf.Serialize(fs,agencia);
            }
            catch
            {

            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
