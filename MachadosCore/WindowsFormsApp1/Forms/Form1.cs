using MachadosCore;
using MachadosCore.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarCleintes_Click(object sender, EventArgs e)
        {

            AdicionarPacientes clienteAdicionar = new AdicionarPacientes();
            clienteAdicionar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
