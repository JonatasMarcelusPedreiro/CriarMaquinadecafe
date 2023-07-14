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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            lblPagamento.Text = "PIX";
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            lblPagamento.Text = "DINHEIRO";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblPagamento.Text = "CARTÃO";
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

            
            


        }

        private void btnComprar2_Click(object sender, EventArgs e)
        {
            double valor;

            valor = double.Parse(txtValor.Text);

            if (valor == 5.00)
            {
                MessageBox.Show(" Retire seu produto!");

            }
            else
            {

                MessageBox.Show(" Esse valor é incorreto!");

            }

        }
    }
}
