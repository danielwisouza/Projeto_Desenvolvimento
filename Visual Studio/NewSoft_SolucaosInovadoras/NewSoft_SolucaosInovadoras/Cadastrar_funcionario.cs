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
    public partial class Cadastrar_funcionario : Form
    {
        Validacao v = new Validacao();

        public Cadastrar_funcionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || maskedTextBox5.Text.Length == 0 || textBox4.Text.Length == 0
             || textBox6.Text.Length == 0 || textBox7.Text.Length == 0 || textBox8.Text.Length == 0
           || maskedTextBox4.Text.Length == 0 || maskedTextBox3.Text.Length == 0  || comboBox3.Text.Length == 0
   || textBox13.Text.Length == 0 || textBox15.Text.Length == 0 || comboBox2.Text.Length == 0 || maskedTextBox2.Text.Length == 0 || textBox15.Text.Length == 0 
                )
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {

                //this.Validate();
                //funcionariosBindingSource.EndEdit();
                //funcionariosTableAdapter.Update(padariaDataSet.funcionarios);
                //this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
                //funcionariosBindingSource.MoveLast();

                this.Validate();
                funcionariosBindingSource.EndEdit();
                funcionariosTableAdapter.Update(padariaDataSet.funcionarios);
                this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
                funcionariosBindingSource.MoveLast();

                //aparece a mensagem quando der certo
                MessageBox.Show("Funcionario cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                textBox1.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox5.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                maskedTextBox4.Text = "";
                maskedTextBox3.Text = "";
                richTextBox1.Text = "";
                comboBox3.Text = "";
                textBox15.Text = "";
                textBox13.Text = "";
                comboBox2.Text = "";


                //chamar um novo registro
                funcionariosBindingSource.AddNew();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpar tela
            textBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox5.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox3.Text = "";
            richTextBox1.Text = "";
            comboBox3.Text = "";
            textBox15.Text = "";
            textBox13.Text = "";
            comboBox2.Text = "";
         
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrar_funcionario_Load(object sender, EventArgs e)
        {
            funcionariosBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pesquisa_funcionario form2 = new pesquisa_funcionario();
            form2.ShowDialog();
            this.Visible = true;

            this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            if (Class1.codigo == "")
            { funcionariosBindingSource.AddNew(); }
            else
            { funcionariosBindingSource.Filter = string.Format("func_cd ={0}", Class1.codigo); }
            Class1.codigo = "";



        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 200)
            {
                MessageBox.Show("Limite de caracter permitido=200");
                textBox1.Text = "";
                return;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox8.Text.Length > 30)
            {
                MessageBox.Show("Limite de caracter permitido=30");
                textBox8.Text = "";
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

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 20)
            {
                MessageBox.Show("Limite de caracter permitido=20");
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

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text.Length > 20)
            {
                MessageBox.Show("Limite de caracter permitido=20");
                textBox13.Text = "";
                return;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text.Length > 20)
            {
                MessageBox.Show("Limite de caracter permitido=20");
                textBox15.Text = "";
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //if (maskedTextBox3.Text.Length > 11)
            //{
            //    MessageBox.Show("Limite de caracter permitido=11");
            //    maskedTextBox3.Text = "";
            //    return;
            //}
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //if (maskedTextBox4.Text.Length > 11)
            //{
            //    MessageBox.Show("Limite de caracter permitido=9");
            //    maskedTextBox4.Text = "";
            //    return;
            //}
        }


        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maskedTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }



        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            //if (maskedTextBox5.Text.Length > 13)
            //{
            //    MessageBox.Show("Limite de caracter permitido= 11");
            //    maskedTextBox5.Text = "";
            //    return;
            //}
        }

        private void maskedTextBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);

        }

        private void maskedTextBox2_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            //if (maskedTextBox2.Text.Length > 9)
            //{
            //    MessageBox.Show("Limite de caracter permitido= 8");
            //    maskedTextBox2.Text = "";
            //    return;
            //}
        }

        private void maskedTextBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ajudacadastros janelanova = new ajudacadastros();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                richTextBox1.Text = "";
                return;
            }
        }

      
        }


    }

