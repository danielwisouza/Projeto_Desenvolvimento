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
    public partial class Pesquisa_caixa : Form
    {
        public Pesquisa_caixa()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                caixaBindingSource.Filter = "";
            }
            else
            {
                caixaBindingSource.Filter = string.Format("Cli_nm like'%{0}%'", TextBox1.Text);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja excluir o item?", "Confirmação",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            try
            {
                string codigo;
                codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                caixaBindingSource.RemoveCurrent();
                caixaTableAdapter.Update(padariaDataSet.caixa); //salvar
                this.caixaTableAdapter.Fill(this.padariaDataSet.caixa);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                throw;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja alterar o Caixa?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
                this.Close();
            }
            
        }
        
        private void Pesquisa_caixa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.caixa' table. You can move, or remove it, as needed.
            this.caixaTableAdapter.Fill(this.padariaDataSet.caixa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com o Código");
            }
             else
            {
                caixaBindingSource.Filter = string.Format("Caixa_cd={0}", TextBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ajudapesquisa teste = new ajudapesquisa();
            teste.ShowDialog();
            this.Visible = true;
        }
    }
}
