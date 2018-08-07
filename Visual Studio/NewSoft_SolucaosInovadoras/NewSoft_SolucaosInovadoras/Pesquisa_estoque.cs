using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSoft_SolucaosInovadoras
{
    public partial class Pesquisa_estoque : Form
    {
        public Pesquisa_estoque()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Class1.codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Você deseja alterar o Estoque?","confirmação",
              MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {


            Class1.codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
            this.Close();
            }
        }

        private void Pesquisa_estoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this.padariaDataSet.estoque);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 100)
            {
                MessageBox.Show("Limite de caracter permitido=100");
                TextBox1.Text = "";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com o Código");
            }
            else
            {
                estoqueBindingSource.Filter = string.Format("estoq_cd={0}", TextBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            ajudapesquisa teste = new ajudapesquisa();
            teste.ShowDialog();
            this.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Você deseja excluir o item?", "Confirmação",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                try
                {
                    string codigo;
                    codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    estoqueBindingSource.RemoveCurrent();
                    estoqueTableAdapter.Update(padariaDataSet.estoque); //salvar
                    this.estoqueTableAdapter.Fill(this.padariaDataSet.estoque);

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                    throw;
                }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                estoqueBindingSource.Filter = "";
            }
            else
            {
                estoqueBindingSource.Filter = string.Format("estoq_produ like'%{0}%'", TextBox1.Text);
            }
        }
    }
}
