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
    public partial class pesquisa_funcionario : Form
    {
        public pesquisa_funcionario()
        {
            InitializeComponent();
        }
       

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            // TODO: This line of code loads data into the 'alunosDataSet.Alunos' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            if (Class1.codigo == "")//
            { funcionariosBindingSource.AddNew(); }//
            else//
         { funcionariosBindingSource.Filter = string.Format("func_nome like'%{0}%'", Class1.codigo); }//
            // TODO: This line of code loads data into the 'padariaDataSet.funcionarios' table. You can move, or remove it, as needed.
        this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
               funcionariosBindingSource.Filter = "";
            }
            else
            {
               funcionariosBindingSource.Filter = string.Format("func_nome like'%{0}%'", TextBox1.Text);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja alterar Funcionario?", "confirmação",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Você deseja excluir o item?", "Confirmação",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                
                try
            {
                string codigo;
                codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                funcionariosBindingSource.RemoveCurrent();
                funcionariosTableAdapter.Update(padariaDataSet.funcionarios); //salvar
                this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            tela_principal janelanova = new tela_principal();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Visible = false;
            tela_principal form2 = new tela_principal();
            form2.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com o Código");
            }
            else
            {
                funcionariosBindingSource.Filter = string.Format("Func_cd={0}", TextBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            ajudapesquisa teste = new ajudapesquisa();
            teste.ShowDialog();
            this.Visible = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
