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
    public partial class Pesquisa_encomenda : Form
    {
        public Pesquisa_encomenda()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                encomendaBindingSource.Filter = "";
            }
            else
            {
                encomendaBindingSource.Filter = string.Format("Cli_cd like'%{0}%'", TextBox1.Text);
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
                encomendaBindingSource.RemoveCurrent();
                encomendaTableAdapter.Update(padariaDataSet.encomenda); //salvar
                this.encomendaTableAdapter.Fill(this.padariaDataSet.encomenda);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                throw;
            }
        }

        private void Pesquisa_encomenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alunosDataSet.Alunos' table. You can move, or remove it, as needed.
            this.encomendaTableAdapter.Fill(this.padariaDataSet.encomenda);
            if (Class1.codigo == "")//
            { encomendaBindingSource.AddNew(); }//
            else//
            { encomendaBindingSource.Filter = string.Format("Enc_desc_prod like'%{0}%'", Class1.codigo); }//
            // TODO: This line of code loads data into the 'padariaDataSet.encomenda' table. You can move, or remove it, as needed.
            this.encomendaTableAdapter.Fill(this.padariaDataSet.encomenda);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja alterer a encomeda", "Confirmação",
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
                encomendaBindingSource.Filter = string.Format("Enc_cd={0}", TextBox1.Text);
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
