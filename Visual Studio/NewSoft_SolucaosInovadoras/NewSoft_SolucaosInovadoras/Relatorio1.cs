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
    public partial class Relatorio1 : Form
    {
        Validacao v = new Validacao();
        public Relatorio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Relatorio1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);
            // TODO: This line of code loads data into the 'padariaDataSet.Padaria_relatorios' table. You can move, or remove it, as needed.
            this.padaria_relatoriosTableAdapter.Fill(this.padariaDataSet.Padaria_relatorios);

            padariarelatoriosBindingSource.AddNew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //limpar tela
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            dateTimePicker1.Text = "";
            richTextBox1.Text = "";
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0 || textBox2.Text.Length == 0 || maskedTextBox1.Text.Length == 0 || dateTimePicker1.Text.Length == 0 || richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {



                this.Validate();
                padariarelatoriosBindingSource.EndEdit();
                padaria_relatoriosTableAdapter.Update(padariaDataSet.Padaria_relatorios);
                this.padaria_relatoriosTableAdapter.Fill(this.padariaDataSet.Padaria_relatorios);
                padariarelatoriosBindingSource.MoveLast();

                //aparece a mensagem quando der certo
                MessageBox.Show("Relatorio feito com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                comboBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Text = "";
                richTextBox1.Text = "";


                //chamar um novo registro
                padariarelatoriosBindingSource.AddNew();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            pesquisa_relatorio form2 = new pesquisa_relatorio();
            form2.ShowDialog();
            this.Visible = true;

            this.padaria_relatoriosTableAdapter.Fill(this.padariaDataSet.Padaria_relatorios);
            if (Class1.codigo == "")
            { padariarelatoriosBindingSource.AddNew(); }
            else
            { padariarelatoriosBindingSource.Filter = string.Format("relat_cd ={0}", Class1.codigo); }
            Class1.codigo = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }
        }
    }

