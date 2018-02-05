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
    public partial class caixa : Form
    {
        Validacao v = new Validacao();
        public caixa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox4.Text.Length == 0 || comboBox1.Text.Length == 0
               || richTextBox1.Text.Length == 0 || textBox5.Text.Length == 0 || comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {


                this.Validate();
                caixaBindingSource.EndEdit();
                caixaTableAdapter.Update(padariaDataSet.caixa);
                this.caixaTableAdapter.Fill(this.padariaDataSet.caixa);
                caixaBindingSource.MoveLast();

                //aparece a mensagem quando der certo
                MessageBox.Show("Compra registrada com sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                
                textBox4.Text = " ";
                richTextBox1.Text = " ";
                comboBox1.Text = " ";

                //chamar um novo registro
                caixaBindingSource.AddNew();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            comboBox1.Text = " ";
            textBox4.Text = " ";
            richTextBox1.Text = " ";
            textBox5.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           Pesquisa_caixa form2 = new Pesquisa_caixa();
            form2.ShowDialog();
            this.Visible = true;

            this.caixaTableAdapter.Fill(this.padariaDataSet.caixa);
            if (Class1.codigo == "")
            { caixaBindingSource.AddNew(); }
            else
            { caixaBindingSource.Filter = string.Format("Caixa_cd ={0}", Class1.codigo); }
            Class1.codigo = "";
        }

        private void caixa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.padariaDataSet.produto);
            // TODO: This line of code loads data into the 'padariaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
            // TODO: This line of code loads data into the 'padariaDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            // TODO: This line of code loads data into the 'padariaDataSet.funcionarios' table. You can move, or remove it, as needed.
           
            caixaBindingSource.AddNew();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.Text = "";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 200)
            {
                MessageBox.Show("Limite de caracter permitido=200");
                richTextBox1.Text = "";
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                textBox5.Text = "";
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

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteNumeros(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
