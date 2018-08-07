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
    public partial class Pesquisa_cliente : Form
    {
        public Pesquisa_cliente()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
            // TODO: This line of code loads data into the 'padariaDataSet.funcionarios' table. You can move, or remove it, as needed.
           // this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            // TODO: This line of code loads data into the 'alunosDataSet.Alunos' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
            if (Class1.codigo == "")//
            { clienteBindingSource.AddNew(); }//
            else//
            { clienteBindingSource.Filter = string.Format("cli_nm like'%{0}%'", Class1.codigo); }//// TODO: This line of code loads data into the 'padariaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
            //// TODO: This line of code loads data into the 'padariaDataSet.Cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
            //// TODO: This line of code loads data into the 'padariaDataSet.Cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                clienteBindingSource.Filter = "";
            }
            else
            {
                clienteBindingSource.Filter = string.Format("cli_nm like'%{0}%'", TextBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja excluir um Cliente???", "Confirmação",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                 if (Button4.Text.Length == 0)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                Button4.Text = "";
                return;
            }
            try
            {
               string codigo;
               codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               clienteBindingSource.RemoveCurrent();
               clienteTableAdapter.Update(padariaDataSet.Cliente); //salvar
               this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }

        }
    }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja alterar o Cliente?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            tela_principal form2 = new tela_principal();
            form2.ShowDialog();
            this.Visible = true;
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
                clienteBindingSource.Filter = string.Format("Cli_cd={0}", TextBox1.Text);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            this.Visible = false;
            ajudapesquisa teste = new ajudapesquisa();
            teste.ShowDialog();
            this.Visible = true;
        }
    }
}
