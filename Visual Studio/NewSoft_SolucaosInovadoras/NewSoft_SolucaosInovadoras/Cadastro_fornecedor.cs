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
    public partial class Cadastro_fornecedor : Form
    {
        Validacao v = new Validacao();
        public Cadastro_fornecedor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0
                 || maskedTextBox2.Text.Length == 0 || textBox5.Text.Length == 0 || maskedTextBox3.Text.Length == 0
                || textBox8.Text.Length == 0 || maskedTextBox1.Text.Length == 0)
                 
            {
                MessageBox.Show("Por Favor entre com os dados");
            }
            else
            {


                this.Validate();
                fornecedorBindingSource.EndEdit();
                fornecedorTableAdapter.Update(padariaDataSet.fornecedor);
                this.fornecedorTableAdapter.Fill(this.padariaDataSet.fornecedor);
                fornecedorBindingSource.MoveLast();

                //aparece a mensagem quando der certo
                MessageBox.Show("Fornecedor cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //limpar tela
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                maskedTextBox1.Text = "";
                textBox5.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox2.Text = "";
                textBox8.Text = "";


                //chamar um novo registro
                fornecedorBindingSource.AddNew();
            }
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.padariaDataSet.fornecedor);
            // TODO: This line of code loads data into the 'padariaDataSet.fornecedor' table. You can move, or remove it, as needed.
         // this.fornecedorTableAdapter.Fill(this.padariaDataSet.fornecedor);

            fornecedorBindingSource.AddNew();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 100)
            {
                MessageBox.Show("Limite de caracter permitido=100");
                textBox2.Text = "";
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 30)
            {
                MessageBox.Show("Limite de caracter permitido=30");
                textBox3.Text = "";
                return;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 100)
            {
                MessageBox.Show("Limite de caracter permitido=100");
                textBox5.Text = "";
                return;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length > 70)
            {
                MessageBox.Show("Limite de caracter permitido=70");
                textBox8.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar tela
      
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            textBox5.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox2.Text = "";
            textBox8.Text = "";
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Pesquisa_de_Fornecedor form2 = new Pesquisa_de_Fornecedor();
            form2.ShowDialog();
            this.Visible = true;

            this.fornecedorTableAdapter.Fill(this.padariaDataSet.fornecedor);
            if (Class1.codigo == "")
            { fornecedorBindingSource.AddNew(); }
            else
            { fornecedorBindingSource.Filter = string.Format("forn_cd ={0}", Class1.codigo); }
            Class1.codigo = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteLetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //v.somenteLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //if (maskedTextBox2.Text.Length > 8)
            //{
            //    MessageBox.Show("Limite de caracter permitido=8");
            //    maskedTextBox2.Text = "";
            //    return;
            //}
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
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

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.somenteNumeros(e);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //if (maskedTextBox1.Text.Length > 17)
            //{
            //    MessageBox.Show("Limite de caracter permitido=14");
            //    maskedTextBox1.Text = "";
            //    return;
            //}
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
//         !!!FOCA NA PROGRAMAÇÃO!!!
//          -+//---:yo-:.                            
//      `.:.-:-.::  /:.                          
//     .``./+--.:-.`..`  +/                         
//    ````. -:-.`.`. ..   d`                        
//        .   :. ` ``  `  :s                        
//        `    +           -/`                      
//            o            `:-`                    
//            ./              .:-`                  
//            +`                ./-                 
//            o                   y/....``          
//           :h                   : .....:/-.       
//          +:o`        `-.``.    `       `.-/-     
//          s `-        o.   ``              `/+`   
//          +` -      `--    -`                ./-  
//          :-  -    :-`     s`                  -o 
//  .::o:---/`  `/` /.     .o-                    ++
//.:+:-.````    :y+sh     .d.   `.` `...````````   y
///://::------:/-` `/-    `--:++:://:.``.-.       .o
// ```               -/:-`    ..+yo/---.    ..`.:/:`
//                       -/:--`..-o/:o//-://..--`   
//                           `----s:   `.`