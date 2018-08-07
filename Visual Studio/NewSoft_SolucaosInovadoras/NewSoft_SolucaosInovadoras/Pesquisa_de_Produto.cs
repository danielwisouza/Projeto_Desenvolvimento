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
    public partial class Pesquisa_de_Produto : Form
    {
        public Pesquisa_de_Produto()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                produtoBindingSource.Filter = "";
            }
            else
            {
                produtoBindingSource.Filter = string.Format("prod_nm like'%{0}%'", TextBox1.Text);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja excluir o item?", "Confirmação",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                
                try
            {
                string codigo;
                codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                produtoBindingSource.RemoveCurrent();
                produtoTableAdapter.Update(padariaDataSet.produto); //salvar
                this.produtoTableAdapter.Fill(this.padariaDataSet.produto);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                throw;
            }
        }

        private void pesquisa_de_Produdo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alunosDataSet.Alunos' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.padariaDataSet.produto);
            if (Class1.codigo == "")//
            { produtoBindingSource.AddNew(); }//
            else//
            { produtoBindingSource.Filter = string.Format("prod_nm like'%{0}%'", Class1.codigo); }//
            // TODO: This line of code loads data into the 'padariaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.padariaDataSet.produto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o Produto?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Class1.codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
                this.Close();
            }




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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com o Código");
            }
            else
            {
                produtoBindingSource.Filter = string.Format("Prod_cd={0}", TextBox1.Text);
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
