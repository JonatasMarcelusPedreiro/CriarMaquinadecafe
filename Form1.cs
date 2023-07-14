using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05CriarMaquinadecomida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFini_Click(object sender, EventArgs e)
        {

        }

        private void btnOpcao1_Click(object sender, EventArgs e)
        {
            
            
            
            
            lblProduto.Text = "FINI";
        }

        private void btnOpcao2_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "BOLACHA";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Abrir nova tela quando clicar //
            Form2 telaextrato = new Form2();
            telaextrato.Show();
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "CHOCOLATE";
        }

        private void btnSuco_Click(object sender, EventArgs e)
        {
            lblProduto.Text = "SUCO";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
