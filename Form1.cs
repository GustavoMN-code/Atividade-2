using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double entrada; //recebe o número digitado
            int saida; //recebe o valor convertido

            if ((double.TryParse(textBox1.Text, out entrada))){ 
                                
                saida = Convert.ToInt32(entrada);
                label1.Text = Convert.ToString(saida);
            }
            else
            {
                MessageBox.Show("Digite um número!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
