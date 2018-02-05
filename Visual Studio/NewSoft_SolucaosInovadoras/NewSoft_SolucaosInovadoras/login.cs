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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {//Limpar
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Login e senha estáticos

            if ((textBox1.Text == "adm") && (textBox2.Text == "123"))
            {
                this.Visible = false;
                tela_principal newform3 = new tela_principal();
                newform3.ShowDialog();

            }

            //Login dos Funcionarios
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Entre com os dados");
            }
            else
            {
                funcionariosBindingSource.Filter = "Func_Login='" + textBox1.Text + "'";

                if (textBox1.Text.ToUpper() != textBox3.Text.ToUpper())
                {
                    MessageBox.Show("USUARIO ERRADO");
                    return;
                }
                if (textBox2.Text.ToUpper() != textBox4.Text.ToUpper())
                {
                    MessageBox.Show("SENHA ERRADA");
                    return;
                }
                this.Visible = false;
                tela_principal newmenu = new tela_principal();
                newmenu.ShowDialog();



                //{

                //    if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
                //    {
                //        MessageBox.Show("Entre com os dados");
                //    }
                //    else
                //    {
                //        funcionariosBindingSource.Filter = "Func_Login='" + textBox1.Text + "'";

                //        if (textBox1.Text.ToUpper() != textBox3.Text.ToUpper() ||
                //            textBox2.Text.ToUpper() != textBox4.Text.ToUpper() ||
                //            comboBox1.SelectedItem.ToString().ToUpper() != comboBox2.Text.ToUpper())
                //        {
                //            MessageBox.Show("Dados incorretos");
                //            return;
                //        }

                //        if (comboBox1.SelectedItem.ToString() == "Adm")
                //        {
                //            this.Visible = false;
                //            tela_principal newtelaprincipal = new tela_principal();
                //            newtelaprincipal.ShowDialog();
                //            this.Visible = true;
                //        }
                //        if (comboBox1.SelectedItem.ToString() == "Funcionario")
                //        {
                //            this.Visible = false;
                //            tela_principal newtelaprincipal = new tela_principal();
                //            newtelaprincipal.funcionarioToolStripMenuItem.Enabled = false; // Este item, o funcionario comum não vê
                //            newtelaprincipal.backupERestauracãoToolStripMenuItem.Enabled = false; // Este item, o funcionario comum não vê
                //            newmenu.ShowDialog();
                //        }
                //    }
                //}

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.padariaDataSet.funcionarios);

            //Deixando tabel transparente
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 20)
            {
                MessageBox.Show("Limite de caracter permitido=20");
                textBox1.Text = "";
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 20)
            {
                MessageBox.Show("Limite de caracter permitido=20");
                textBox2.Text = "";
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Entre com os dados");
            }
            else
            {
                funcionariosBindingSource.Filter = "Func_login='" + textBox1.Text + "'";

                if (textBox1.Text.ToUpper() != textBox3.Text.ToUpper() ||
                    textBox2.Text.ToUpper() != textBox4.Text.ToUpper() ||
                    comboBox1.SelectedItem.ToString().ToUpper() != comboBox2.Text.ToUpper())
                {
                    MessageBox.Show("Dados incorretos");
                    return;
                }

                if (comboBox1.SelectedItem.ToString() == "Adm")
                {
                    this.Visible = false;
                    tela_principal newtelaprincipal = new tela_principal();
                    newtelaprincipal.ShowDialog();
                    this.Visible = true;
                }
                if (comboBox1.SelectedItem.ToString() == "Funcionario")
                {
                    this.Visible = false;
                    tela_principal newtelaprincipal = new tela_principal();
                    newtelaprincipal.funcionarioToolStripMenuItem.Enabled = false; // Este item, o funcionario comum não vê
                    newtelaprincipal.backupERestauracãoToolStripMenuItem.Enabled = false; // Este item, o funcionario comum não vê
                    newtelaprincipal.fornecedorToolStripMenuItem.Enabled = false; // Este item, o funcionario comum não vê
                    newtelaprincipal.ShowDialog();
                }
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
