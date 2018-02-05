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
    public partial class Encomenda : Form
    {
        Validacao v = new Validacao();
        public Encomenda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
            // TODO: This line of code loads data into the 'padariaDataSet.encomenda' table. You can move, or remove it, as needed.
            this.encomendaTableAdapter.Fill(this.padariaDataSet.encomenda);
            encomendaBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || comboBox2.Text.Length == 0 || textBox4.Text.Length == 0 || comboBox1.Text.Length == 0 
                || textBox5.Text.Length == 0 || textBox6.Text.Length == 0 )
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {



                this.Validate();
                encomendaBindingSource.EndEdit();
                encomendaTableAdapter.Update(padariaDataSet.encomenda);
                this.encomendaTableAdapter.Fill(this.padariaDataSet.encomenda);
                encomendaBindingSource.MoveLast();

                //aparece a mensagem quando der certo
                MessageBox.Show("Encomenda feita com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                textBox1.Text = "";
                comboBox2.Text = "";
                richTextBox1.Text = "";
                textBox6.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";


                //chamar um novo registro
                encomendaBindingSource.AddNew();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Pesquisa_encomenda form2 = new Pesquisa_encomenda();
            form2.ShowDialog();
            this.Visible = true;

            this.encomendaTableAdapter.Fill(this.padariaDataSet.encomenda);
            if (Class1.codigo == "")
            { encomendaBindingSource.AddNew(); }
            else
            { encomendaBindingSource.Filter = string.Format("Enc_cd ={0}", Class1.codigo); }
            Class1.codigo = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 150)
            {
                MessageBox.Show("Limite de caracter permitido=150");
                richTextBox1.Text = "";
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 20)
            {
                MessageBox.Show("Limite de caracter permitido=20");
                textBox6.Text = "";
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
            if (textBox4.Text.Length > 10)
            {
                MessageBox.Show("Limite de caracter permitido=10");
                textBox4.Text = "";
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteLetras(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  v.somenteNumeros(e);
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }
    }
}
