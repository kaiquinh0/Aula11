using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Funcionario f = new Funcionario();
        private void btnFerias_Click(object sender, EventArgs e)
        {
            f.Nome = txtNome.Text;
            f.Salario = double.Parse(txtSalario.Text);
            lblValor.Text = "Valor das férias = "+
                f.Calcular(int.Parse(txtTempo.Text)).ToString();
        }

        private void btnInss_Click(object sender, EventArgs e)
        {
            f.Nome = txtNome.Text;
            f.Salario = double.Parse(txtSalario.Text);
            lblValor.Text = "Valor das INSS = " +
                f.Calcular().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedor v = new Vendedor();
            v.Nome = txtNome.Text;
            v.Salario = double.Parse(txtSalario.Text);
            lblValor.Text = "Valor da comissão = " +
                v.Calcular(6).ToString();
        }
    }
}
