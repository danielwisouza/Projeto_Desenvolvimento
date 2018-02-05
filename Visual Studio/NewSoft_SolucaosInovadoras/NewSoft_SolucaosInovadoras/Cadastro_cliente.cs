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
    public partial class Cadastro_cliente : Form
    {
        Validacao v = new Validacao();
        public Cadastro_cliente()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || maskedTextBox1.Text.Length == 0
                || textBox7.Text.Length == 0 || maskedTextBox3.Text.Length == 0 || textBox6.Text.Length == 0
                || maskedTextBox2.Text.Length == 0 || textBox9.Text.Length == 0
                || comboBox1.Text.Length == 0 || maskedTextBox2.Text.Length == 0)
 
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {

                
                //this.Validate();
                //clienteBindingSource.EndEdit();
                //clienteTableAdapter.Update(padariaDataSet.Cliente);
                //this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
                //clienteBindingSource.MoveLast();
                this.Validate();
                clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(padariaDataSet.Cliente);
                this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
                clienteBindingSource.MoveLast();

                //aparece a mensagem quando der certo
                MessageBox.Show("Cliente cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                textBox1.Text = "";
                textBox2.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox3.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                maskedTextBox2.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                comboBox1.Text = "";

                //chamar um novo registro
                clienteBindingSource.AddNew();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
            // TODO: This line of code loads data into the 'padariaDataSet.Cliente' table. You can move, or remove it, as needed.
          //  this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
         clienteBindingSource.AddNew();


      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            maskedTextBox2.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            comboBox1.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                textBox7.Text = "";
                return;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 20)
            {
                MessageBox.Show("Limite de caracter permitido=20");
                textBox9.Text = "";
                return;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                textBox10.Text = "";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Pesquisa_cliente form2 = new Pesquisa_cliente();
            form2.ShowDialog();
            this.Visible = true;

            this.clienteTableAdapter.Fill(this.padariaDataSet.Cliente);
            if (Class1.codigo == "")
            { clienteBindingSource.AddNew(); }
            else
            { clienteBindingSource.Filter = string.Format("cli_cd ={0}", Class1.codigo); }
            Class1.codigo = "";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteLetras(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

       

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //if (maskedTextBox1.Text.Length > 11)
            //{
            //    MessageBox.Show("Limite de caracter permitido=9");
            //    maskedTextBox1.Text = "";
            //    return;
            //}
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox2.Text.Length > 8)
            {
                MessageBox.Show("Limite de caracter permitido=8");
                maskedTextBox2.Text = "";
                return;
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            if (maskedTextBox3.Text.Length > 11)
            {
                MessageBox.Show("Limite de caracter permitido=11");
                maskedTextBox3.Text = "";
                return;
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ajudacadastros janelanova = new ajudacadastros();
            janelanova.ShowDialog();
            this.Visible = true;
        }
    }
}
