using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorMenor6
{
    public partial class FrmMaiorde6 : Form
    {
        int n1, n2, n3, n4, n5, n6, maior;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Finalizar?", "************ FINALIZANDO ************", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Cancelar();
            }
        }

        private void txtN1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                txtN2.Focus();
            }
        }

        private void txtN2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                txtN3.Focus();
            }
        }

        private void txtN3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                txtN4.Focus();
            }
        }

        private void txtN4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Return)
            {
                txtN5.Focus();
            }
        }

        private void txtN5_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                txtN6.Focus();
            }
        }

        private void txtN6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                btnVerifica.Focus();
            }
        }

        string mensagem = "";

        public FrmMaiorde6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region Entrada de dados
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            try
            {
                 n1 = Convert.ToInt32(txtN1.Text);
                 n2 = Convert.ToInt32(txtN2.Text);
                 n3 = Convert.ToInt32(txtN3.Text);
                 n4 = Convert.ToInt32(txtN4.Text);
                 n5 = Convert.ToInt32(txtN5.Text);
                 n6 = Convert.ToInt32(txtN6.Text);

                Testar();
                lblResultado.Text = mensagem;


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "######## ERRO ######", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cancelar();
                
            }
        }
        #endregion

        #region Procedimento Testar()
        public void Testar()
        {
            if(n1>n2 && n1>n3 && n1>n4 && n1>n5 && n1 > n6)
            {
                maior = n1;
                mensagem = $"O maior número é {n1}";
            }
            else if(n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5 && n2 > n6)
            {
                maior = n2;
                mensagem = $"O maior número é {n2}";
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5 && n3 > n6)
            {
                maior = n3;
                mensagem = $"O maior número é {n3}";
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5 && n4 > n6)
            {
                maior = n4;
                mensagem = $"O maior número é {n4}";
            }
            else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4 && n5 > n6)
            {
                maior = n5;
                mensagem = $"O maior número é {n5}";
            }
            else if (n6 > n1 && n6 > n2 && n6 > n3 && n6 > n4 && n6 > n5)
            {
                maior = n6;
                mensagem = $"O maior número é {n6}";
            }
            else if(n1==n2 && n3==n4 && n5==n6)
            {
                mensagem = "Todos os números são iguais...";
            }
            else if(n1 == n2 || n3 == n4 || n5 == n6)
            {
                mensagem = "Existem números iguais na sequência....";
            }
        }
        #endregion

        #region Procedimento Cancelar
        public void Cancelar()
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtN5.Clear();
            txtN6.Clear();

            lblResultado.Text = "";
            txtN1.Focus();
        }

        #endregion
    }
}
