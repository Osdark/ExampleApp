using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    public partial class Form1 : Form
    {
        List<Cliente> clientesLista = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = textBox1.Text;
            cliente.Email = textBox2.Text;
            cliente.Codigo = Convert.ToInt32(textBox3.Text);
            cliente.Edad = Convert.ToInt32(textBox4.Text);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            clientesLista.Add(cliente);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder();
            for (int i = 0; i < clientesLista.Count; i++)
            {
                mensaje.Append("Nombre: ");
                mensaje.Append(clientesLista[i].Nombre);
                mensaje.Append(", Email: ");
                mensaje.Append(clientesLista[i].Email);
                mensaje.Append(", Código: ");
                mensaje.Append(clientesLista[i].Codigo);
                mensaje.Append(", Edad: ");
                mensaje.Append(clientesLista[i].Edad);
                mensaje.Append("\n");
            }
            richTextBox1.Text = mensaje.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Codigo = Convert.ToInt32(textBox3.Text);

            clientesLista.RemoveAt(clientesLista.FindIndex(cl => cl.Codigo == cliente.Codigo));

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();

            cl.Codigo = Convert.ToInt32(textBox3.Text);

            Cliente clienteActualizar = clientesLista.Find(cliente => cliente.Codigo == cl.Codigo);

            clienteActualizar.Nombre = textBox1.Text;
            clienteActualizar.Edad = Convert.ToInt32(textBox4.Text);
            clienteActualizar.Email = textBox2.Text;

            clientesLista.Add(clienteActualizar);

        }
    }
}
