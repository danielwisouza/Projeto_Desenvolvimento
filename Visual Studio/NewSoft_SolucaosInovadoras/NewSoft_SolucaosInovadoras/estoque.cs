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
    public partial class estoque : Form
    {

        Validacao v = new Validacao();
        public estoque()
        {
            InitializeComponent();
        }

        private void frn8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.padariaDataSet.produto);
            // TODO: This line of code loads data into the 'padariaDataSet.estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this.padariaDataSet.estoque);
            estoqueBindingSource.AddNew();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0 || comboBox1.Text.Length == 0 || TextBox4.Text.Length == 0 || TextBox3.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {




                this.Validate();
                estoqueBindingSource.EndEdit();
                estoqueTableAdapter.Update(padariaDataSet.estoque);
                this.estoqueTableAdapter.Fill(this.padariaDataSet.estoque);
                estoqueBindingSource.MoveLast();


                //aparece a mensagem quando der certo
                MessageBox.Show("Produto estocado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                TextBox1.Text = "";
                comboBox1.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";






                //chamar um novo registro
                estoqueBindingSource.AddNew();
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Pesquisa_estoque form2 = new Pesquisa_estoque();
            form2.ShowDialog();
            this.Visible = true;

            this.estoqueTableAdapter.Fill(this.padariaDataSet.estoque);
            if (Class1.codigo == "")
            { estoqueBindingSource.AddNew(); }
            else
            { estoqueBindingSource.Filter = string.Format("estoq_cd ={0}", Class1.codigo); }
            Class1.codigo = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //limpar tela

            comboBox1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length > 150)
            {
                MessageBox.Show("Limite de caracter permitido=150");
                TextBox3.Text = "";
                return;
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length > 50)
            {
                MessageBox.Show("Limite de caracter permitido=50");
                TextBox4.Text = "";
                return;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);

        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);

        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            v.somenteLetras(e);
        }
    }
}
