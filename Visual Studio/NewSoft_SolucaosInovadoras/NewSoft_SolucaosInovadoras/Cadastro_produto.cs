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
    public partial class Cadastro_produto : Form
    {
        Validacao v = new Validacao();
        public Cadastro_produto()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.padariaDataSet.fornecedor);
            // TODO: This line of code loads data into the 'padariaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.padariaDataSet.produto);
         
            produtoBindingSource.AddNew();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            TextBox2.Text = "";
            comboBox1.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0 || TextBox2.Text.Length == 0 || comboBox1.Text.Length == 0
                || TextBox4.Text.Length == 0 || TextBox5.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {




                this.Validate();
                produtoBindingSource.EndEdit();
                produtoTableAdapter.Update(padariaDataSet.produto);
                this.produtoTableAdapter.Fill(this.padariaDataSet.produto);
                produtoBindingSource.MoveLast();

                //aparece a mensagem quando der certo
                MessageBox.Show("Produto cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                TextBox1.Text = "";
                TextBox2.Text = "";
                comboBox1.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";

                //chamar um novo registro
                produtoBindingSource.AddNew();
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            tela_principal janelanova = new tela_principal();
            janelanova.ShowDialog();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length > 15)
            {
                MessageBox.Show("Limite de caracter permitido=15");
                TextBox2.Text = "";
                return;
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length > 20)
            {
                MessageBox.Show("Limite de caracter permitido=20");
                TextBox4.Text = "";
                return;
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (TextBox5.Text.Length > 150)
            {
                MessageBox.Show("Limite de caracter permitido=150");
                TextBox5.Text = "";
                return;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Pesquisa_de_Produto form2 = new Pesquisa_de_Produto();
            form2.ShowDialog();
            this.Visible = true;

            this.produtoTableAdapter.Fill(this.padariaDataSet.produto);
            if (Class1.codigo == "")
            { produtoBindingSource.AddNew(); }
            else
            { produtoBindingSource.Filter = string.Format("prod_cd ={0}", Class1.codigo); }
            Class1.codigo = "";
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            ajudacadastros teste = new ajudacadastros();
            teste.ShowDialog();
            this.Visible=true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }
    }
}
