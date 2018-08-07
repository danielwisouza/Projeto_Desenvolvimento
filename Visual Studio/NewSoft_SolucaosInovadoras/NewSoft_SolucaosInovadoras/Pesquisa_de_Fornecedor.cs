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
    public partial class Pesquisa_de_Fornecedor : Form
    {
        public Pesquisa_de_Fornecedor()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                fornecedorBindingSource.Filter = "";
            }
            else
            {
                fornecedorBindingSource.Filter = string.Format("forn_nome like'%{0}%'", TextBox1.Text);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja excluir o item?", "Confirmação",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                
                try
            {
                string codigo;
                codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fornecedorBindingSource.RemoveCurrent();
                fornecedorTableAdapter.Update(padariaDataSet.fornecedor); //salvar
                this.fornecedorTableAdapter.Fill(this.padariaDataSet.fornecedor);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                throw;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pesquisa_de_Fornecedor_Load(object sender, EventArgs e)
        {
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
            
            // TODO: This line of code loads data into the 'alunosDataSet.Alunos' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.padariaDataSet.fornecedor);
            if (Class1.codigo == "")//
            { fornecedorBindingSource.AddNew(); }//
            else//
            { fornecedorBindingSource.Filter = string.Format("forn_nome like'%{0}%'", Class1.codigo); }//// TODO: This line of code loads data into the 'padariaDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.padariaDataSet.fornecedor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja alterar o fornecedor?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Class1.codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            tela_principal form2 = new tela_principal();
            form2.ShowDialog();
            this.Visible = true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 100)
            {
                MessageBox.Show("Limite de caracter permitido=100");
                TextBox1.Text = "";
                return;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com o Código");
            }
            else
            {
                fornecedorBindingSource.Filter = string.Format("Forn_cd={0}", TextBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            ajudapesquisa teste = new ajudapesquisa();
            teste.ShowDialog();
            this.Visible = true;
        }
    }
}
