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
    public partial class cadastro_funcionario : Form
    {
        public cadastro_funcionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Validate();
           funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(padariaDataSet.funcionarios);
            this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            funcionariosBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show("Funcionario cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox1.Text = "";
            

            //chamar um novo registro
           funcionariosBindingSource.AddNew();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.funcionarios' table. You can move, or remove it, as needed.
            //this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            // TODO: This line of code loads data into the 'alunosDataSet.Alunos' table. You can move, or remove it, as needed.
           
            funcionariosBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox15.Text = "";
            textBox13.Text = "";
            comboBox1.Text = "";
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 12)
            {
                MessageBox.Show("Limite de caracter permitido=12");
                textBox3.Text = "";
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 100)
            {
                MessageBox.Show("Limite de caracter permitido=100");
                textBox1.Text = "";
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 13)
            {
                MessageBox.Show("Limite de caracter permitido=13");
                textBox3.Text = "";
                return;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                textBox11.Text = "";
                return;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                textBox8.Text = "";
                return;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 9)
            {
                MessageBox.Show("Limite de caracter permitido=9");
                textBox9.Text = "";
                return;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                textBox4.Text = "";
                return;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Length > 15)
            {
                MessageBox.Show("Limite de caracter permitido=15");
                textBox10.Text = "";
                return;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 30)
            {
                MessageBox.Show("Limite de caracter permitido=30");
                textBox7.Text = "";
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 150)
            {
                MessageBox.Show("Limite de caracter permitido=150");
                textBox5.Text = "";
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pesquisa_funcionario form2 = new pesquisa_funcionario();
            form2.ShowDialog();
            this.Visible = true;

            this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            if (Class1.codigo == "")//
            { funcionariosBindingSource.AddNew(); }//
            else//
            { funcionariosBindingSource.Filter = string.Format("func_cd ={0}", Class1.codigo); }//
            Class1.codigo = "";
           
        }
    }
}
