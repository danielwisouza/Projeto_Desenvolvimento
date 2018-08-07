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
    public partial class preço : Form
    {
        Validacao v = new Validacao();
        public preço()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar tela
            comboBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            
            textBox7.Text = " ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.padariaDataSet.produto);
            
            // TODO: This line of code loads data into the 'padariaDataSet.Preco' table. You can move, or remove it, as needed.
            this.precoTableAdapter.Fill(this.padariaDataSet.Preco);
            // TODO: This line of code loads data into the 'padariaDataSet.Preco' table. You can move, or remove it, as needed.
            // this.precoTableAdapter.Fill(this.padariaDataSet.Preco);
            precoBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {
                this.Validate();
                precoBindingSource.EndEdit();
                precoTableAdapter.Update(padariaDataSet.Preco);
                this.precoTableAdapter.Fill(this.padariaDataSet.Preco);
                precoBindingSource.MoveLast();


                //aparece a mensagem quando der certo
                MessageBox.Show("Produto registrado com sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                comboBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";

                //chamar um novo registro
                precoBindingSource.AddNew();
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                textBox2.Text = "";
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                textBox3.Text = "";
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Double valor1, valor3, valor2, total;

                if ((textBox3.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Informe os valores que serão calculados");
                }

                else
                {

                    valor3 = Convert.ToDouble(textBox2.Text);
                    valor2 = Convert.ToDouble(textBox3.Text);

                    total = valor2 + valor3;
                    textBox4.Text = total.ToString();

                    valor1 = valor2 - valor3;
                    textBox7.Text = valor1.ToString();

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pesquisa_preco form2 = new pesquisa_preco();
            form2.ShowDialog();
            this.Visible = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           // v.somenteNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           // v.somenteNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteNumeros(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }
    }
}

