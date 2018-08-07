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
    public partial class pesquisa_preco : Form
    {
        public pesquisa_preco()
        {
            InitializeComponent();
        }

        private void pesquisa_preco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.Preco' table. You can move, or remove it, as needed.
            this.precoTableAdapter.Fill(this.padariaDataSet.Preco);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            {
                if (TextBox1.Text.Length == 0)
                {
                    precoBindingSource.Filter = "";
                }
                else
                {
                    precoBindingSource.Filter = string.Format("preco_nmprod like'%{0}%'", TextBox1.Text);
                }
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
                precoBindingSource.Filter = string.Format("preco_cd={0}", TextBox1.Text);
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
                    codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    precoBindingSource.RemoveCurrent();
                    precoTableAdapter.Update(padariaDataSet.Preco); //salvar
                    this.precoTableAdapter.Fill(this.padariaDataSet.Preco);

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                    //throw;
                }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja alterar o Preço?", "confirmação",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
                this.Close();
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}