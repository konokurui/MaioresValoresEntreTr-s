using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaioresValoresEntreTrês
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(numUpD1.Value);
            int valor2 = Convert.ToInt32(numUpD2.Value);
            int valor3 = Convert.ToInt32(numUpD3.Value);
            if(valor1 == valor2 && valor2 == valor3)
            {
                lblResultado.Text = "Os valores são iguais.";
            }
            if (valor1 > valor2 && valor1 > valor3)
            {
                lblResultado.Text = "O Valor 1 é maior que os demais.";
            }
            if (valor2 > valor1 && valor2 > valor3)
            {
                lblResultado.Text = "O Valor 2 é maior que os demais.";
            }
            if (valor3 > valor1 && valor3 > valor2)
            {
                lblResultado.Text = "O Valor 3 é maior que os demais.";
            }   

        }
    }
}
